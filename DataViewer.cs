using OfficeOpenXml;
using PEditor.myclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace PEditor
{
    public partial class DataViewer : Form
    {
        // v2.6.01  ----> minor code corrections
        //          > when selecting single image, it changes the total image to 1 and disables the field
        //          > when not having text in the front/back it disables and hides the field from input
        //
        // v2.6.02  ----> change the image path according to the card number
        //   2022-04-24 - started
        //   2022-04-24 - ended

        connection_class con = new connection_class();
        dataclass dc = new dataclass();

        // search text, sort option, culture
        public string _searchText, sortOption, softCulture, _mainNumber, addSeriesCard, tblName, imgPath;
        // save record number, menu option, view/add/update, row
        public Int32 _nRecord, _menuOption, _addUpdateView, _nRow;
        // software name
        public bool cardIndicator, success, adminRights = true;


        public DataViewer()
        {
            InitializeComponent();
            panel1.Visible = false;
            dataGridCard.Visible = false;
            dataGridExport.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            _searchText = "";
            dataGridCard.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridCard.ForeColor = Color.FromArgb(64, 64, 64);
            dc._GETVERSION();

        }

        private void DataViewer_Load(object sender, EventArgs e)
        {
            // check for default language (from file)
            _fileLanguage();

            // test if internet is accessible and database is online
            try
            {
                // read all labels
                dc.TEMP_LABELS(1, softCulture);
                string softName = dc.langLabels[1];
                string softVersion = dc._vVersion[0];
                this.Text = softName + " - v" + softVersion;
                cardsItem.Text = dc.langLabels[8];
                seriesItem.Text = dc.langLabels[9];
                tablesItem.Text = dc.langLabels[10];
                colorItem.Text = dc.langLabels[11];
                conditionItem.Text = dc.langLabels[12];
                countryItem.Text = dc.langLabels[13];
                differencesItem.Text = dc.langLabels[14];
                imageTypeItem.Text = dc.langLabels[15];
                materialItem.Text = dc.langLabels[16];
                orientationItem.Text = dc.langLabels[17];
                publisherItem.Text = dc.langLabels[18];
                sentTypeItem.Text = dc.langLabels[19];
                shapeItem.Text = dc.langLabels[20];
                sizeItem.Text = dc.langLabels[21];
                themeItem.Text = dc.langLabels[22];
                yearItem.Text = dc.langLabels[23];
                changeLanguage.Text = dc.langLabels[24];
                aboutItem.Text = dc.langLabels[25];
                exitItem.Text = dc.langLabels[26];
                btn_search.Text = dc.langLabels[27];
                btnReset.Text = dc.langLabels[28];
                btnAdd.Text = dc.langLabels[29];
                btnUpdate.Text = dc.langLabels[30];
                btnDelete.Text = dc.langLabels[31];
                btnExport.Text = dc.langLabels[32];
                btnBlog.Text = dc.langLabels[33];
                lblRowNumber.Text = dc.langLabels[38];
                lblPostcardNumber.Text = dc.langLabels[39];
                btnDelete.Enabled = false;
                _addUpdateView = 1; // view

                if(adminRights)
                    btnExport.Visible = false;

                btnBlog.Visible = false;
                languagesItem.Text = dc.langLabels[109];
                labelsItem.Text = dc.langLabels[110];
            }
            catch
            {
            }
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            exitForm();
        }

        private void exitForm()
        {
            Application.Exit();
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            _aboutForm();
        }

        private void seriesItem_Click(object sender, EventArgs e)
        {
            // Series
            _showPanel();
            cardIndicator = false;
            _menuOption = 2;
            sortOption = "seriescardnumber, seriesseccardnumber ASC";
            _showCards();
            _getTotals();
        }

        private void _aboutForm()
        {
            Form form = new About(softCulture);
            form.ShowDialog();
        }

        private void _showPanel()
        {
            panel1.Visible = true;
            dataGridCard.Visible = true;
            dataGridCard.DataSource = null;
            panel2.Visible = true;
            panel3.Visible = true;
            txt_search.Visible = true;
            btn_search.Visible = true;
            txt_search.Text = "";
        }

        private void _showCards()
        {
            if(_menuOption==1)
                dc.REFRESH_CARD(sortOption);
            else if(_menuOption==2)
                dc.REFRESH_SERIES(sortOption);
            else
                dc.REFRESH_TABLES(_menuOption, sortOption);
            dataGridCard.DataSource = dc.DT;
        }

        private void _getTotals()
        {
            lbl_cardCounter.Text = dataGridCard.RowCount.ToString();
            switch (_menuOption)
            {
                case 1:
                case 2:
                    try
                    {
                        if (dataGridCard.RowCount == 1)
                            lblCards.Text = dc.langLabels[6];
                        else
                            lblCards.Text = dc.langLabels[7];
                    }
                    catch
                    {
                        if (dataGridCard.RowCount == 1)
                            lblCards.Text = "postcard";
                        else
                            lblCards.Text = "postcards";
                    }
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                    try
                    {
                        if (dataGridCard.RowCount == 1)
                            lblCards.Text = dc.langLabels[115];
                        else
                            lblCards.Text = dc.langLabels[116];
                    }
                    catch
                    {
                        if (dataGridCard.RowCount == 1)
                            lblCards.Text = "record";
                        else
                            lblCards.Text = "records";
                    }
                    break;
            }
        }

        private void _searchFunction()
        {
            dataGridCard.DataSource = null;
            switch (_menuOption)
            {
                case 1:
                    dc.SEARCH_CARD(txt_search.Text.ToString(), sortOption);
                    break;
                case 2:
                    dc.SEARCH_SERIES(txt_search.Text.ToString(), sortOption);
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                    dc.SEARCH_OTHERS(_menuOption, txt_search.Text, sortOption);
                    break;
            }
            dataGridCard.DataSource = dc.DT;
            _searchText = txt_search.Text;
            _getTotals();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            _searchFunction();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            _searchFunction();
        }

        private void _viewCard(object sender, DataGridViewCellEventArgs e)
        {
            _addUpdateView = 1;
            ViewCard();
        }

        private void ViewCard()
        {
            if (dataGridCard.RowCount > 0)
            {
                _nRecord = (Int32)dataGridCard.CurrentRow.Cells[0].Value;
                _nRow = dataGridCard.CurrentRow.Index;
                if (_menuOption == 1 && cardIndicator)
                {
                    Form newForm = new CardView(_nRecord, softCulture, _addUpdateView, imgPath);
                    newForm.ShowDialog();
                }
                else if (_menuOption == 2 && !cardIndicator)
                {
                    Form newForm = new SeriesView(_nRecord, softCulture, _addUpdateView, imgPath);
                    newForm.ShowDialog();
                }
                else
                {
                    Form newForm = new OtherView(_menuOption, _nRecord, softCulture, _addUpdateView);
                    newForm.ShowDialog();
                }
            }
            else
            {
                _nRecord = 0;
                _nRow = 0;
                Form newForm = new CardView(_nRecord, softCulture, _addUpdateView, imgPath);
                newForm.ShowDialog();
            }
            _readVar();
            try
            {
                if (addSeriesCard != null)
                {
                    if (addSeriesCard.Length > 0)
                    {
                        txt_search.Text = addSeriesCard;
                        dataGridCard.DataSource = null;
                        _menuOption = 2;
                        cardIndicator = false;
                        sortOption = "seriescardnumber, seriesseccardnumber ASC";
                        _showCards();
                        _searchFunction();
                    }
                }
                else
                {
                    dataGridCard.DataSource = null;
                    dataGridCard.BackgroundColor = Color.FromArgb(64, 64, 64);
                    _showCards();
                    dataGridCard.Rows[_nRow].Selected = true;
                    dataGridCard.FirstDisplayedScrollingRowIndex = _nRow;
                    dataGridCard.Focus();
                }
            }
            catch
            {
                dataGridCard.BackgroundColor = Color.FromArgb(64, 64, 64);
                _showCards();
                dataGridCard.Rows[_nRow].Selected = true;
                dataGridCard.FirstDisplayedScrollingRowIndex = _nRow;
                dataGridCard.Focus();
            }
            _getTotals();
        }

        private void changeLanguage_Click(object sender, EventArgs e)
        {
            Form form = new ChangeLanguage(softCulture, imgPath);
            form.ShowDialog();
        }

        private void cardsItem_Click(object sender, EventArgs e)
        {
            // sort order Publisher, Postcard Number
            _showPanel();
            _menuOption = 1;
            cardIndicator = true;
            sortOption = "cardsubpub,cardnumber ASC";
            _showCards();
            _getTotals();
        }

        // update row number and card number
        private void updatePostcardNumber()
        {
            Int32 currentRow = dataGridCard.CurrentRow.Index + 1;
            lblRowNumber.Text = dc.langLabels[38] + " " + currentRow.ToString() + " / " + (dataGridCard.RowCount).ToString();
            if (_menuOption < 3)
            {
                lblPostcardNumber.Visible = true;
                lblPostcardNumber.Text = dataGridCard.CurrentRow.Cells[1].Value.ToString();
            }
            else
                lblPostcardNumber.Visible = false;

        }

        private void updateCellLocation(object sender, DataGridViewCellEventArgs e)
        {
            updatePostcardNumber();
        }

        private void updateCellLocation(object sender, KeyEventArgs e)
        {
            updatePostcardNumber();
        }

        private void keyPressed(object sender, KeyPressEventArgs e)
        {
            _addUpdateView = 1;
            ViewCard();
        }

        private void updateCellLocation(object sender, DataGridViewCellMouseEventArgs e)
        {
            updatePostcardNumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _addUpdateView = 2; // 1 = view, 2 = add, 3 = update
            ViewCard();

        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            _deleteState();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string msg = dc.langLabels[118] + " " + dc.langLabels[122] + "\n";
            bool success = false;
            switch (_menuOption)
            {
                case 1:
                    msg += dc.langLabels[8];
                    tblName = dc.langLabels[8];
                    break;
                case 2:
                    msg += dc.langLabels[9];
                    tblName = dc.langLabels[9];
                    break;
                case 3:
                    msg += dc.langLabels[11];
                    tblName = dc.langLabels[11];
                    break;
                case 4:
                    msg += dc.langLabels[12];
                    tblName = dc.langLabels[12];
                    break;
                case 5:
                    msg += dc.langLabels[13];
                    tblName = dc.langLabels[13];
                    break;
                case 6:
                    msg += dc.langLabels[15];
                    tblName = dc.langLabels[15];
                    break;
                case 7:
                    msg += dc.langLabels[16];
                    tblName = dc.langLabels[16];
                    break;
                case 8:
                    msg += dc.langLabels[17];
                    tblName = dc.langLabels[17];
                    break;
                case 9:
                    msg += dc.langLabels[18];
                    tblName = dc.langLabels[18];
                    break;
                case 10:
                    msg += dc.langLabels[19];
                    tblName = dc.langLabels[19];
                    break;
                case 11:
                    msg += dc.langLabels[20];
                    tblName = dc.langLabels[20];
                    break;
                case 12:
                    msg += dc.langLabels[21];
                    tblName = dc.langLabels[21];
                    break;
                case 13:
                    msg += dc.langLabels[22];
                    tblName = dc.langLabels[22];
                    break;
                case 14:
                    msg += dc.langLabels[23];
                    tblName = dc.langLabels[23];
                    break;
                case 15:
                    msg += dc.langLabels[109];
                    tblName = dc.langLabels[109];
                    break;
                case 16:
                    msg += dc.langLabels[110];
                    tblName = dc.langLabels[110];
                    break;
            }
            dataGridExport.DataSource = null;
            dc.showTables(_searchText, sortOption, _menuOption);
            dataGridExport.DataSource = dc.DT;
            msg += "\n\n";
            saveExcel();
            if (success)
                msg += dc.langLabels[119];
            else
                msg += dc.langLabels[120];

            msg += " ";
            MessageBox.Show(msg, dc.langLabels[32], MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            _showCards();
        }

        private void _deleteState()
        {
            if (chkDelete.Checked)
            {
                btnDelete.BackColor = Color.FromArgb(255, 64, 64);
                btnDelete.ForeColor = Color.FromArgb(224, 224, 224);
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.BackColor = Color.FromArgb(224, 224, 224);
                btnDelete.ForeColor = Color.FromArgb(224, 224, 224);
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _nRow = dataGridCard.CurrentRow.Index;
            if (dataGridCard.RowCount > 0)
            {
                string msg;
                try
                {
                    if (_menuOption == 1)
                    {
                        msg = dc.langLabels[34] + " \n\n" + dataGridCard.CurrentRow.Cells[1].Value.ToString() + "\n" + dataGridCard.CurrentRow.Cells[2].Value.ToString() + "\n" + dataGridCard.CurrentRow.Cells[5].Value.ToString() + "\n" + dc.langLabels[95] + "\n\n" + dc.langLabels[96];
                    }
                    else if (_menuOption == 2)
                    {
                        msg = dc.langLabels[34] + " \n\n" + dataGridCard.CurrentRow.Cells[1].Value.ToString() + "\n" + dataGridCard.CurrentRow.Cells[2].Value.ToString() + "\n" + dataGridCard.CurrentRow.Cells[3].Value.ToString() + "\n" + dc.langLabels[95] + "\n\n" + dc.langLabels[96];
                    }
                    else
                    {
                        msg = dc.langLabels[34] + " \n\n" + dataGridCard.CurrentRow.Cells[1].Value.ToString() + "\n" + dc.langLabels[95] + "\n\n" + dc.langLabels[96];
                    }
                }
                catch
                {
                    msg = dc.langLabels[34] + " \n\n" + dataGridCard.CurrentRow.Cells[1].Value.ToString() + "\n" + dc.langLabels[95] + "\n\n" + dc.langLabels[96];
                }

                DialogResult dialog = MessageBox.Show(msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        if (_menuOption == 1)
                        {
                            msg = dc.langLabels[34] + " \n\n" + dataGridCard.CurrentRow.Cells[1].Value.ToString() + "\n" + dataGridCard.CurrentRow.Cells[2].Value.ToString() + "\n" + dataGridCard.CurrentRow.Cells[5].Value.ToString() + "\n\n" + dc.langLabels[94];
                        }
                        else if (_menuOption == 2)
                        {
                            msg = dc.langLabels[34] + " \n\n" + dataGridCard.CurrentRow.Cells[1].Value.ToString() + "\n" + dataGridCard.CurrentRow.Cells[2].Value.ToString() + "\n" + dataGridCard.CurrentRow.Cells[3].Value.ToString() + "\n\n" + dc.langLabels[94];
                        }
                        else
                        {
                            msg = dc.langLabels[34] + " \n\n" + dataGridCard.CurrentRow.Cells[1].Value.ToString() + "\n" + dc.langLabels[95] + "\n\n" + dc.langLabels[94];
                        }
                    }
                    catch
                    {
                    }

                    dc.cardID = (Int32)dataGridCard.CurrentRow.Cells[0].Value;
                    switch (_menuOption)
                    {
                        case 1:     // Main Postcards
                            dc.DELETE_CARD();
                            break;
                        case 2:     // Series Postcards
                            dc.DELETE_SERIECARD();
                            break;
                        case 3:
                            dc.DELETE_OTHER_TABLES(_menuOption);
                            break;
                    }
                    dataGridCard.BackgroundColor = Color.FromArgb(64, 64, 64);
                    _showCards();
                    dataGridCard.Rows[_nRow].Selected = true;
                    dataGridCard.FirstDisplayedScrollingRowIndex = _nRow;
                    dataGridCard.Focus();
                    _getTotals();
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            chkDelete.Checked = false;
            _deleteState();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _addUpdateView = 3; // 1 = view, 2 = add, 3 = update
            ViewCard();

        }

        private void _chkKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                _searchFunction();
        }

        /************************************************
         * 
         * Other tables
         * 
         ************************************************/
        private void colorItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 3;
            sortOption = "";
            _showCards();
            _getTotals();
        }

        private void conditionItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 4;
            sortOption = "";
            _showCards();
            _getTotals();
        }

        private void countryItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 5;
            sortOption = "";
            _showCards();
            _getTotals();
        }

        private void imageTypeItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 6;
            sortOption = "";
            _showCards();
            _getTotals();
        }

        private void materialItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 7;
            sortOption = "";
            _showCards();
            _getTotals();
        }

        private void orientationItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 8;
            sortOption = "";
            _showCards();
            _getTotals();
        }

        private void publisherItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 9;
            sortOption = "publisher ASC";
            _showCards();
            _getTotals();
        }

        private void sentTypeItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 10;
            sortOption = "";
            _showCards();
            _getTotals();
        }

        private void shapeItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 11;
            sortOption = "";
            _showCards();
            _getTotals();
        }

        private void sizeItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 12;
            sortOption = "";
            _showCards();
            _getTotals();
        }

        private void themeItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 13;
            sortOption = "themename ASC";
            _showCards();
            _getTotals();
        }

        private void yearItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 14;
            sortOption = "yearnumber ASC";
            _showCards();
            _getTotals();
        }

        private void languagesItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 15;
            sortOption = "";
            _showCards();
            _getTotals();
        }

        private void labelsItem_Click(object sender, EventArgs e)
        {
            _showPanel();
            cardIndicator = false;
            _menuOption = 16;
            sortOption = "";
            _showCards();
            _getTotals();
        }



        /*
         * 
         *      SAVE TO EXCEL FILE (no need to have Excel installed in your computer
         * 
         */
        private void saveExcel()
        {
            // export to excel
            sFDialog.InitialDirectory = "C:";
            sFDialog.Title = "Save as Excel File";
            sFDialog.FileName = "";
            sFDialog.Filter = "Excel Files 2007 and up|*.xlsx";

            // choose the folder where to write the file. If 'OK' is pressed, it saves the complete path to that folder.
            if (sFDialog.ShowDialog() != DialogResult.Cancel)
            {
                // change cursor to wait mode while saving the file
                Cursor.Current = Cursors.WaitCursor;

                // EPPlus license (Excel isn't required to be installed in the computer. You may use other open source software to open it)
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                try
                {
                    using (var package = new ExcelPackage(new System.IO.FileInfo(sFDialog.FileName)))
                    {
                        // define spreadsheet's sheet name

                        var worksheet = package.Workbook.Worksheets.Add(tblName);

                        // save the header
                        for (int i = 1; i < dataGridExport.Columns.Count + 1; i++)
                        {
                            worksheet.Cells[1, i].Value = dataGridExport.Columns[i - 1].HeaderText;
                        }

                        // save all information in the gridview to the spreadsheet
                        for (int i = 0; i < dataGridExport.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridExport.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataGridExport.Rows[i].Cells[j].Value.ToString();
                            }
                        }

                        // adjust column's width
                        worksheet.Cells.AutoFitColumns(0);

                        // save file to the disk
                        package.Save();
                    }
                    success = true;
                }
                catch
                {
                    success = false;

                }
            }
            // cursor is back to default
            Cursor.Current = Cursors.Default;
        }

        private void _fileLanguage()
        {
            string line, filePath = @"PEditor.ini";
            string dirPath = @"";
            try
            {

                if (File.Exists(dirPath + filePath))
                {
                    using (StreamReader read = new StreamReader(dirPath + filePath))
                    {
                        while (true)
                        {
                            line = read.ReadLine();
                            if (line == null)
                                break;
                            if (line == "[Language]")
                            {
                                line = read.ReadLine();
                                softCulture = line;
                            }
                            if (line == "[ImagePath]")
                            {
                                line = read.ReadLine();
                                imgPath = line;
                            }
                        }
                    }
                }
                if (softCulture == null)
                {
                    softCulture = "en-US";
                }
            }
            catch
            {

            }
        }

        private void _readVar()
        {
            string line, filePath = @"PEditor.tmp";
            string dirPath = @"";
            try
            {

                if (File.Exists(dirPath + filePath))
                {
                    using (StreamReader read = new StreamReader(dirPath + filePath))
                    {
                        while (true)
                        {
                            line = read.ReadLine();
                            if (line != null)
                                addSeriesCard = line;
                            else
                                break;
                        }
                    }
                }

                if (File.Exists(dirPath + filePath))
                {
                    File.Delete(dirPath + filePath);
                }

            }
            catch
            {

            }

        }
    }
}
