using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEditor.myclass;

namespace PEditor
{
    public partial class About : Form
    {
        dataclass dc = new dataclass();

        public About(string _softCulture)
        {
            InitializeComponent();

            try
            {
                dc.TEMP_LABELS(1, _softCulture);
                string _softName = dc.langLabels[1];
                dc._GETVERSION();
                string _softVersion = dc._vVersion[0];
                string _dataVersion = dc._rVersion[0];
                string _updateVersion = dc._uVersion[0];
                string _copyrightYear;

                lblSoftName.Text = _softName;
                lblVersion.Text = dc.langLabels[2] + " " + _softVersion + " (" + _dataVersion + ")";
                lblupdateData.Text = dc.langLabels[3] + " " + _updateVersion;
                _copyrightYear = "© Copyright 2020-";
                _copyrightYear += "2020-" + _dataVersion.Substring(0, 4);
                _copyrightYear += ", Rui Pinto -";

                lblCopyright.Text = _copyrightYear;
                string greetingText = "";
                if (DateTime.Now.Hour <= 12)
                    greetingText = dc.langLabels[87];
                else if (DateTime.Now.Hour <= 18)
                    greetingText = dc.langLabels[88];
                else if (DateTime.Now.Hour >= 19)
                    greetingText = dc.langLabels[89];
                lblGreeting.Text = greetingText;
                btncloseAbout.Text=dc.langLabels[5];
            }
            catch
            {
            }
        }

        private void About_Load(object sender, EventArgs e)
        {
        }

        private void btncloseAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
