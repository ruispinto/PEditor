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
    public partial class ChangeLanguage : Form
    {
        connection_class con = new connection_class();
        dataclass dc = new dataclass();

        public string oldCulture, newLanguage, newCulture, imgPath;

        public ChangeLanguage(string oldCulture, string _imgPath)
        {
            InitializeComponent();
            currentCountry.Text = oldCulture;
            imgPath = _imgPath;
            dc.TEMP_CULTURE();
            try
            {
                dc.TEMP_LABELS(1, oldCulture);
                this.Text = dc.langLabels[82];
                lblCurrLang.Text = dc.langLabels[83] + ":";
                lblLanguage.Text = dc.langLabels[24];
                btnAccept.Text = dc.langLabels[85];
                currentCountry.Text = dc.langLabels[84];
                if (dc.cultCulture.BinarySearch(oldCulture) < 0)
                {
                    currentCountry.Text = dc.cultCountry[(dc.cultCulture.BinarySearch(oldCulture) * -1)];
                }
                else
                {
                    currentCountry.Text = dc.cultCountry[(dc.cultCulture.BinarySearch(oldCulture))];
                }
                int i = 0;
                while (i < dc.cultCountry.Count)
                {
                    countryList.Items.Add(dc.cultCountry[i]);
                    i++;
                }
                if (countryList.FindString(currentCountry.Text) >= 0)
                    countryList.SelectedIndex = countryList.FindString(currentCountry.Text);
            }
            catch
            {

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            newLanguage = countryList.SelectedItem.ToString();
            if (dc.cultCountry.BinarySearch(newLanguage) < 0)
            {
                newCulture = dc.cultCulture[(dc.cultCountry.BinarySearch(newLanguage) * -1)];
            }
            else
            {
                newCulture = dc.cultCulture[(dc.cultCountry.BinarySearch(newLanguage))];
            }
            _fileLanguage();
            MessageBox.Show(dc.langLabels[86]);
            Application.Restart();
            this.Close();
        }

        private void _fileLanguage()
        {
            string fileName = @"PEditor.ini";   // filename
            string dirPath = @"";               // check into the current directory
            try
            {

                if (File.Exists(dirPath + fileName))
                {
                    File.Delete(dirPath + fileName);
                }
                using (StreamWriter writer = new StreamWriter(dirPath + fileName))
                {
                    writer.WriteLine("[Language]");
                    writer.WriteLine(newCulture);
                    writer.WriteLine("[ImagePath]");
                    writer.WriteLine(imgPath);
                }
            }
            catch
            {

            }
        }
    }
}
