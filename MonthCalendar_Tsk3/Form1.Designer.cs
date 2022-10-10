namespace MonthCalendar_Tsk3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(54, 69);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(58, 27);
            this.textBoxDay.TabIndex = 0;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(132, 69);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(59, 27);
            this.textBoxMonth.TabIndex = 1;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(226, 69);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(90, 27);
            this.textBoxYear.TabIndex = 2;
            this.textBoxYear.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(341, 37);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введіть дату народження";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "День";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Місяць";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Рік";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обрати на календарі";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Закрити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 269);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxDay;
        private TextBox textBoxMonth;
        private TextBox textBoxYear;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}