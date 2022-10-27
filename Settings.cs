using System;
using System.Drawing;
using System.Windows.Forms;

namespace Converter
{
    public partial class Settings : Form
    {
        Color fcolor;
        Color bcolor;
        public Settings()
        {
            InitializeComponent();
            SetTheme();
            comports.Text = Properties.Settings.Default.comport;
            reprintset.Text = Properties.Settings.Default.copy.ToString();
            companyname.Text = Properties.Settings.Default.company;
            colorDialog1.Color = Properties.Settings.Default.fcolor;
            fcolor = Properties.Settings.Default.fcolor;
            colorDialog2.Color = Properties.Settings.Default.bcolor;
            bcolor = Properties.Settings.Default.bcolor;
            row2text.Text = Properties.Settings.Default.row2;
            row3text.Text = Properties.Settings.Default.row3;
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.comport = comports.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Zgjidhni portën COM!");
            }
            try
            {
                Properties.Settings.Default.copy = Convert.ToBoolean(reprintset.SelectedItem);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Zgjidhni riprintimin!");
            }
            try
            {
                Properties.Settings.Default.company = companyname.Text;
                Properties.Settings.Default.row2 = row2text.Text;
                Properties.Settings.Default.row3 = row3text.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Fusni emrin e kompanisë!");
            }
            Properties.Settings.Default.fcolor = fcolor;
            Properties.Settings.Default.bcolor = bcolor;
            Properties.Settings.Default.Save();
            Application.Restart();
            Environment.Exit(0);
        }
        public void SetTheme()
        {
            this.BackColor = Properties.Settings.Default.fcolor;
            this.comlabel.ForeColor = Properties.Settings.Default.bcolor;
            this.reprintlabel.ForeColor = Properties.Settings.Default.bcolor;
            this.company.ForeColor = Properties.Settings.Default.bcolor;
            this.label1.ForeColor = Properties.Settings.Default.bcolor;
            this.label2.ForeColor = Properties.Settings.Default.bcolor;
            this.row2.ForeColor = Properties.Settings.Default.bcolor;
            this.row3.ForeColor = Properties.Settings.Default.bcolor;
            this.save.ForeColor = Properties.Settings.Default.bcolor;
        }
        private void fcolorbutton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            DialogResult result = colorDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                fcolor = colorDialog1.Color;
            }
        }
        private void bcolorbutton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog2 = new ColorDialog();
            DialogResult result = colorDialog2.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                bcolor = colorDialog2.Color;
            }
        }
    }
}
