using PEditor.myclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEditor
{
    public partial class OtherView : Form
    {
        connection_class con = new connection_class();
        dataclass dc = new dataclass();

        public Int32 nRecord, addUpdateView, mOption;
        public bool verify = false;
        public string softCulture, oldLog, newLog;

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public OtherView(Int32 _mOption, Int32 _nRecord, string _softCulture, Int32 _addUpdateView)
        {
            InitializeComponent();
            nRecord = _nRecord;
            addUpdateView = _addUpdateView; // option selected
            softCulture = _softCulture;     // language selected
            mOption = _mOption;             // menu option (table)
            try
            {
                dc.TEMP_LABELS(1, _softCulture);
                if (_addUpdateView < 2)
                {
                    btnSave.Visible = false;
                    lblAddUpdate.Visible = false;
                }
                else
                {
                    btnSave.Visible = true;
                    lblAddUpdate.Visible = true;
                }
                /*
                 * 
                 *      Save this label to the database and change it here  |
                 *                                                          v
                 * 
                 */
                lblTableName.Text = dc.langLabels[117] + " ";
                switch (mOption)
                {
                    case 3:     // colors
                        lblTableName.Text += dc.langLabels[11];
                        lblField1.Text = dc.langLabels[107];    // abr
                        lblField2.Text = dc.langLabels[11];     // type of color
                        lblField3.Text = dc.langLabels[108];    // description
                        txtField1.MaxLength = 5;
                        txtField2.MaxLength = 50;
                        txtField3.MaxLength = 1000;
                        _showFields(3);
                        break;
                    case 4:     // conditions
                        lblTableName.Text += dc.langLabels[12];
                        lblField1.Text = dc.langLabels[107];    // abr
                        lblField2.Text = dc.langLabels[12];     // condition
                        lblField3.Text = dc.langLabels[108];    // description
                        txtField1.MaxLength = 5;
                        txtField2.MaxLength = 50;
                        txtField3.MaxLength = 1000;
                        _showFields(3);
                        break;
                    case 5:     // countries
                        lblTableName.Text += dc.langLabels[13];
                        lblField1.Text = dc.langLabels[13];     // country
                        lblField2.Text = dc.langLabels[111];    // iso-2
                        lblField3.Text = dc.langLabels[112];    // culture
                        lblField4.Text = dc.langLabels[109];    // language
                        lblField5.Text = dc.langLabels[108];    // description
                        txtField1.MaxLength = 150;
                        txtField2.MaxLength = 2;
                        txtField3.MaxLength = 10;
                        txtField4.MaxLength = 50;
                        txtField5.MaxLength = 1000;
                        _showFields(5);
                        break;
                    case 6:     // image types
                        lblTableName.Text += dc.langLabels[15];
                        lblField1.Text = dc.langLabels[107];    // abr
                        lblField2.Text = dc.langLabels[15];     // image type
                        lblField3.Text = dc.langLabels[108];    // description
                        txtField1.MaxLength = 5;
                        txtField2.MaxLength = 50;
                        txtField3.MaxLength = 1000;
                        _showFields(3);
                        break;
                    case 7:     // materials
                        lblTableName.Text += dc.langLabels[16];
                        lblField1.Text = dc.langLabels[16];     // materials
                        lblField2.Text = dc.langLabels[108];    // description
                        txtField1.MaxLength = 50;
                        txtField2.MaxLength = 1000;
                        _showFields(2);
                        break;
                    case 8:     // orientation
                        lblTableName.Text += dc.langLabels[17];
                        lblField1.Text = dc.langLabels[107];    // abr
                        lblField2.Text = dc.langLabels[17];     // orientation
                        lblField3.Text = dc.langLabels[108];    // description
                        txtField1.MaxLength = 5;
                        txtField2.MaxLength = 50;
                        txtField3.MaxLength = 1000;
                        _showFields(3);
                        break;
                    case 9:     // publishers
                        lblTableName.Text += dc.langLabels[18];
                        lblField1.Text = dc.langLabels[42];     // publisher
                        lblField2.Text = dc.langLabels[41];     // all companies
                        lblField3.Text = dc.langLabels[107];    // abr (future use)
                        lblField4.Text = dc.langLabels[108];    // description
                        txtField1.MaxLength = 150;
                        txtField2.MaxLength = 500;
                        txtField3.MaxLength = 5;
                        txtField4.MaxLength = 1000;
                        _showFields(4);
                        break;
                    case 10:    // sent types
                        lblTableName.Text += dc.langLabels[19];
                        lblField1.Text = dc.langLabels[19];     // sent type
                        lblField2.Text = dc.langLabels[108];    // description
                        txtField1.MaxLength = 50;
                        txtField2.MaxLength = 1000;
                        _showFields(2);
                        break;
                    case 11:    // shapes
                        lblTableName.Text += dc.langLabels[20];
                        lblField1.Text = dc.langLabels[20];     // shape
                        lblField2.Text = dc.langLabels[108];    // description
                        txtField1.MaxLength = 50;
                        txtField2.MaxLength = 1000;
                        _showFields(2);
                        break;
                    case 12:    // sizes
                        lblTableName.Text += dc.langLabels[21];
                        lblField1.Text = dc.langLabels[21];     // size
                        lblField2.Text = dc.langLabels[108];    // description
                        txtField1.MaxLength = 50;
                        txtField2.MaxLength = 1000;
                        _showFields(2);
                        break;
                    case 13:    // themes
                        lblTableName.Text += dc.langLabels[22];
                        lblField1.Text = dc.langLabels[22];     // theme
                        lblField2.Text = dc.langLabels[108];    // description
                        txtField2.MaxLength = 150;
                        txtField3.MaxLength = 1000;
                        _showFields(2);
                        break;
                    case 14:    // years
                        lblTableName.Text += dc.langLabels[23];
                        lblField1.Text = dc.langLabels[23];     // year
                        txtField1.MaxLength = 4;
                        _showFields(1);
                        break;
                    case 15:    // languages
                        lblTableName.Text += dc.langLabels[109];
                        lblField1.Text = dc.langLabels[109];    // country
                        lblField2.Text = dc.langLabels[112];    // culture
                        txtField1.MaxLength = 5;
                        txtField2.MaxLength = 50;
                        _showFields(2);
                        break;
                    case 16:    // labels
                        lblTableName.Text += dc.langLabels[110];
                        lblField1.Text = dc.langLabels[113];    // software type
                        lblField2.Text = dc.langLabels[112];    // culture
                        lblField3.Text = dc.langLabels[108];    // label
                        lblField4.Text = dc.langLabels[114];    // app number
                        lblField5.Text = dc.langLabels[73];     // long description
                        txtField1.MaxLength = 1;
                        txtField2.MaxLength = 5;
                        txtField3.MaxLength = 500;
                        txtField4.MaxLength = 4;
                        txtField5.MaxLength = 1000;
                        _showFields(5);
                        break;
                    //case 17:    // differences
                    //    lblTableName = dc.langLabels[11];
                    //    break;
                }
                btnClosePanel.Text = dc.langLabels[5];
                btnSave.Text = dc.langLabels[76];
                // check if it is a new postcard of an update
                _stateChanged();
            }
            catch
            {

            }
        }

        private void OtherView_Load(object sender, EventArgs e)
        {
            ViewOther();
        }

        private void ViewOther()
        {
            if (nRecord > 0)
            {
                dc.TEMP_OTHER(mOption, nRecord);
                switch (mOption)
                {
                    case 3:
                    case 4:
                    case 6:
                    case 8:
                    case 9:
                        txtField1.Text = dc.fieldData1[0];
                        txtField2.Text = dc.fieldData2[0];
                        txtField3.Text = dc.fieldData3[0];
                        break;
                    case 5:
                    case 16:
                        txtField1.Text = dc.fieldData1[0];
                        txtField2.Text = dc.fieldData2[0];
                        txtField3.Text = dc.fieldData3[0];
                        txtField4.Text = dc.fieldData4[0];
                        txtField5.Text = dc.fieldData5[0];
                        break;
                    case 7:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 15:
                        txtField1.Text = dc.fieldData1[0];
                        txtField2.Text = dc.fieldData2[0];
                        break;
                    case 14:
                        txtField1.Text = dc.fieldData1[0];
                        break;
                    //case 17:
                    //    txtField1.Text = dc.fieldData1[0];
                    //    txtField2.Text = dc.fieldData2[0];
                    //    txtField3.Text = dc.fieldData3[0];
                    //    txtField4.Text = dc.fieldData4[0];
                    //    txtField5.Text = dc.fieldData5[0];
                    //    break;
                }
            }
            else
            {

            }
            lblRecNum.Text = "# " + nRecord.ToString();
        }

        /* 
        // Save the data
        */
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtField1.Text.Length > 0 || txtField1.Text.Trim() != "")
            {
                switch (mOption)
                {
                    case 3:
                    case 4:
                    case 6:
                    case 8:
                    case 9:
                        // get the old data
                        oldLog = dc.fieldData1[0] + "|" + dc.fieldData2[0] + "|" + dc.fieldData3[0];
                        // get the new/changed data
                        newLog = txtField1.Text + "|" + txtField2.Text + "|" + txtField3.Text;

                        dc.fieldData1[0] = txtField1.Text;
                        dc.fieldData2[0] = txtField2.Text;
                        dc.fieldData3[0] = txtField3.Text;
                        break;
                    case 5:
                        // get the old data
                        oldLog = dc.fieldData1[0] + "|" + dc.fieldData2[0] + "|" + dc.fieldData3[0] + "|" + dc.fieldData4[0] + "|" + dc.fieldData5[0];
                        // get the new/changed data
                        newLog = txtField1.Text + "|" + txtField2.Text + "|" + txtField3.Text + "|" + txtField4.Text + "|" + txtField5.Text;

                        dc.fieldData1[0] = txtField1.Text;
                        dc.fieldData2[0] = txtField2.Text;
                        dc.fieldData3[0] = txtField3.Text;
                        dc.fieldData4[0] = txtField4.Text;
                        dc.fieldData5[0] = txtField5.Text;
                        break;
                    case 16:
                        // get the old data
                        oldLog = dc.fieldData1[0] + "|" + dc.fieldData2[0] + "|" + dc.fieldData3[0] + "|" + dc.fieldData4[0] + "|" + dc.fieldData5[0];
                        // get the new/changed data
                        newLog = txtField1.Text + "|" + txtField2.Text + "|" + txtField3.Text + "|" + txtField4.Text + "|" + txtField5.Text;

                        dc.fieldData6 = int.Parse(txtField1.Text);
                        dc.fieldData2[0] = txtField2.Text;
                        dc.fieldData3[0] = txtField3.Text;
                        dc.fieldData7 = int.Parse(txtField4.Text);
                        dc.fieldData5[0] = txtField5.Text;
                        break;
                    case 7:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 15:
                        // get the old data
                        oldLog = dc.fieldData1[0] + "|" + dc.fieldData2[0];
                        // get the new/changed data
                        newLog = txtField1.Text + "|" + txtField2.Text;

                        dc.fieldData1[0] = txtField1.Text;
                        dc.fieldData2[0] = txtField2.Text;
                        break;
                    case 14:
                        // get the old data
                        oldLog = dc.fieldData1[0];
                        // get the new/changed data
                        newLog = txtField1.Text;

                        dc.fieldData1[0] = txtField1.Text;
                        newLog = txtField1.Text;
                        break;
                    //case 17:
                    //    dc.fieldData1[0] = txtField1.Text;
                    //    dc.fieldData2[0] = txtField2.Text;
                    //    dc.fieldData3[0] = txtField3.Text;
                    //    dc.fieldData4[0] = txtField4.Text;
                    //    dc.fieldData5[0] = txtField5.Text;
                    //    break;
                }
            }
            if (addUpdateView == 1 || addUpdateView == 3)
                dc.othersID = nRecord;
            string msg = dc.langLabels[118] + " ";
            if (addUpdateView == 2)
            {
                msg += dc.langLabels[92];
                dc.ADD_OTHERS(mOption);
                dc.ADD_LOG(dc.langLabels[93], lblTableName.Text, dc.fieldData1[0], oldLog, newLog, 1);
            }
            else if (addUpdateView == 3)
            {
                msg += dc.langLabels[93];
                dc.UPDATE_OTHERS(mOption);
                dc.ADD_LOG(dc.langLabels[93], lblTableName.Text, dc.fieldData1[0], oldLog, newLog, 1);
            }
            MessageBox.Show(msg);

            // information about restarting the app (to read the updated data)
            if (addUpdateView==2 || addUpdateView == 3)
            {
                MessageBox.Show(dc.langLabels[123]);
                Application.Restart();
            }
            this.Close();
        }

        private void _showFields(int _nFields)
        {
            int fieldSize = 14;
            int maxSize = 492;
            switch (_nFields)
            {
                case 1:
                    lblField1.Visible = true;
                    lblField2.Visible = false;
                    lblField3.Visible = false;
                    lblField4.Visible = false;
                    lblField5.Visible = false;
                    txtField1.Visible = true;
                    txtField2.Visible = false;
                    txtField3.Visible = false;
                    txtField4.Visible = false;
                    txtField5.Visible = false;
                    if (txtField1.MaxLength * fieldSize > maxSize)
                        txtField1.Width = maxSize;
                    else
                        txtField1.Width = (fieldSize * txtField1.MaxLength);
                    break;
                case 2:
                    lblField1.Visible = true;
                    lblField2.Visible = true;
                    lblField3.Visible = false;
                    lblField4.Visible = false;
                    lblField5.Visible = false;
                    txtField1.Visible = true;
                    txtField2.Visible = true;
                    txtField3.Visible = false;
                    txtField4.Visible = false;
                    txtField5.Visible = false;
                    if (txtField1.MaxLength * fieldSize > maxSize)
                        txtField1.Width = maxSize;
                    else
                        txtField1.Width = (fieldSize * txtField1.MaxLength);
                    if (txtField2.MaxLength * fieldSize > maxSize)
                        txtField2.Width = maxSize;
                    else
                        txtField2.Width = (fieldSize * txtField2.MaxLength);
                    break;
                case 3:
                    lblField1.Visible = true;
                    lblField2.Visible = true;
                    lblField3.Visible = true;
                    lblField4.Visible = false;
                    lblField5.Visible = false;
                    txtField1.Visible = true;
                    txtField2.Visible = true;
                    txtField3.Visible = true;
                    txtField4.Visible = false;
                    txtField5.Visible = false;
                    if (txtField1.MaxLength * fieldSize > maxSize)
                        txtField1.Width = maxSize;
                    else
                        txtField1.Width = (fieldSize * txtField1.MaxLength);
                    if (txtField2.MaxLength * fieldSize > maxSize)
                        txtField2.Width = maxSize;
                    else
                        txtField2.Width = (fieldSize * txtField2.MaxLength);
                    if (txtField3.MaxLength * fieldSize > maxSize)
                        txtField3.Width = maxSize;
                    else
                        txtField3.Width = (fieldSize * txtField3.MaxLength);
                    break;
                case 4:
                    lblField1.Visible = true;
                    lblField2.Visible = true;
                    lblField3.Visible = true;
                    lblField4.Visible = true;
                    lblField5.Visible = false;
                    txtField1.Visible = true;
                    txtField2.Visible = true;
                    txtField3.Visible = true;
                    txtField4.Visible = true;
                    txtField5.Visible = false;
                    if (txtField1.MaxLength * fieldSize > maxSize)
                        txtField1.Width = maxSize;
                    else
                        txtField1.Width = (fieldSize * txtField1.MaxLength);
                    if (txtField2.MaxLength * fieldSize > maxSize)
                        txtField2.Width = maxSize;
                    else
                        txtField2.Width = (fieldSize * txtField2.MaxLength);
                    if (txtField3.MaxLength * fieldSize > maxSize)
                        txtField3.Width = maxSize;
                    else
                        txtField3.Width = (fieldSize * txtField3.MaxLength);
                    if (txtField4.MaxLength * fieldSize > maxSize)
                        txtField4.Width = maxSize;
                    else
                        txtField4.Width = (fieldSize * txtField4.MaxLength);
                    break;
                case 5:
                    lblField1.Visible = true;
                    lblField2.Visible = true;
                    lblField3.Visible = true;
                    lblField4.Visible = true;
                    lblField5.Visible = true;
                    txtField1.Visible = true;
                    txtField2.Visible = true;
                    txtField3.Visible = true;
                    txtField4.Visible = true;
                    txtField5.Visible = true;
                    if (txtField1.MaxLength * fieldSize > maxSize)
                        txtField1.Width = maxSize;
                    else
                        txtField1.Width = (fieldSize * txtField1.MaxLength);
                    if (txtField2.MaxLength * fieldSize > maxSize)
                        txtField2.Width = maxSize;
                    else
                        txtField2.Width = (fieldSize * txtField2.MaxLength);
                    if (txtField3.MaxLength * fieldSize > maxSize)
                        txtField3.Width = maxSize;
                    else
                        txtField3.Width = (fieldSize * txtField3.MaxLength);
                    if (txtField4.MaxLength * fieldSize > maxSize)
                        txtField4.Width = maxSize;
                    else
                        txtField4.Width = (fieldSize * txtField4.MaxLength);
                    if (txtField5.MaxLength * fieldSize > maxSize)
                        txtField5.Width = maxSize;
                    else
                        txtField5.Width = (fieldSize * txtField5.MaxLength);
                    break;
            }
        }

        private void _stateChanged()
        {
            switch (addUpdateView)
            {
                case 1:
                    lblAddUpdate.Visible = false;
                    btnSave.Visible = false;
                    break;
                case 2:
                    lblAddUpdate.Visible = true;
                    btnSave.Visible = true;
                    lblAddUpdate.Text = dc.langLabels[77];
                    btnSave.BackColor = Color.FromArgb(128, 255, 128);
                    break;
                case 3:
                    lblAddUpdate.Visible = true;
                    btnSave.Visible = true;
                    lblAddUpdate.Text = dc.langLabels[78];
                    btnSave.BackColor = Color.FromArgb(255, 255, 128);
                    break;
            }
        }
    }
}
