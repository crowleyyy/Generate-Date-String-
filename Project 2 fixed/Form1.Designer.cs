namespace Project_2_fixed
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelDayNumber = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.textBoxDayOfWeek = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDayNumber = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(114, 343);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(203, 23);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Generate Date String";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Location = new System.Drawing.Point(86, 126);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(87, 16);
            this.labelDayOfWeek.TabIndex = 1;
            this.labelDayOfWeek.Text = "Day Of Week";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(108, 178);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(43, 16);
            this.labelMonth.TabIndex = 2;
            this.labelMonth.Text = "Month";
            // 
            // labelDayNumber
            // 
            this.labelDayNumber.AutoSize = true;
            this.labelDayNumber.Location = new System.Drawing.Point(88, 230);
            this.labelDayNumber.Name = "labelDayNumber";
            this.labelDayNumber.Size = new System.Drawing.Size(83, 16);
            this.labelDayNumber.TabIndex = 3;
            this.labelDayNumber.Text = "Day Number";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(111, 282);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(36, 16);
            this.Year.TabIndex = 4;
            this.Year.Text = "Year";
            // 
            // textBoxDayOfWeek
            // 
            this.textBoxDayOfWeek.Location = new System.Drawing.Point(224, 126);
            this.textBoxDayOfWeek.Name = "textBoxDayOfWeek";
            this.textBoxDayOfWeek.Size = new System.Drawing.Size(224, 22);
            this.textBoxDayOfWeek.TabIndex = 5;
            this.textBoxDayOfWeek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(224, 178);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(224, 22);
            this.textBoxMonth.TabIndex = 6;
            // 
            // textBoxDayNumber
            // 
            this.textBoxDayNumber.Location = new System.Drawing.Point(224, 230);
            this.textBoxDayNumber.Name = "textBoxDayNumber";
            this.textBoxDayNumber.Size = new System.Drawing.Size(224, 22);
            this.textBoxDayNumber.TabIndex = 7;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(224, 282);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(224, 22);
            this.textBoxYear.TabIndex = 8;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Location = new System.Drawing.Point(169, 384);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(2, 18);
            this.labelResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxDayNumber);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxDayOfWeek);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.labelDayNumber);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelDayOfWeek);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "Form1";
            this.Text = "Generate Date String";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelDayOfWeek;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelDayNumber;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.TextBox textBoxDayOfWeek;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDayNumber;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelResult;
    }
}

