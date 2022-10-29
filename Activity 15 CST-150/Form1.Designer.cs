namespace Activity_15_CST_150
{
    partial class Form1
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
            this.btnGetNumber = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFavNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetNumber
            // 
            this.btnGetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnGetNumber.Location = new System.Drawing.Point(61, 416);
            this.btnGetNumber.Name = "btnGetNumber";
            this.btnGetNumber.Size = new System.Drawing.Size(501, 52);
            this.btnGetNumber.TabIndex = 0;
            this.btnGetNumber.Text = "Get Your Lucky Number";
            this.btnGetNumber.UseVisualStyleBackColor = true;
            this.btnGetNumber.Click += new System.EventHandler(this.btnGetNumber_Click);
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961 ",
            "1962 ",
            "1963 ",
            "1964 ",
            "1965 ",
            "1966 ",
            "1967 ",
            "1968 ",
            "1969",
            "1970 ",
            "1971 ",
            "1972 ",
            "1973 ",
            "1974 ",
            "1975 ",
            "1976 ",
            "1977 ",
            "1978 ",
            "1979",
            "1980 ",
            "1981 ",
            "1982 ",
            "1983 ",
            "1984 ",
            "1985 ",
            "1986 ",
            "1987 ",
            "1988 ",
            "1989",
            "1990 ",
            "1991",
            "1992 ",
            "1993",
            "1994 ",
            "1995 ",
            "1996 ",
            "1997 ",
            "1998 ",
            "1999",
            "2000 ",
            "2001 ",
            "2002 ",
            "2003 ",
            "2004 ",
            "2005 ",
            "2006 ",
            "2007 ",
            "2008 ",
            "2009",
            "2010 ",
            "2011 ",
            "2012 ",
            "2013 ",
            "2014 ",
            "2015 ",
            "2016",
            "2017 ",
            "2018 ",
            "2019",
            "2020 ",
            "2021 ",
            "2022"});
            this.cboYear.Location = new System.Drawing.Point(309, 106);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(253, 34);
            this.cboYear.TabIndex = 1;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // cboMonth
            // 
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cboMonth.Location = new System.Drawing.Point(309, 162);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(253, 34);
            this.cboMonth.TabIndex = 2;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // cboDay
            // 
            this.cboDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Location = new System.Drawing.Point(309, 222);
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(253, 34);
            this.cboDay.TabIndex = 3;
            // 
            // cboColor
            // 
            this.cboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Black",
            "White",
            "Brown",
            "Gold",
            "Silver"});
            this.cboColor.Location = new System.Drawing.Point(309, 280);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(253, 34);
            this.cboColor.TabIndex = 4;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblYear.Location = new System.Drawing.Point(91, 109);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(173, 20);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Enter your birth year...";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMonth.Location = new System.Drawing.Point(72, 170);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(187, 20);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Enter your birth month...";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDay.Location = new System.Drawing.Point(91, 230);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(167, 20);
            this.lblDay.TabIndex = 7;
            this.lblDay.Text = "Enter your birth day...";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblColor.Location = new System.Drawing.Point(57, 288);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(200, 20);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Enter your favorite color...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(57, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter your favorite number...";
            // 
            // cboFavNumber
            // 
            this.cboFavNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboFavNumber.FormattingEnabled = true;
            this.cboFavNumber.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboFavNumber.Location = new System.Drawing.Point(309, 338);
            this.cboFavNumber.Name = "cboFavNumber";
            this.cboFavNumber.Size = new System.Drawing.Size(253, 34);
            this.cboFavNumber.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 46);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lucky Number Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFavNumber);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.cboDay);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.btnGetNumber);
            this.Name = "Form1";
            this.Text = "Get Your  Lucky Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetNumber;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFavNumber;
        private System.Windows.Forms.Label label2;
    }
}

