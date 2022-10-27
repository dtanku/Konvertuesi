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
using System.Xml.Linq;

namespace Converter
{
    public partial class Rates : Form
    {
        public Rates()
        {
            InitializeComponent();
            SetTheme();
        }

        private void SetTheme()
        {
            this.BackColor = Properties.Settings.Default.fcolor;
            this.shitje.ForeColor = Properties.Settings.Default.bcolor;
            this.blerje.ForeColor = Properties.Settings.Default.bcolor;
            this.valuta.ForeColor = Properties.Settings.Default.bcolor;
            this.dollar.ForeColor = Properties.Settings.Default.bcolor;
            this.euro.ForeColor = Properties.Settings.Default.bcolor;
            this.franga.ForeColor = Properties.Settings.Default.bcolor;
            this.pound.ForeColor = Properties.Settings.Default.bcolor;
            this.kanadez.ForeColor = Properties.Settings.Default.bcolor;
            this.australian.ForeColor = Properties.Settings.Default.bcolor;
            this.yuan.ForeColor = Properties.Settings.Default.bcolor;
            this.yen.ForeColor = Properties.Settings.Default.bcolor;
            this.franga.ForeColor = Properties.Settings.Default.bcolor;
            this.usdbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.usdbuy.BackColor = Properties.Settings.Default.fcolor;
            this.usdsell.ForeColor = Properties.Settings.Default.bcolor;
            this.usdsell.BackColor = Properties.Settings.Default.fcolor;
            this.eurbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.eurbuy.BackColor = Properties.Settings.Default.fcolor;
            this.eursell.ForeColor = Properties.Settings.Default.bcolor;
            this.eursell.BackColor = Properties.Settings.Default.fcolor;
            this.gbpbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.gbpbuy.BackColor = Properties.Settings.Default.fcolor;
            this.gbpsell.ForeColor = Properties.Settings.Default.bcolor;
            this.gbpsell.BackColor = Properties.Settings.Default.fcolor;
            this.cadbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.cadbuy.BackColor = Properties.Settings.Default.fcolor;
            this.cadsell.ForeColor = Properties.Settings.Default.bcolor;
            this.cadsell.BackColor = Properties.Settings.Default.fcolor;
            this.chfbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.chfbuy.BackColor = Properties.Settings.Default.fcolor;
            this.chfsell.ForeColor = Properties.Settings.Default.bcolor;
            this.chfsell.BackColor = Properties.Settings.Default.fcolor;
            this.audbuy.ForeColor = Properties.Settings.Default.bcolor;
            this.audbuy.BackColor = Properties.Settings.Default.fcolor;
            this.audsell.ForeColor = Properties.Settings.Default.bcolor;
            this.audsell.BackColor = Properties.Settings.Default.fcolor;
            this.cnybuy.ForeColor = Properties.Settings.Default.bcolor;
            this.cnybuy.BackColor = Properties.Settings.Default.fcolor;
            this.cnysell.ForeColor = Properties.Settings.Default.bcolor;
            this.cnysell.BackColor = Properties.Settings.Default.fcolor;
            this.jpybuy.ForeColor = Properties.Settings.Default.bcolor;
            this.jpybuy.BackColor = Properties.Settings.Default.fcolor;
            this.jpysell.ForeColor = Properties.Settings.Default.bcolor;
            this.jpysell.BackColor = Properties.Settings.Default.fcolor;
        }
        private void Rates_Load(object sender, EventArgs e){
            LoadRates();
        }

        private void LoadRates()
        {
            XDocument doc = XDocument.Load(@"E:\repos\prices.xml");
            XElement parent = doc.Element("Prices");
            usdbuy.Value = Convert.ToDecimal(parent.Element("USD").Attribute("buy").Value);
            usdsell.Value = Convert.ToDecimal(parent.Element("USD").Attribute("sell").Value);
            eurbuy.Value = Convert.ToDecimal(parent.Element("EUR").Attribute("buy").Value);
            eursell.Value = Convert.ToDecimal(parent.Element("EUR").Attribute("sell").Value);
            gbpbuy.Value = Convert.ToDecimal(parent.Element("GBP").Attribute("buy").Value);
            gbpsell.Value = Convert.ToDecimal(parent.Element("GBP").Attribute("sell").Value);
            chfbuy.Value = Convert.ToDecimal(parent.Element("CHF").Attribute("buy").Value);
            chfsell.Value = Convert.ToDecimal(parent.Element("CHF").Attribute("sell").Value);
            cadbuy.Value = Convert.ToDecimal(parent.Element("CAD").Attribute("buy").Value);
            cadsell.Value = Convert.ToDecimal(parent.Element("CAD").Attribute("sell").Value);
            audbuy.Value = Convert.ToDecimal(parent.Element("AUD").Attribute("buy").Value);
            audsell.Value = Convert.ToDecimal(parent.Element("AUD").Attribute("sell").Value);
            cnybuy.Value = Convert.ToDecimal(parent.Element("CNY").Attribute("buy").Value);
            cnysell.Value = Convert.ToDecimal(parent.Element("CNY").Attribute("sell").Value);
            jpybuy.Value = Convert.ToDecimal(parent.Element("JPY").Attribute("buy").Value);
            jpysell.Value = Convert.ToDecimal(parent.Element("JPY").Attribute("sell").Value);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings() { Visible = true };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            CreateXMLTree();
            Application.Restart();
            Environment.Exit(0);
        }
        public Dictionary<int, decimal[]> CreateDictionary()
        {
            Dictionary<int, decimal[]> currencyrates = new Dictionary<int, decimal[]>
            {
                { 0, new decimal[] { 1M, 1M } },
                { 1, new decimal[] { usdbuy.Value, usdsell.Value } },
                { 2, new decimal[] { eurbuy.Value, eursell.Value } },
                { 3, new decimal[] { gbpbuy.Value, gbpsell.Value } },
                { 4, new decimal[] { chfbuy.Value, chfsell.Value } },
                { 5, new decimal[] { cadbuy.Value, cadsell.Value } },
                { 6, new decimal[] { audbuy.Value, audsell.Value } },
                { 7, new decimal[] { cnybuy.Value, cnysell.Value } },
                { 8, new decimal[] { jpybuy.Value, jpysell.Value } },
            };
            return currencyrates;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            usdbuy.Value = 1.00M;
            eurbuy.Value = 1.00M;
            gbpbuy.Value = 1.00M;
            chfbuy.Value = 1.00M;
            cadbuy.Value = 1.00M;
            audbuy.Value = 1.00M;
            cnybuy.Value = 1.00M;
            jpybuy.Value = 1.00M;
            usdsell.Value = 1.00M;
            eursell.Value = 1.00M;
            gbpsell.Value = 1.00M;
            chfsell.Value = 1.00M;
            cadsell.Value = 1.00M;
            audsell.Value = 1.00M;
            cnysell.Value = 1.00M;
            jpysell.Value = 1.00M;
        }
        public static XDocument CreateRecordDocument()
        {
            string recordpath = @"c:\temp\prices.xml";
            XDocument maindoc;
            // This text is added only once to the file.
            if (!File.Exists(recordpath))
            {
                // Create a file to write to.
                maindoc = new XDocument(
                    new XElement("Prices")
                );
            }
            else
            {
                maindoc = XDocument.Load(@"c:\temp\prices.xml");
            }
            return maindoc;
        }
        public void CreateXMLTree()
        {
            Dictionary<int, decimal[]> currencyrates = CreateDictionary();
            XDocument maindoc = CreateRecordDocument();
            XElement parent = maindoc.Element("Prices");

            XElement xdoc = new XElement("Prices",
                new XElement("ALL",
                    new XAttribute("buy", currencyrates[0][0]),
                    new XAttribute("sell", currencyrates[0][1])),
                new XElement("USD",
                    new XAttribute("buy", currencyrates[1][0]),
                    new XAttribute("sell", currencyrates[1][1])),
                new XElement("EUR",
                    new XAttribute("buy", currencyrates[2][0]),
                    new XAttribute("sell", currencyrates[2][1])),
                new XElement("GBP",
                    new XAttribute("buy", currencyrates[3][0]),
                    new XAttribute("sell", currencyrates[3][1])),
                new XElement("CHF",
                    new XAttribute("buy", currencyrates[4][0]),
                    new XAttribute("sell", currencyrates[4][1])),
                new XElement("CAD",
                    new XAttribute("buy", currencyrates[5][0]),
                    new XAttribute("sell", currencyrates[5][1])),
                new XElement("AUD",
                    new XAttribute("buy", currencyrates[6][0]),
                    new XAttribute("sell", currencyrates[6][1])),
                new XElement("CNY",
                    new XAttribute("buy", currencyrates[7][0]),
                    new XAttribute("sell", currencyrates[7][1])),
                new XElement("JPY",
                    new XAttribute("buy", currencyrates[8][0]),
                    new XAttribute("sell", currencyrates[8][1]))
            );;

            parent.ReplaceWith(new XElement(xdoc));
            maindoc.Save(@"c:\temp\prices.xml");
        }
    }
}
