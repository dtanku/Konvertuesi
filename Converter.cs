using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ESCPOS_NET;
using ESCPOS_NET.Emitters;
using ESCPOS_NET.Extensions;
using ESCPOS_NET.Utilities;
using System.Security.Permissions;
using Microsoft.Win32;
using System.IO.Ports;

namespace Converter
{
	public partial class Converter : Form
	{
		Dictionary<int, decimal[]> currencyrates;
		EPSON printer;
		public SerialPrinter printerConn { get; private set; }
		bool reprintset = Properties.Settings.Default.copy;
		Decimal ConvValue;
		public Converter()
		{
			InitializeComponent();
			kohatani.Enabled = true;
			SetTheme();
			
			currencyrates = new Dictionary<int, decimal[]>
			{
				{ 0, new decimal[] { 1M, 1M } },
				{ 1, new decimal[] { 102.3M, 103.4M } },
				{ 2, new decimal[] { 121M, 121.3M } },
				{ 3, new decimal[] { 141.7M, 143.2M } },
				{ 4, new decimal[] { 112M, 112.9M } },
				{ 5, new decimal[] { 81M, 82.6M } },
				{ 6, new decimal[] { 74.7M, 76M } },
				{ 7, new decimal[] { 12.89M, 15.89M } },
				{ 8, new decimal[] { 69M, 0.94M } },
			};
			loadrates();
			printer = new EPSON();
			//	CheckActivation();
		}
		//public void CheckActivation()
		//{
		//	string keyName = "HKEY_CURRENT_USER\\SOFTWARE\\Kompania\\Konvertim";
		//	object noSuch = Registry.GetValue(keyName, "activated", 1);
		//	Console.WriteLine("\r\nNoSuchName: {0}", noSuch);
		//	if (noSuch == "true")
		//	{
		//		MessageBox.Show("Mungon Aktivizimi!");
		//		Environment.Exit(1);
		//	}
		//	string recordpath = @"c:\temp\prices.xml";
		//	// This text is added only once to the file.
		//	if (!File.Exists(recordpath))
		//	{
		//		MessageBox.Show("Mungon Konvertuesi!");
		//		Environment.Exit(1);
		//	}

		//}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.Control | Keys.H))
			{
				Form2 history = new Form2() { Visible = true };
			}
			else if (keyData == (Keys.Control | Keys.R))
			{
				GetLastReceipt();
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void GetLastReceipt()
		{
            XDocument doc = XDocument.Load(@"c:\temp\Historiku.xml");
            XElement root = doc.Root;
            XElement last = root.Element("Conversion");
            string koha = last.Attribute("datetime").Value;
            DateTime reprinttime = DateTime.Parse(koha);
            string kohaformatted = reprinttime.ToString("dd-MM-yyyy HH:mm:ss");
            decimal amount = Convert.ToDecimal(last.Attribute("amount").Value);
            string currencyfrom = last.Attribute("currencyfrom").Value;
            decimal converted = Convert.ToDecimal(last.Attribute("converted").Value);
            string currencyto = last.Attribute("currencyto").Value;
            string paddednumber = last.Attribute("Number").Value;

            try
            {
                Print.printerConn.Write(Print.Reprint(printer, kohaformatted, currencyfrom, currencyto, amount, converted, paddednumber));
            }
            catch (NullReferenceException) { MessageBox.Show("Error printeri! Rivendosni parametrat!"); }
            //catch (IOException) { MessageBox.Show("Error printeri! Rivendosni parametrat!"); }

        }

        private XDocument CreateRecordDocument()
		{
			string recordpath = @"c:\temp\Historiku.xml";
			XDocument maindoc;
			// This text is added only once to the file.
			if (!File.Exists(recordpath))
			{
				// Create a file to write to.
				maindoc = new XDocument(
					new XElement("Conversions")
				);
			}
			else
			{
				maindoc = XDocument.Load(@"c:\temp\Historiku.xml");
			}
			return maindoc;
		}
		private void kohatani_Tick(object sender, EventArgs e)
		{
			string time = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
			this.koha.Text = time;
		}
		public void InputChange()
        {
			var vlera = input.Value;
			int valutafrom;
			int valutato;
			if (currencyto.SelectedIndex > -1)
			{
				valutato = currencyto.SelectedIndex;
			}
			else
			{
				valutato = 0;
				currencyto.SelectedIndex = 0;
			}
			if (currencyfrom.SelectedIndex > -1)
			{
				valutafrom = currencyfrom.SelectedIndex;
			}
			else
			{
				valutafrom = 0;
				currencyfrom.SelectedIndex = 0;
			}
			ConvertCurrency(vlera, valutafrom, valutato);
		}
		private void input_ValueChanged(object sender, EventArgs e)
		{
			InputChange();
		}
		private void Currency_SelectedIndexChanged(object sender, EventArgs e)
		{
			InputChange();
		}
		private bool CheckSameCurrency(Decimal valutafrom, Decimal valutato)
		{
			return Decimal.Equals(valutafrom, valutato);
		}
		public void ConvertCurrency(decimal vlera, int valutafrom, int valutato)
		{
			decimal kursi1 = currencyrates[currencyfrom.SelectedIndex][0];
			decimal kursi2 = currencyrates[currencyto.SelectedIndex][1];
			if (CheckSameCurrency(valutafrom, valutato))
			{
				ConvValue = vlera;
			}
			else
			{
				ConvValue = Math.Round(((vlera / kursi2) * kursi1), 2);
			}
			this.converted.Text = ConvValue.ToString();
		}
		public void AMLCheck()
		{
		
			if (ConvValue >= 10000)
			{
				MessageBox.Show("Sipas ligjeve Shqiptare kundër pastrimit të parave, çdo transaksion me vlerë mbi 10000 lekë kërkon ruajtjen e një mjeti identifikimi. " +
					"Strukturimi i transaksioneve duke kryer disa të tilla nën limit është krim dhe ndëshkohet me ligj.", "Kujdes!");
			}
		}
		public void printo_Click(object sender, EventArgs e)
		{
			string sorttime = DateTime.Now.ToString("s");
			string printtime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
			AMLCheck();
			string paddednumber = Savefile.GetNumber();
			if (input.Value != 0.00M)
			{
				if (reprintset)
                {
					try
						{
							Print.printerConn.Write(Print.Receipt(printer, printtime, currencyfrom.Text, currencyto.Text, input.Value, ConvValue, paddednumber));
							Print.printerConn.Write(Print.Reprint(printer, printtime, currencyfrom.Text, currencyto.Text, input.Value, ConvValue, paddednumber));
						}
					catch (IOException) { MessageBox.Show("Error printeri! Rivendosni parametrat!"); }
					catch (NullReferenceException) { MessageBox.Show("Error printeri! Rivendosni parametrat!"); }
				}
                else
                {
                    try
                    {
                        Print.printerConn.Write(Print.Receipt(printer, printtime, currencyfrom.Text, currencyto.Text, input.Value, ConvValue, paddednumber));
                    }
                    catch (NullReferenceException) { MessageBox.Show("Error printeri! Rivendosni parametrat!"); }
                }
                XElement xdoc = Savefile.CreateXMLTree(sorttime, currencyfrom.Text, currencyto.Text, input.Value, converted.Text, paddednumber);
				XDocument maindoc = CreateRecordDocument();
				maindoc.Root.AddFirst(new XElement(xdoc));
				maindoc.Save(@"c:\temp\Historiku.xml");
			}
			else
			{
				MessageBox.Show("Nuk mund te printohet fature boshe!");
			}
		}
		private void reprint_Click(object sender, EventArgs e)
		{
            GetLastReceipt();
		}
		private void historiku_Click(object sender, EventArgs e)
		{
			Form2 history = new Form2() { Visible = true };
		}
        public void loadrates()
        {

            XDocument doc = XDocument.Load(@"c:\temp\prices.xml");
            XElement root = doc.Root;
            XElement usd = root.Element("USD");
            decimal usdbuy = Convert.ToDecimal(usd.Attribute("buy").Value);
            decimal usdsell = Convert.ToDecimal(usd.Attribute("sell").Value);
            decimal[] usdprices = new decimal[2] { usdbuy, usdsell };
            XElement eur = root.Element("EUR");
            decimal eurbuy = Convert.ToDecimal(eur.Attribute("buy").Value);
            decimal eursell = Convert.ToDecimal(eur.Attribute("sell").Value);
            decimal[] eurprices = new decimal[2] { eurbuy, eursell };
            XElement gbp = root.Element("GBP");
            decimal gbpbuy = Convert.ToDecimal(gbp.Attribute("buy").Value);
            decimal gbpsell = Convert.ToDecimal(gbp.Attribute("sell").Value);
            decimal[] gbpprices = new decimal[2] { gbpbuy, gbpsell };
            XElement chf = root.Element("CHF");
            decimal chfbuy = Convert.ToDecimal(chf.Attribute("buy").Value);
            decimal chfsell = Convert.ToDecimal(chf.Attribute("sell").Value);
            decimal[] chfprices = new decimal[2] { chfbuy, chfsell };
            XElement cad = root.Element("CAD");
            decimal cadbuy = Convert.ToDecimal(cad.Attribute("buy").Value);
            decimal cadsell = Convert.ToDecimal(cad.Attribute("sell").Value);
            decimal[] cadprices = new decimal[2] { cadbuy, cadsell };
            XElement aud = root.Element("AUD");
            decimal audbuy = Convert.ToDecimal(aud.Attribute("buy").Value);
            decimal audsell = Convert.ToDecimal(aud.Attribute("sell").Value);
            decimal[] audprices = new decimal[2] { audbuy, audsell };
            XElement cny = root.Element("CNY");
            decimal cnybuy = Convert.ToDecimal(cny.Attribute("buy").Value);
            decimal cnysell = Convert.ToDecimal(cny.Attribute("sell").Value);
            decimal[] cnyprices = new decimal[2] { cnybuy, cnysell };
            XElement jpy = root.Element("JPY");
            decimal jpybuy = Convert.ToDecimal(jpy.Attribute("buy").Value);
            decimal jpysell = Convert.ToDecimal(jpy.Attribute("sell").Value);
            decimal[] jpyprices = new decimal[2] { jpybuy, jpysell };
            currencyrates[1] = usdprices;
            currencyrates[2] = eurprices;
            currencyrates[3] = gbpprices;
            currencyrates[4] = chfprices;
            currencyrates[5] = cadprices;
            currencyrates[6] = audprices;
            currencyrates[7] = cnyprices;
            currencyrates[8] = jpyprices;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
		{
			Rates rates = new Rates() { Visible = true };
		}
		class Savefile
		{
			public static string GetNumber()
			{
				string path = @"c:\temp\printnr.txt";
				// This text is added only once to the file.
				if (!File.Exists(path))
				{
					// Create a file to write to.
					string createText = "0" + Environment.NewLine;
					File.WriteAllText(path, createText, Encoding.UTF8);
				}
				string fmt = "000000000.##";
				string number = File.ReadAllText(path);
				int newnumber = Convert.ToInt32(number) + 1;
				File.WriteAllText(path, newnumber.ToString());
				string paddednumber = newnumber.ToString(fmt);
				return paddednumber;
			}

			public static XElement CreateXMLTree(string koha, string currencyfrom, string currencyto, decimal input, string converted, string paddednumber)
			{
				return new XElement("Conversion",
						new XAttribute("Number", paddednumber),
						new XAttribute("amount", input),
						new XAttribute("currencyfrom", currencyfrom),
						new XAttribute("converted", converted),
						new XAttribute("currencyto", currencyto),
						new XAttribute("datetime", koha)
				);
			}
		}
		public void SetTheme()
		{
			this.label1.Text = Properties.Settings.Default.company;
			this.BackColor = Properties.Settings.Default.fcolor;
			this.currencyfrom.BackColor = Properties.Settings.Default.fcolor;
			this.currencyto.BackColor = Properties.Settings.Default.fcolor;
			this.input.BackColor = Properties.Settings.Default.fcolor;
			this.currencyfrom.ForeColor = Properties.Settings.Default.bcolor;
			this.currencyto.ForeColor = Properties.Settings.Default.bcolor;
			this.input.ForeColor = Properties.Settings.Default.bcolor;
			this.label1.ForeColor = Properties.Settings.Default.bcolor;
			this.konvertimi.ForeColor = Properties.Settings.Default.bcolor;
			this.koha.ForeColor = Properties.Settings.Default.bcolor;
			this.converted.ForeColor = Properties.Settings.Default.bcolor;
			this.printo.ForeColor = Properties.Settings.Default.bcolor;
			this.reprint.ForeColor = Properties.Settings.Default.bcolor;
			this.historiku.ForeColor = Properties.Settings.Default.bcolor;
		}
	}
}
