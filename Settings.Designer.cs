
namespace Converter
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comlabel = new System.Windows.Forms.Label();
            this.comports = new System.Windows.Forms.ComboBox();
            this.reprintlabel = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bcolorbutton = new System.Windows.Forms.Button();
            this.fcolorbutton = new System.Windows.Forms.Button();
            this.reprintset = new System.Windows.Forms.ComboBox();
            this.company = new System.Windows.Forms.Label();
            this.companyname = new System.Windows.Forms.TextBox();
            this.row2 = new System.Windows.Forms.Label();
            this.row3 = new System.Windows.Forms.Label();
            this.row3text = new System.Windows.Forms.TextBox();
            this.row2text = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comlabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comports, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.reprintlabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.save, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.bcolorbutton, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.fcolorbutton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.reprintset, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.company, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.companyname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.row2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.row3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.row3text, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.row2text, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comlabel
            // 
            this.comlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comlabel.AutoSize = true;
            this.comlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.comlabel.Location = new System.Drawing.Point(3, 0);
            this.comlabel.Name = "comlabel";
            this.comlabel.Size = new System.Drawing.Size(140, 29);
            this.comlabel.TabIndex = 0;
            this.comlabel.Text = "COM Port";
            this.comlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.comlabel, "Vendosni portën seriale (RS232) përdorur nga printeri juaj.");
            // 
            // comports
            // 
            this.comports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comports.FormattingEnabled = true;
            this.comports.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.comports.Location = new System.Drawing.Point(149, 3);
            this.comports.Name = "comports";
            this.comports.Size = new System.Drawing.Size(140, 21);
            this.comports.TabIndex = 2;
            // 
            // reprintlabel
            // 
            this.reprintlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reprintlabel.AutoSize = true;
            this.reprintlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reprintlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.reprintlabel.Location = new System.Drawing.Point(3, 29);
            this.reprintlabel.Name = "reprintlabel";
            this.reprintlabel.Size = new System.Drawing.Size(140, 29);
            this.reprintlabel.TabIndex = 1;
            this.reprintlabel.Text = "Auto Reprint";
            this.reprintlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.reprintlabel, "Vendosni nëse printeri printon një kopje klienti automatikisht.");
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.SetColumnSpan(this.save, 2);
            this.save.Cursor = System.Windows.Forms.Cursors.Default;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.Gainsboro;
            this.save.Location = new System.Drawing.Point(3, 264);
            this.save.Name = "save";
            this.tableLayoutPanel1.SetRowSpan(this.save, 2);
            this.save.Size = new System.Drawing.Size(286, 44);
            this.save.TabIndex = 4;
            this.save.Text = "Save | Ruaj";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngjyra Dytësore";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label2, "Ngjyra e shkrimit dhe butonave");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ngjyra Parësore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label1, "Ngjyra e programit");
            // 
            // bcolorbutton
            // 
            this.bcolorbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bcolorbutton.Location = new System.Drawing.Point(149, 206);
            this.bcolorbutton.Name = "bcolorbutton";
            this.bcolorbutton.Size = new System.Drawing.Size(140, 23);
            this.bcolorbutton.TabIndex = 11;
            this.bcolorbutton.Text = "Zgjidh";
            this.bcolorbutton.UseVisualStyleBackColor = true;
            this.bcolorbutton.Click += new System.EventHandler(this.bcolorbutton_Click);
            // 
            // fcolorbutton
            // 
            this.fcolorbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fcolorbutton.Location = new System.Drawing.Point(149, 177);
            this.fcolorbutton.Name = "fcolorbutton";
            this.fcolorbutton.Size = new System.Drawing.Size(140, 23);
            this.fcolorbutton.TabIndex = 10;
            this.fcolorbutton.Text = "Zgjidh";
            this.fcolorbutton.UseVisualStyleBackColor = true;
            this.fcolorbutton.Click += new System.EventHandler(this.fcolorbutton_Click);
            // 
            // reprintset
            // 
            this.reprintset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reprintset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reprintset.FormattingEnabled = true;
            this.reprintset.Items.AddRange(new object[] {
            "True",
            "False"});
            this.reprintset.Location = new System.Drawing.Point(149, 32);
            this.reprintset.Name = "reprintset";
            this.reprintset.Size = new System.Drawing.Size(140, 21);
            this.reprintset.TabIndex = 5;
            // 
            // company
            // 
            this.company.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.ForeColor = System.Drawing.Color.Gainsboro;
            this.company.Location = new System.Drawing.Point(3, 58);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(140, 29);
            this.company.TabIndex = 12;
            this.company.Text = "Kompania";
            this.company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.company, "Emri parësor në program dhe faturë");
            // 
            // companyname
            // 
            this.companyname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyname.Location = new System.Drawing.Point(149, 61);
            this.companyname.Name = "companyname";
            this.companyname.Size = new System.Drawing.Size(140, 23);
            this.companyname.TabIndex = 13;
            // 
            // row2
            // 
            this.row2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.row2.AutoSize = true;
            this.row2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row2.ForeColor = System.Drawing.Color.Gainsboro;
            this.row2.Location = new System.Drawing.Point(3, 87);
            this.row2.Name = "row2";
            this.row2.Size = new System.Drawing.Size(140, 29);
            this.row2.TabIndex = 14;
            this.row2.Text = "Rreshti 2";
            this.row2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.row2, "Rreshti i dytë në faturë");
            // 
            // row3
            // 
            this.row3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.row3.AutoSize = true;
            this.row3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row3.ForeColor = System.Drawing.Color.Gainsboro;
            this.row3.Location = new System.Drawing.Point(3, 116);
            this.row3.Name = "row3";
            this.row3.Size = new System.Drawing.Size(140, 29);
            this.row3.TabIndex = 15;
            this.row3.Text = "Rreshti 3";
            this.row3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.row3, "Rreshti i tretë në faturë");
            // 
            // row3text
            // 
            this.row3text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.row3text.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row3text.Location = new System.Drawing.Point(149, 119);
            this.row3text.Name = "row3text";
            this.row3text.Size = new System.Drawing.Size(140, 23);
            this.row3text.TabIndex = 17;
            // 
            // row2text
            // 
            this.row2text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.row2text.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row2text.Location = new System.Drawing.Point(149, 90);
            this.row2text.Name = "row2text";
            this.row2text.Size = new System.Drawing.Size(140, 23);
            this.row2text.TabIndex = 16;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(294, 314);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label comlabel;
        private System.Windows.Forms.Label reprintlabel;
        private System.Windows.Forms.ComboBox comports;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox reprintset;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button fcolorbutton;
        private System.Windows.Forms.Button bcolorbutton;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.TextBox companyname;
        private System.Windows.Forms.Label row2;
        private System.Windows.Forms.Label row3;
        private System.Windows.Forms.TextBox row3text;
        private System.Windows.Forms.TextBox row2text;
    }
}