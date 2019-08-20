namespace DateTimePicker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtSeason = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(300, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Time";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(371, 111);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(371, 163);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 7;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(371, 215);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            this.txtMonth.TabIndex = 8;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(371, 267);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 20);
            this.txtDay.TabIndex = 9;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(371, 319);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 10;
            // 
            // txtSeason
            // 
            this.txtSeason.Location = new System.Drawing.Point(318, 394);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(164, 20);
            this.txtSeason.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(700, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(527, 111);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(248, 228);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSeason);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtSeason;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

