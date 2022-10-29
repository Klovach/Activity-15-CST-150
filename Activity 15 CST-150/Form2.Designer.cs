namespace Activity_15_CST_150
{
    partial class Form2
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
            this.lblForm2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblLuckyNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblForm2
            // 
            this.lblForm2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForm2.AutoSize = true;
            this.lblForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblForm2.Location = new System.Drawing.Point(82, 80);
            this.lblForm2.Name = "lblForm2";
            this.lblForm2.Size = new System.Drawing.Size(314, 33);
            this.lblForm2.TabIndex = 0;
            this.lblForm2.Text = "Your lucky number is...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblLuckyNumber
            // 
            this.lblLuckyNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLuckyNumber.AutoSize = true;
            this.lblLuckyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F);
            this.lblLuckyNumber.Location = new System.Drawing.Point(112, 127);
            this.lblLuckyNumber.Name = "lblLuckyNumber";
            this.lblLuckyNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLuckyNumber.Size = new System.Drawing.Size(0, 170);
            this.lblLuckyNumber.TabIndex = 1;
            this.lblLuckyNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 411);
            this.Controls.Add(this.lblLuckyNumber);
            this.Controls.Add(this.lblForm2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Your Lucky Number Results";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForm2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblLuckyNumber;
    }
}