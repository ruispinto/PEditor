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

namespace PEditor
{
    public partial class CardView : Form
    {
        connection_class con = new connection_class();
        dataclass dc = new dataclass();

        public Int32 nRecord, addUpdateView;
        public bool verify = false;
        public string cardNumber, softCulture, _dtPurchase, addSeriesCard, oldLog, newLog, oldCardNumber, imgPath;

        public CardView(Int32 _nRecord, string _softCulture, Int32 _addUpdateView, string _imgPath)
        {
            InitializeComponent();
            nRecord = _nRecord;
            addUpdateView = _addUpdateView;
            softCulture = _softCulture;
            imgPath = _imgPath;

            try
            {
                dc.TEMP_LABELS(1, _softCulture);
                btnClosePanel.Text = dc.langLabels[5];
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
                lblCardNumber.Text = dc.langLabels[34];
                lblPub.Text = dc.langLabels[41];
                lblSubPub.Text = dc.langLabels[42];
                lblScanned.Text = dc.langLabels[43];
                lblInTheBlog.Text = dc.langLabels[44];
                lblBlogURL.Text = dc.langLabels[45];
                lblLocality.Text = dc.langLabels[46];
                lblRegion.Text = dc.langLabels[47];
                lblRegCountry.Text = dc.langLabels[48];
                lblPubCountry.Text = dc.langLabels[49];
                lblDescEng.Text = dc.langLabels[37];
                lblDescOrig.Text = dc.langLabels[40];
                lblTheme.Text = dc.langLabels[36];
                lblColor.Text = dc.langLabels[11];
                lblYear.Text = dc.langLabels[23];
                lblImgType.Text = dc.langLabels[15];
                lblTotImg.Text = dc.langLabels[50];
                lblIsSeries.Text = dc.langLabels[51];
                lblTotPostcards.Text = dc.langLabels[52];
                lblSize.Text = dc.langLabels[21];
                lblShape.Text = dc.langLabels[20];
                lblOrient.Text = dc.langLabels[17];
                lblBarcode.Text = dc.langLabels[53];
                lblMaterial.Text = dc.langLabels[16];
                lblCondition.Text = dc.langLabels[12];
                lblBorders.Text = dc.langLabels[54];
                lblHasTxtFront.Text = dc.langLabels[55];
                lblHasTxtBack.Text = dc.langLabels[56];
                lblFrtColor.Text = dc.langLabels[57];
                lblBckColor.Text = dc.langLabels[58];
                lblPurchaseDate.Text = dc.langLabels[59];
                lblCostPrice.Text = dc.langLabels[60];
                lblWebpage.Text = dc.langLabels[61];
                lblIsIdentical.Text = dc.langLabels[62];
                lblBigDesc.Text = dc.langLabels[73];
                lblFrtImg.Text = dc.langLabels[74];
                lblBckImg.Text = dc.langLabels[75];
                btnSave.Text = dc.langLabels[76];
                lblPartialSeries.Text = dc.langLabels[105];
                lblPartialSeries.Visible = false;

                // hide all if not identical
                lblEquals1.Text = dc.langLabels[63];
                lblEquals1.Visible = false;
                comboEquals1.Visible = false;
                lblEquals2.Text = dc.langLabels[64];
                lblEquals2.Visible = false;
                comboEquals2.Visible = false;
                lblEquals3.Text = dc.langLabels[65];
                lblEquals3.Visible = false;
                comboEquals3.Visible = false;
                lblEquals4.Text = dc.langLabels[66];
                lblEquals4.Visible = false;
                comboEquals4.Visible = false;
                lblEquals5.Text = dc.langLabels[67];
                lblEquals5.Visible = false;
                comboEquals5.Visible = false;
                lblDiff1.Text = dc.langLabels[68];
                lblDiff1.Visible = false;
                txtDiff1.Visible = false;
                lblDiff2.Text = dc.langLabels[69];
                lblDiff2.Visible = false;
                txtDiff2.Visible = false;
                lblDiff3.Text = dc.langLabels[70];
                lblDiff3.Visible = false;
                txtDiff3.Visible = false;
                lblDiff4.Text = dc.langLabels[71];
                lblDiff4.Visible = false;
                txtDiff4.Visible = false;
                lblDiff5.Text = dc.langLabels[72];
                lblDiff5.Visible = false;
                txtDiff5.Visible = false;

                // check if it is a new postcard of an update
                _stateChanged();
                _chkIsSeriesStatus();
            }
            catch
            {

            }
        }

        private void ViewCard()
        {
            if (nRecord > 0)
            {
                dc.TEMP_CARD(nRecord);
                // scanned ?
                if (dc.cardScanned[0].ToUpper() == "Y")
                    chkIsScanned.Checked = true;
                else
                    chkIsScanned.Checked = false;
                // in the blog ?
                if (dc.cardInBlog[0].ToUpper() == "Y")
                    chkInTheBlog.Checked = true;
                else
                    chkInTheBlog.Checked = false;
                // is a serie ?
                if (dc.cardIsSeries[0].ToUpper() == "Y")
                    chkIsSeries.Checked = true;
                else
                    chkIsSeries.Checked = false;
                // has borders ?
                if (dc.cardBorders[0].ToUpper() == "Y")
                    chkBorders.Checked = true;
                else
                    chkBorders.Checked = false;
                // is identical ?
                if (dc.cardIdentical[0].ToUpper() == "Y")
                    chkIsIdentical.Checked = true;
                else
                    chkIsIdentical.Checked = false;
                // has text in the back ?
                if (dc.cardBackTxt[0].ToUpper() == "Y")
                    chkBackTxt.Checked = true;
                else
                    chkBackTxt.Checked = false;
                // has text in the front ?
                if (dc.cardFrontTxt[0].ToUpper() == "Y")
                    chkFrontTxt.Checked = true;
                else
                    chkFrontTxt.Checked = false;

                txtCardNumber.Text = dc.cardNumber[0];
                oldCardNumber = dc.cardNumber[0];
                txtSubPublisher.Text = dc.cardSubPub[0];
                txtBlogURL.Text = dc.cardBlogURL[0];
                txtLocality.Text = dc.cardLocality[0];
                txtRegion.Text = dc.cardRegion[0];
                txtDescEng.Text = dc.cardDescEng[0];
                txtDescOrig.Text = dc.cardDescOrg[0];
                txtTotImg.Text = dc.cardImgNumber[0];
                _chkIsSeriesStatus();
                txtBarcode.Text = dc.cardBarcode[0];
                txtFrtColor.Text = dc.cardFrontColor[0];
                txtBckColor.Text = dc.cardBackColor[0];
                txtBigDesc.Text = dc.cardBigDesc[0];
                try
                {
                    if (dc.cardDatePurchase[0].Trim().Length != 0)
                    {
                        datePurchase.Value = DateTime.Parse(dc.cardDatePurchase[0]);
                    }
                    else
                        datePurchase.Value = DateTime.Today;
                }
                catch
                {
                    datePurchase.Value = DateTime.Today;
                }
                txtPrice.Text = dc.cardCostPrice[0];
                txtWebpage.Text = dc.cardWebpage[0];
                txtTypeDesc.Text = dc.cardTypeDesc[0];
                txtFrtImgPath.Text = dc.cardFrontImgPath[0];
                txtBckImgPath.Text = dc.cardBackImgPath[0];
                if (addUpdateView == 1)     // view
                {
                    comboPublisher.Text = dc.cardPublisher[0];
                    comboRegCountry.Text = dc.cardRegCountry[0];
                    comboPubCountry.Text = dc.cardPubCountry[0];
                    comboTheme.Text = dc.cardTheme[0];
                    comboColor.Text = dc.cardColor[0];
                    comboYear.Text = dc.cardYear[0];
                    comboImgType.Text = dc.cardImgType[0];
                    comboSize.Text = dc.cardSize[0];
                    comboShape.Text = dc.cardShape[0];
                    comboOrient.Text = dc.cardOrient[0];
                    comboMaterial.Text = dc.cardMaterial[0];
                    comboCondition.Text = dc.cardCond[0];
                    comboSentType.Text = dc.cardSentType[0];
                    if (dc.cardIdentical[0].ToUpper() == "Y")
                    {
                        lblEquals1.Visible = true;
                        comboEquals1.Visible = true;
                        lblDiff1.Visible = true;
                        txtDiff1.Visible = true;
                        comboEquals1.Text = dc.cardEquals1[0];
                        txtDiff1.Text = dc.cardDifferences1[0];

                        if (comboEquals1.Text.Length > 0)
                        {
                            lblEquals2.Visible = true;
                            comboEquals2.Visible = true;
                            lblDiff2.Visible = true;
                            txtDiff2.Visible = true;
                            comboEquals2.Text = dc.cardEquals2[0];
                            txtDiff2.Text = dc.cardDifferences2[0];

                            if (comboEquals2.Text.Length > 0)
                            {
                                lblEquals3.Visible = true;
                                comboEquals3.Visible = true;
                                lblDiff3.Visible = true;
                                txtDiff3.Visible = true;
                                comboEquals3.Text = dc.cardEquals3[0];
                                txtDiff3.Text = dc.cardDifferences3[0];

                                if (comboEquals3.Text.Length > 0)
                                {
                                    lblEquals4.Visible = true;
                                    comboEquals4.Visible = true;
                                    lblDiff4.Visible = true;
                                    txtDiff4.Visible = true;
                                    comboEquals4.Text = dc.cardEquals4[0];
                                    txtDiff4.Text = dc.cardDifferences4[0];

                                    if (comboEquals4.Text.Length > 0)
                                    {
                                        lblEquals5.Visible = true;
                                        comboEquals5.Visible = true;
                                        lblDiff5.Visible = true;
                                        txtDiff5.Visible = true;
                                        comboEquals5.Text = dc.cardEquals5[0];
                                        txtDiff5.Text = dc.cardDifferences5[0];
                                    }
                                }
                            }
                        }
                    }

                }
                else
                {
                    // publishers
                    dc.fillPub();
                    comboPublisher.DataSource = dc.dataPub;
                    if (comboPublisher.FindString(dc.cardPublisher[0]) >= 0)
                        comboPublisher.SelectedIndex = comboPublisher.FindString(dc.cardPublisher[0]);
                    else
                        comboPubCountry.SelectedIndex = 0;

                    // countries (region)
                    dc.fillCountry();
                    comboRegCountry.DataSource = dc.dataCountry;
                    if (comboRegCountry.FindString(dc.cardRegCountry[0]) >= 0)
                        comboRegCountry.SelectedIndex = comboRegCountry.FindString(dc.cardRegCountry[0]);
                    else
                        comboPubCountry.SelectedIndex = 0;

                    // countries (publisher)
                    comboPubCountry.DataSource = dc.dataCountry;
                    if (comboPubCountry.FindString(dc.cardPubCountry[0]) >= 0)
                        comboPubCountry.SelectedIndex = comboPubCountry.FindString(dc.cardPubCountry[0]);
                    else
                        comboPubCountry.SelectedIndex = 0;

                    // themes
                    dc.fillTheme();
                    comboTheme.DataSource = dc.dataTheme;
                    if (comboTheme.FindString(dc.cardTheme[0]) >= 0)
                        comboTheme.SelectedIndex = comboTheme.FindString(dc.cardTheme[0]);
                    else
                        comboTheme.SelectedIndex = 0;

                    // color (black and white/sepia/color/one color only)
                    dc.fillColor();
                    comboColor.DataSource = dc.dataColor;
                    if (comboColor.FindString(dc.cardColor[0]) >= 0)
                        comboColor.SelectedIndex = comboColor.FindString(dc.cardColor[0]);
                    else
                        comboColor.SelectedIndex = 0;

                    // year
                    dc.fillYear();
                    comboYear.DataSource = dc.dataYear;
                    if (comboYear.FindString(dc.cardYear[0]) >= 0)
                        comboYear.SelectedIndex = comboYear.FindString(dc.cardYear[0]);
                    else
                        comboYear.SelectedIndex = 0;

                    // image type
                    dc.fillImgType();
                    comboImgType.DataSource = dc.dataImgType;
                    if (comboImgType.FindString(dc.cardImgType[0]) >= 0)
                        comboImgType.SelectedIndex = comboImgType.FindString(dc.cardImgType[0]);
                    else
                        comboColor.SelectedIndex = 0;

                    // size
                    dc.fillSize();
                    comboSize.DataSource = dc.dataSize;
                    if (comboSize.FindString(dc.cardSize[0]) >= 0)
                        comboSize.SelectedIndex = comboSize.FindString(dc.cardSize[0]);
                    else
                        comboSize.SelectedIndex = 0;

                    // shape
                    dc.fillShape();
                    comboShape.DataSource = dc.dataShape;
                    if (comboShape.FindString(dc.cardShape[0]) >= 0)
                        comboShape.SelectedIndex = comboShape.FindString(dc.cardShape[0]);
                    else
                        comboShape.SelectedIndex = 0;

                    // orientation
                    dc.fillOrient();
                    comboOrient.DataSource = dc.dataOrient;
                    if (comboOrient.FindString(dc.cardOrient[0]) >= 0)
                        comboOrient.SelectedIndex = comboOrient.FindString(dc.cardOrient[0]);
                    else
                        comboOrient.SelectedIndex = 0;

                    // material
                    dc.fillMaterial();
                    comboMaterial.DataSource = dc.dataMaterial;
                    if (comboMaterial.FindString(dc.cardMaterial[0]) >= 0)
                        comboMaterial.SelectedIndex = comboMaterial.FindString(dc.cardMaterial[0]);
                    else
                        comboMaterial.SelectedIndex = 0;

                    // condition
                    dc.fillCond();
                    comboCondition.DataSource = dc.dataCond;
                    if (comboCondition.FindString(dc.cardCond[0]) >= 0)
                        comboCondition.SelectedIndex = comboCondition.FindString(dc.cardCond[0]);
                    else
                        comboCondition.SelectedIndex = 0;

                    // sent type
                    dc.fillSentType();
                    comboSentType.DataSource = dc.dataSentType;
                    if (comboSentType.FindString(dc.cardSentType[0]) >= 0)
                        comboSentType.SelectedIndex = comboSentType.FindString(dc.cardSentType[0]);
                    else
                        comboSentType.SelectedIndex = 0;

                    // read postcard numbers
                    dc.fillCardNumber();
                    comboEquals1.DataSource = dc.dataEquals;
                    if (comboEquals1.FindString(dc.cardEquals1[0]) >= 0)
                        comboEquals1.SelectedIndex = comboEquals1.FindString(dc.cardEquals1[0]);
                    else
                        comboEquals1.SelectedIndex = 0;
                    txtDiff1.Text = dc.cardDifferences1[0];
                    comboEquals2.DataSource = dc.dataEquals;
                    if (comboEquals2.FindString(dc.cardEquals2[0]) >= 0)
                        comboEquals2.SelectedIndex = comboEquals2.FindString(dc.cardEquals2[0]);
                    else
                        comboEquals2.SelectedIndex = 0;
                    txtDiff2.Text = dc.cardDifferences2[0];
                    comboEquals3.DataSource = dc.dataEquals;
                    if (comboEquals3.FindString(dc.cardEquals3[0]) >= 0)
                        comboEquals3.SelectedIndex = comboEquals3.FindString(dc.cardEquals3[0]);
                    else
                        comboEquals3.SelectedIndex = 0;
                    txtDiff3.Text = dc.cardDifferences3[0];
                    comboEquals4.DataSource = dc.dataEquals;
                    if (comboEquals4.FindString(dc.cardEquals4[0]) >= 0)
                        comboEquals4.SelectedIndex = comboEquals4.FindString(dc.cardEquals4[0]);
                    else
                        comboEquals4.SelectedIndex = 0;
                    txtDiff4.Text = dc.cardDifferences4[0];
                    comboEquals5.DataSource = dc.dataEquals;
                    if (comboEquals5.FindString(dc.cardEquals5[0]) >= 0)
                        comboEquals5.SelectedIndex = comboEquals5.FindString(dc.cardEquals5[0]);
                    else
                        comboEquals5.SelectedIndex = 0;
                    txtDiff5.Text = dc.cardDifferences5[0];
                    if (dc.cardIdentical[0].ToUpper() == "Y")
                    {

                        // equals to ref.1
                        lblEquals1.Visible = true;
                        comboEquals1.Visible = true;
                        lblDiff1.Visible = true;
                        txtDiff1.Visible = true;

                        // equals to ref.2
                        if (comboEquals1.Text.Length > 0)
                        {
                            lblEquals2.Visible = true;
                            comboEquals2.Visible = true;
                            lblDiff2.Visible = true;
                            txtDiff2.Visible = true;

                            // equals to ref.3
                            if (comboEquals2.Text.Length > 0)
                            {
                                lblEquals3.Visible = true;
                                comboEquals3.Visible = true;
                                lblDiff3.Visible = true;
                                txtDiff3.Visible = true;

                                // equals to ref.4
                                if (comboEquals3.Text.Length > 0)
                                {
                                    lblEquals4.Visible = true;
                                    comboEquals4.Visible = true;
                                    lblDiff4.Visible = true;
                                    txtDiff4.Visible = true;

                                    // equals to ref.5
                                    if (comboEquals4.Text.Length > 0)
                                    {
                                        lblEquals5.Visible = true;
                                        comboEquals5.Visible = true;
                                        lblDiff5.Visible = true;
                                        txtDiff5.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                chkIsScanned.Checked = false;
                chkInTheBlog.Checked = false;
                chkIsSeries.Checked = false;
                chkBorders.Checked = false;
                chkIsIdentical.Checked = false;
                chkBackTxt.Checked = false;
                chkFrontTxt.Checked = false;
                txtSubPublisher.Text = "";
                txtBlogURL.Text = "";
                txtLocality.Text = "";
                txtRegion.Text = "";
                txtDescEng.Text = "";
                txtDescOrig.Text = "";
                txtTotImg.Text = "";
                if (chkIsSeries.Checked)
                {
                    lblTotPostcards.Visible = true;
                    txtTotPostcards.Visible = true;
                    txtTotPostcards.Text = "";
                }
                else
                {
                    lblTotPostcards.Visible = false;
                    txtTotPostcards.Visible = false;
                }
                txtBarcode.Text = "";
                txtFrtColor.Text = "";
                txtBckColor.Text = "";
                txtBigDesc.Text = "";
                datePurchase.Value = DateTime.Today;
                txtPrice.Text = "";
                txtWebpage.Text = "";
                txtTypeDesc.Text = "";
                txtFrtImgPath.Text = "";
                txtBckImgPath.Text = "";
                dc.fillPub();
                comboPublisher.DataSource = dc.dataPub;
                dc.fillCountry();
                comboRegCountry.DataSource = dc.dataCountry;
                comboPubCountry.DataSource = dc.dataCountry;
                dc.fillTheme();
                comboTheme.DataSource = dc.dataTheme;
                dc.fillColor();
                comboColor.DataSource = dc.dataColor;
                dc.fillYear();
                comboYear.DataSource = dc.dataYear;
                dc.fillImgType();
                comboImgType.DataSource = dc.dataImgType;
                dc.fillSize();
                comboSize.DataSource = dc.dataSize;
                dc.fillShape();
                comboShape.DataSource = dc.dataShape;
                dc.fillOrient();
                comboOrient.DataSource = dc.dataOrient;
                dc.fillMaterial();
                comboMaterial.DataSource = dc.dataMaterial;
                dc.fillCond();
                comboCondition.DataSource = dc.dataCond;
                dc.fillSentType();
                comboSentType.DataSource = dc.dataSentType;
                dc.fillCardNumber();
                comboEquals1.DataSource = dc.dataEquals;
                txtDiff1.Text = "";
                comboEquals2.DataSource = dc.dataEquals;
                txtDiff2.Text = "";
                comboEquals3.DataSource = dc.dataEquals;
                txtDiff3.Text = "";
                comboEquals4.DataSource = dc.dataEquals;
                txtDiff4.Text = "";
                comboEquals5.DataSource = dc.dataEquals;
                txtDiff5.Text = "";
                _chkIsSeriesStatus();
            }
            lblRecNum.Text = "# " + nRecord.ToString();
            _showPictures();
        }

        private void btnCloseCardPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CardView_Load(object sender, EventArgs e)
        {
            ViewCard();
        }

        private void _chkIsSeriesStatus()
        {
            if (chkIsSeries.Checked)
            {
                lblTotPostcards.Visible = true;
                txtTotPostcards.Visible = true;
                txtTotPostcards.Text = dc.cardTotalCards[0];
                lblPartialSeries.ForeColor = Color.WhiteSmoke;
                lblPartialSeries.BackColor = Color.MediumPurple;
                lblPartialSeries.Visible = true;
            }
            else
            {
                lblTotPostcards.Visible = false;
                txtTotPostcards.Visible = false;
                lblPartialSeries.ForeColor = Color.FromArgb(224, 224, 224);
                lblPartialSeries.BackColor = Color.FromArgb(100, 100, 100);
                lblPartialSeries.Visible = false;
            }
        }

        private void chkIsIdentical_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsIdentical.Checked)
            {
                lblEquals1.Visible = true;
                lblDiff1.Visible = true;
                comboEquals1.Visible = true;
                txtDiff1.Visible = true;
                lblEquals2.Visible = true;
                lblDiff2.Visible = true;
                comboEquals2.Visible = true;
                txtDiff2.Visible = true;
                lblEquals3.Visible = true;
                lblDiff3.Visible = true;
                comboEquals3.Visible = true;
                txtDiff3.Visible = true;
                lblEquals4.Visible = true;
                lblDiff4.Visible = true;
                comboEquals4.Visible = true;
                txtDiff4.Visible = true;
                lblEquals5.Visible = true;
                lblDiff5.Visible = true;
                comboEquals5.Visible = true;
                txtDiff5.Visible = true;
            }
            else
            {
                lblEquals1.Visible = false;
                lblDiff1.Visible = false;
                comboEquals1.Visible = false;
                txtDiff1.Visible = false;
                lblEquals2.Visible = false;
                lblDiff2.Visible = false;
                comboEquals2.Visible = false;
                txtDiff2.Visible = false;
                lblEquals3.Visible = false;
                lblDiff3.Visible = false;
                comboEquals3.Visible = false;
                txtDiff3.Visible = false;
                lblEquals4.Visible = false;
                lblDiff4.Visible = false;
                comboEquals4.Visible = false;
                txtDiff4.Visible = false;
                lblEquals5.Visible = false;
                lblDiff5.Visible = false;
                comboEquals5.Visible = false;
                txtDiff5.Visible = false;
            }

        }

        private void _showPictures()
        {
            // test if the front image exists
            if (txtFrtImgPath.Text.Trim() != "")
            {
                try
                {
                    // if it exists, display the image
                    picFrtImg.ImageLocation = dc.cardFrontImgPath[0];
                }
                catch
                {
                    picFrtImg.ImageLocation = "";
                }
            }

            // test if the back image exists
            if (txtBckImgPath.Text.Trim() != "")
            {
                try
                {
                    // if is the real image, display the new image
                    picBckImg.ImageLocation = dc.cardBackImgPath[0];
                }
                catch
                {
                    picBckImg.ImageLocation = "";
                }
            }
        }

        private void _showPhotos(object sender, EventArgs e)
        {
            _showPictures();
        }

        /* 
        // Save the postcard
        */
        private void btnSave_Click(object sender, EventArgs e)
        {
            // get the old data
            oldLog = "";
            // get the new/changed data
            newLog = "";
            if (addUpdateView == 2)
            {
                _newRef();
                if (verify)
                {
                    addSeriesCard = "-1";
                    _writeVar();
                    return;
                }
            }
            else if (addUpdateView == 3)
            {
                if (nRecord == 0)
                    addUpdateView = 2;
                else
                    dc.cardID = nRecord;
            }

            if (txtCardNumber.Text.Length > 0 || txtCardNumber.Text.Trim() != "")
            {
                dc.cardNumber[0] = txtCardNumber.Text;
                dc.cardPublisher[0] = comboPublisher.Text;
                dc.cardSubPub[0] = txtSubPublisher.Text;
                if (chkIsScanned.Checked)
                    dc.cardScanned[0] = "Y";
                else
                    dc.cardScanned[0] = "N";
                if (chkInTheBlog.Checked)
                    dc.cardInBlog[0] = "Y";
                else
                    dc.cardInBlog[0] = "N";
                dc.cardBlogURL[0] = txtBlogURL.Text;
                dc.cardLocality[0] = txtLocality.Text;
                dc.cardRegion[0] = txtRegion.Text;
                dc.cardRegCountry[0] = comboRegCountry.Text;
                dc.cardPubCountry[0] = comboPubCountry.Text;
                dc.cardDescEng[0] = txtDescEng.Text;
                dc.cardDescOrg[0] = txtDescOrig.Text;
                dc.cardTheme[0] = comboTheme.Text;
                dc.cardColor[0] = comboColor.Text;
                dc.cardYear[0] = comboYear.Text;
                dc.cardImgType[0] = comboImgType.Text;
                dc.cardImgNumber[0] = txtTotImg.Text;
                if (chkIsSeries.Checked)
                    dc.cardIsSeries[0] = "Y";
                else
                    dc.cardIsSeries[0] = "N";
                dc.cardSize[0] = comboSize.Text;
                dc.cardShape[0] = comboShape.Text;
                dc.cardOrient[0] = comboOrient.Text;
                dc.cardBarcode[0] = txtBarcode.Text;
                dc.cardMaterial[0] = comboMaterial.Text;
                dc.cardCond[0] = comboCondition.Text;
                if (chkBorders.Checked)
                    dc.cardBorders[0] = "Y";
                else
                    dc.cardBorders[0] = "N";
                if (chkFrontTxt.Checked)
                    dc.cardFrontTxt[0] = "Y";
                else
                    dc.cardFrontTxt[0] = "N";
                if (chkBackTxt.Checked)
                    dc.cardBackTxt[0] = "Y";
                else
                    dc.cardBackTxt[0] = "N";
                dc.cardFrontColor[0] = txtFrtColor.Text;
                dc.cardBackColor[0] = txtBckColor.Text;
                string datePurchaseString = datePurchase.Value.ToString("yyyy-MM-dd");
                dc.cardDatePurchase[0] = datePurchaseString.Substring(0, 10);
                dc.cardCostPrice[0] = txtPrice.Text;
                dc.cardWebpage[0] = txtWebpage.Text;
                if (chkIsIdentical.Checked)
                    dc.cardIdentical[0] = "Y";
                else
                    dc.cardIdentical[0] = "N";
                dc.cardEquals1[0] = comboEquals1.Text;
                dc.cardEquals2[0] = comboEquals2.Text;
                dc.cardEquals3[0] = comboEquals3.Text;
                dc.cardEquals4[0] = comboEquals4.Text;
                dc.cardEquals5[0] = comboEquals5.Text;
                dc.cardDifferences1[0] = txtDiff1.Text;
                dc.cardDifferences2[0] = txtDiff2.Text;
                dc.cardDifferences3[0] = txtDiff3.Text;
                dc.cardDifferences4[0] = txtDiff4.Text;
                dc.cardDifferences5[0] = txtDiff5.Text;
                dc.cardBigDesc[0] = txtBigDesc.Text;
                dc.cardSentType[0] = comboSentType.Text;
                dc.cardTypeDesc[0] = txtTypeDesc.Text;
                dc.cardFrontImgPath[0] = txtFrtImgPath.Text;
                dc.cardBackImgPath[0] = txtBckImgPath.Text;
            }

            string msg = dc.cardNumber[0] + "\n" + dc.cardSubPub[0] + "\n" + dc.cardDescEng[0] + "\n\n";
            if (addUpdateView == 2)
            {
                msg += dc.langLabels[92];
                dc.ADD_CARD();
                dc.ADD_LOG(dc.langLabels[92], dc.langLabels[8], dc.cardNumber[0], oldLog, newLog, 1);
            }
            else if (addUpdateView == 3)
            {
                msg += dc.langLabels[93];
                dc.UPDATE_CARD();
                dc.ADD_LOG(dc.langLabels[93], dc.langLabels[8], dc.cardNumber[0], oldLog, newLog, 1);
            }
            MessageBox.Show(msg);
            if (chkIsSeries.Checked) // && dc.cardIsSeries[0].ToUpper() == "Y"
            {
                _checkIsSeries();
            }
            dc.UPDATE_FILE();
            this.Close();
        }

        private void _checkIsSeries()
        {
            string msg2;
            if(addUpdateView==2 || addUpdateView==3)
                msg2 = dc.langLabels[34] + "\n" + txtCardNumber.Text.Trim() + "\n" + dc.langLabels[97] + "\n\n" + dc.langLabels[98];
            else
                msg2 = dc.langLabels[34] + "\n" + txtCardNumber.Text.Trim() + "\n" + dc.langLabels[97] + "\n\n" + dc.langLabels[106];
            DialogResult dialog = MessageBox.Show(msg2, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                addSeriesCard = dc.cardNumber[0];
            else
                addSeriesCard = "-1";

            if (addSeriesCard != "-1") _writeVar();
            this.Close();
        }

        private void _stateChanged()
        {
            if (addUpdateView == 3)
            {
                lblAddUpdate.Text = dc.langLabels[78];
                btnSave.BackColor = Color.FromArgb(255, 255, 128);
            }
            else if (addUpdateView == 2)
            {
                lblAddUpdate.Text = dc.langLabels[77];
                btnSave.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void _chkIsSeriesChangeStatus(object sender, EventArgs e)
        {
            _checkIsSeries();
        }

        private void _chkBlogUrl(object sender, EventArgs e)
        {
            _checkBlogUrl();
        }

        private void chkIsSeries_CheckedChanged(object sender, EventArgs e)
        {
            _isSeries();
        }

        private void _chkTxtFrt(object sender, EventArgs e)
        {
            _checkText();
        }

        private void _numberChanged(object sender, EventArgs e)
        {
            changeFileName();
        }

        private void _imgTypeChgd(object sender, EventArgs e)
        {
            _imgTypeChanged();
        }

        private void _imgTypeChanged()
        {
            if (comboImgType.Text.ToUpper() == "S")
            {
                txtTotImg.Text = "1";
                txtTotImg.Enabled = false;
            }
            else
                txtTotImg.Enabled = true;
        }

        private void _txtChanged(object sender, KeyPressEventArgs e)
        {
            //changeFileName();
            oldCardNumber = txtCardNumber.Text;
        }

        private void _chkBckTxt(object sender, EventArgs e)
        {
            _checkText();
        }
                
        private void changeFileName()
        {
            txtFrtImgPath.Text = imgPath + txtCardNumber.Text + "f.png";
            txtBckImgPath.Text = imgPath + txtCardNumber.Text + "b.png";
            /*
            string newCardNumber, oldFrtPath, oldBckPath, newFrtPath, newBckPath;
            newCardNumber = txtCardNumber.Text;
            oldFrtPath = txtFrtImgPath.Text;
            oldBckPath = txtBckImgPath.Text;
            if (!oldFrtPath.Contains(newCardNumber) && oldCardNumber != null)
            {
                newFrtPath = oldFrtPath.Replace(oldCardNumber, newCardNumber);
                txtFrtImgPath.Text = newFrtPath;
            }
            if (!oldBckPath.Contains(newCardNumber) && oldCardNumber != null)
            {
                newBckPath = oldBckPath.Replace(oldCardNumber, newCardNumber);
                txtBckImgPath.Text = newBckPath;
            }
            */
        }

        private void _isSeries()
        {
            if (chkIsSeries.Checked)
            {
                txtTotPostcards.Visible = true;
                lblTotPostcards.Visible = true;
            }
            else
            {
                lblTotPostcards.Visible = false;
                txtTotPostcards.Visible = false;
            }
        }

        private void _checkBlogUrl()
        {
            if (chkInTheBlog.Checked)
            {
                txtBlogURL.Visible = true;
                lblBlogURL.Visible = true;
            }
            else
            {
                txtBlogURL.Visible = false;
                lblBlogURL.Visible = false;
            }
        }

        private void _checkText()
        {
            if (chkFrontTxt.Checked)
            {
                lblFrtColor.Visible = true;
                txtFrtColor.Visible = true;
            }
            else
            {
                lblFrtColor.Visible= false;
                txtFrtColor.Visible= false;
            }

            if (chkBackTxt.Checked)
            {
                lblBckColor.Visible = true;
                txtBckColor.Visible = true;
            }
            else
            {
                lblBckColor.Visible = false;
                txtBckColor.Visible = false;
            }
        }

        private void _newRef()
        {
            string msg;
            if (txtCardNumber.Text.Length > 0)
            {
                dc.cardNumber[0] = txtCardNumber.Text;
                verify = dc.SEARCH_CARDNUMBER();
                if (verify)
                {
                    msg = dc.langLabels[90];
                    MessageBox.Show(msg);
                }
            }
            else
            {
                msg = dc.langLabels[91];
                MessageBox.Show(msg);
                this.Close();
                return;
            }
        }

        private void _writeVar()
        {
            string fileName = @"PEditor.tmp"; // filename
            string dirPath = @"";            // check into the current directory
            try
            {

                if (File.Exists(dirPath + fileName))
                {
                    File.Delete(dirPath + fileName);
                }
                using (StreamWriter writer = new StreamWriter(dirPath + fileName))
                {
                    writer.WriteLine(addSeriesCard);
                }
            }
            catch
            {

            }
        }
    }
}
