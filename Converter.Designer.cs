
namespace Converter
{
	partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.converttable = new System.Windows.Forms.TableLayoutPanel();
            this.currencyfrom = new System.Windows.Forms.ComboBox();
            this.converted = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.NumericUpDown();
            this.konvertimi = new System.Windows.Forms.Label();
            this.currencyto = new System.Windows.Forms.ComboBox();
            this.printo = new System.Windows.Forms.Button();
            this.reprint = new System.Windows.Forms.Button();
            this.historiku = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.koha = new System.Windows.Forms.Label();
            this.kohatani = new System.Windows.Forms.Timer(this.components);
            this.converttable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // converttable
            // 
            this.converttable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.converttable.BackColor = System.Drawing.Color.Transparent;
            this.converttable.ColumnCount = 2;
            this.converttable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converttable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.converttable.Controls.Add(this.currencyfrom, 1, 2);
            this.converttable.Controls.Add(this.converted, 0, 4);
            this.converttable.Controls.Add(this.input, 0, 2);
            this.converttable.Controls.Add(this.konvertimi, 0, 1);
            this.converttable.Controls.Add(this.currencyto, 1, 4);
            this.converttable.Controls.Add(this.printo, 0, 6);
            this.converttable.Controls.Add(this.reprint, 0, 5);
            this.converttable.Controls.Add(this.historiku, 1, 5);
            this.converttable.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.converttable.Controls.Add(this.koha, 1, 1);
            this.converttable.Location = new System.Drawing.Point(0, 0);
            this.converttable.Name = "converttable";
            this.converttable.RowCount = 7;
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.converttable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.converttable.Size = new System.Drawing.Size(501, 416);
            this.converttable.TabIndex = 0;
            // 
            // currencyfrom
            // 
            this.currencyfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.currencyfrom.Cursor = System.Windows.Forms.Cursors.Default;
            this.currencyfrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currencyfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyfrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencyfrom.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyfrom.ForeColor = System.Drawing.Color.Silver;
            this.currencyfrom.FormattingEnabled = true;
            this.currencyfrom.Items.AddRange(new object[] {
            "ALL",
            "USD",
            "EUR",
            "GBP",
            "CHF",
            "CAD",
            "AUD",
            "CNY",
            "JPY"});
            this.currencyfrom.Location = new System.Drawing.Point(253, 118);
            this.currencyfrom.Name = "currencyfrom";
            this.currencyfrom.Size = new System.Drawing.Size(245, 38);
            this.currencyfrom.TabIndex = 1;
            this.currencyfrom.SelectedIndexChanged += new System.EventHandler(this.Currency_SelectedIndexChanged);
            // 
            // converted
            // 
            this.converted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.converted.AutoSize = true;
            this.converted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.converted.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converted.ForeColor = System.Drawing.Color.Gainsboro;
            this.converted.Location = new System.Drawing.Point(3, 214);
            this.converted.Name = "converted";
            this.converted.Size = new System.Drawing.Size(244, 66);
            this.converted.TabIndex = 3;
            this.converted.Text = "Sasia";
            this.converted.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.input.DecimalPlaces = 2;
            this.input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.Color.Silver;
            this.input.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.input.Location = new System.Drawing.Point(3, 118);
            this.input.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(244, 35);
            this.input.TabIndex = 4;
            this.input.ValueChanged += new System.EventHandler(this.input_ValueChanged);
            // 
            // konvertimi
            // 
            this.konvertimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.konvertimi.AutoSize = true;
            this.konvertimi.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konvertimi.ForeColor = System.Drawing.Color.Gainsboro;
            this.konvertimi.Location = new System.Drawing.Point(3, 74);
            this.konvertimi.Name = "konvertimi";
            this.konvertimi.Size = new System.Drawing.Size(244, 41);
            this.konvertimi.TabIndex = 6;
            this.konvertimi.Text = "Konvertim";
            this.konvertimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currencyto
            // 
            this.currencyto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currencyto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencyto.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyto.ForeColor = System.Drawing.Color.Silver;
            this.currencyto.FormattingEnabled = true;
            this.currencyto.Items.AddRange(new object[] {
            "ALL",
            "USD",
            "EUR",
            "GBP",
            "CHF",
            "CAD",
            "AUD",
            "CNY",
            "JPY"});
            this.currencyto.Location = new System.Drawing.Point(253, 217);
            this.currencyto.Name = "currencyto";
            this.currencyto.Size = new System.Drawing.Size(245, 38);
            this.currencyto.TabIndex = 7;
            this.currencyto.SelectedIndexChanged += new System.EventHandler(this.Currency_SelectedIndexChanged);
            // 
            // printo
            // 
            this.printo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.converttable.SetColumnSpan(this.printo, 2);
            this.printo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.printo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printo.ForeColor = System.Drawing.Color.Gainsboro;
            this.printo.Location = new System.Drawing.Point(3, 349);
            this.printo.Name = "printo";
            this.printo.Size = new System.Drawing.Size(495, 64);
            this.printo.TabIndex = 8;
            this.printo.Text = "Printo";
            this.printo.UseVisualStyleBackColor = false;
            this.printo.Click += new System.EventHandler(this.printo_Click);
            // 
            // reprint
            // 
            this.reprint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reprint.Cursor = System.Windows.Forms.Cursors.Default;
            this.reprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reprint.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reprint.ForeColor = System.Drawing.Color.Gainsboro;
            this.reprint.Location = new System.Drawing.Point(3, 283);
            this.reprint.Name = "reprint";
            this.reprint.Size = new System.Drawing.Size(244, 60);
            this.reprint.TabIndex = 9;
            this.reprint.Text = "Printo Faturen e Fundit";
            this.reprint.UseVisualStyleBackColor = false;
            this.reprint.Click += new System.EventHandler(this.reprint_Click);
            // 
            // historiku
            // 
            this.historiku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historiku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.historiku.Cursor = System.Windows.Forms.Cursors.Default;
            this.historiku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historiku.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historiku.ForeColor = System.Drawing.Color.Gainsboro;
            this.historiku.Location = new System.Drawing.Point(253, 283);
            this.historiku.Name = "historiku";
            this.historiku.Size = new System.Drawing.Size(245, 60);
            this.historiku.TabIndex = 11;
            this.historiku.Text = "Shiko Historikun";
            this.historiku.UseVisualStyleBackColor = false;
            this.historiku.Click += new System.EventHandler(this.historiku_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.converttable.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 68);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 68);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(102, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kompania";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // koha
            // 
            this.koha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.koha.AutoSize = true;
            this.koha.BackColor = System.Drawing.Color.Transparent;
            this.koha.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.koha.ForeColor = System.Drawing.Color.Gainsboro;
            this.koha.Location = new System.Drawing.Point(253, 74);
            this.koha.Name = "koha";
            this.koha.Size = new System.Drawing.Size(245, 41);
            this.koha.TabIndex = 5;
            this.koha.Text = "Koha Tani";
            this.koha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kohatani
            // 
            this.kohatani.Enabled = true;
            this.kohatani.Interval = 1000;
            this.kohatani.Tick += new System.EventHandler(this.kohatani_Tick);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(501, 416);
            this.Controls.Add(this.converttable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Converter";
            this.Text = "Konvertuesi";
            this.converttable.ResumeLayout(false);
            this.converttable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel converttable;
		private System.Windows.Forms.ComboBox currencyfrom;
		private System.Windows.Forms.Label converted;
		private System.Windows.Forms.NumericUpDown input;
		private System.Windows.Forms.Timer kohatani;
		private System.Windows.Forms.Label koha;
		private System.Windows.Forms.Label konvertimi;
		private System.Windows.Forms.ComboBox currencyto;
		private System.Windows.Forms.Button printo;
		private System.Windows.Forms.Button reprint;
		private System.Windows.Forms.Button historiku;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
    }
}

