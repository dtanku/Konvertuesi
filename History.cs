using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DGVPrinterHelper;
using ESCPOS_NET;
using ESCPOS_NET.Emitters;
using ESCPOS_NET.Extensions;
using ESCPOS_NET.Utilities;
using System.Windows.Forms;
using System.IO;

namespace Converter
{
    public partial class Form2 : Form

    {

        public Form2()
        {
            InitializeComponent();
            SetTheme();
        }
        DataView dv;
        DataTable dt;
        SerialPrinter printerConn;
        EPSON printer;
        private void Form2_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"E:\repos\Historiku.xml");
            dataGridView1.DataSource = dataSet.Tables[0];
            dt = dataSet.Tables[0];
            dv = new DataView(dt);
            printer = new EPSON();
        }

        private void print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();

            printer.Title = "HISTORIKU I TRANSAKSIONEVE";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "DANAID SINANI TEST";
            printer.PrintDataGridView(dataGridView1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selecteddatefrom = dateTimePicker1.Value.Date;
            DateTime selecteddateto = dateTimePicker2.Value.Date.AddDays(1);
            if (selecteddatefrom == selecteddateto)
            {
                dv.RowFilter = String.Format("datetime >= #{0:s}#", selecteddatefrom);
            }
            else
            {
                dv.RowFilter = String.Format("datetime >= #{0:s}# AND datetime <= #{1:s}#", selecteddatefrom, selecteddateto);
            }
            dataGridView1.DataSource = dv;
        }
        public void SetTheme()
        {
            this.BackColor = Properties.Settings.Default.fcolor;
            this.dataGridView1.BackgroundColor = Properties.Settings.Default.fcolor;
            this.nga.ForeColor = Properties.Settings.Default.bcolor;
            this.tek.ForeColor = Properties.Settings.Default.bcolor;
        }

        private void reprintrecpt_Click(object sender, EventArgs e)
        {
            string number = "";
            decimal amount = 0;
            string from = "";
            string to = "" ;
            string kohaformatted = "";
            decimal amtconv = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                number = row.Cells[0].Value.ToString();
                amount = Convert.ToDecimal(row.Cells[1].Value);
                from = row.Cells[2].Value.ToString();
                amtconv = Convert.ToDecimal(row.Cells[3].Value);
                to = row.Cells[4].Value.ToString();
                string date = row.Cells[5].Value.ToString();
                DateTime reprinttime = DateTime.Parse(date);
                kohaformatted = reprinttime.ToString("dd-MM-yyyy HH:mm:ss");

            }
            Print.printerConn.Write(Print.Reprint(printer, kohaformatted, from, to, amount, amtconv, number));
        }
    }
}
