using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Potwierdzenie_numeru_VAT.ValidationService;

namespace Potwierdzenie_numeru_VAT
{
    public partial class Potwierdzenie : Form
    {
        bool valid;
        string name;
        string address;
        string traderName;
        string traderCompanyType;
        string traderStreet;
        string traderPostcode;
        string traderCity;
        string traderAddress;
        string requestIdentifier;
            
        public Potwierdzenie()
        {
            InitializeComponent();            
        }
        
        private void WeryfikujButton_Click(object sender, EventArgs e)
        {
           if (!String.IsNullOrEmpty(textBox1.Text) && textBox1.Text.Length == 10 && !String.IsNullOrEmpty(textBox2.Text) && textBox2.Text.Length == 10 )
            {
                CheckVat();
                CheckVatApprox();
            }
            else
            {
                MessageBox.Show("Wypełnij pole 10 cyfrowym numerem NIP!");
            }           
        }

        private void WybierzKraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            krajSkrot.Text = WybierzKraj.Text.Substring(0,2).ToString();
        }

        private void WybierzKraj2_SelectedIndexChanged(object sender, EventArgs e)
        {
             krajSkrot2.Text = WybierzKraj2.Text.Substring(0,2).ToString();
        }

        private void CheckVat()
        {
            try
            {
                string countryCode = krajSkrot.Text.ToString();
                string vatNumber = textBox1.Text;
                checkVatPortTypeClient check = new checkVatPortTypeClient();
                check.checkVat(ref countryCode, ref vatNumber, out valid, out name, out address);
                if (valid == true)
                {
                    MessageBox.Show(valid.ToString());
                    MessageBox.Show(name);
                    MessageBox.Show(address);
                    labelValid.Text = valid.ToString();
                    labelName.Text = name;
                    labelAdress.Text = address;
                }
                else
                {
                    MessageBox.Show("Podany numer VAT nie istnieje");
                }
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show(error.Message);
            }            
        }
        private void CheckVatApprox()
        {
            try
            {
                string countryCode = krajSkrot.Text.ToString();
                string vatNumber = textBox1.Text;
                string requesterCountryCode = countryCode;
                string requesterVatNumber = vatNumber;

                checkVatPortTypeClient check = new checkVatPortTypeClient();
                check.checkVatApprox(ref countryCode, ref vatNumber, ref traderName, ref traderCompanyType, ref traderStreet, ref traderPostcode, ref traderCity, requesterCountryCode, requesterVatNumber, out valid, out traderAddress, out matchCode traderNameMatch, out matchCode traderCompanyTypeMatch, out matchCode traderStreetMatch, out matchCode traderPostcodeMatch, out matchCode traderCityMatch, out requestIdentifier);
                labelID.Text = requestIdentifier.ToString();
                labelData.Text = DateTime.Now.ToString();
                labelPanstwoCzlonkowskie.Text = countryCode;
                labelNumer.Text = vatNumber;                
            }
            catch (InvalidOperationException error)
            {                
                MessageBox.Show(error.Message);
            }            
        }

        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xDocument = new XmlDocument();
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "XML-File | *.xml"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlTextWriter xmlZapis = new XmlTextWriter(saveFileDialog.FileName, Encoding.UTF8);
                    xmlZapis.WriteStartDocument();
                    xmlZapis.WriteStartElement("ZapisWyniku");
                    xmlZapis.WriteStartElement("Walidacja");
                    xmlZapis.WriteString(labelValid.Text);
                    xmlZapis.WriteEndElement();
                    xmlZapis.WriteStartElement("PaństwoCzłonkowskie");
                    xmlZapis.WriteString(labelPanstwoCzlonkowskie.Text);
                    xmlZapis.WriteEndElement();
                    xmlZapis.WriteStartElement("NumerVAT");
                    xmlZapis.WriteString(labelNumer.Text);
                    xmlZapis.WriteEndElement();
                    xmlZapis.WriteStartElement("Data");
                    xmlZapis.WriteString(labelData.Text);
                    xmlZapis.WriteEndElement();
                    xmlZapis.WriteStartElement("Nazwa");
                    xmlZapis.WriteString(labelName.Text);
                    xmlZapis.WriteEndElement();
                    xmlZapis.WriteStartElement("Adres");
                    xmlZapis.WriteString(labelAdress.Text);
                    xmlZapis.WriteEndElement();
                    xmlZapis.WriteStartElement("IdentyfikatorZapytania");
                    xmlZapis.WriteString(labelID.Text);
                    xmlZapis.WriteEndElement();
                    xmlZapis.WriteEndElement();
                    xmlZapis.WriteEndDocument();
                    xmlZapis.Close();
                    xDocument.Save(xmlZapis);
                    MessageBox.Show("Dane zostały zapisane.");
                }
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
