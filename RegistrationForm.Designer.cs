namespace List_Task2
{
    partial class RegistrationForm
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
            this.NameLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SurnameLabel2 = new MetroFramework.Controls.MetroLabel();
            this.EmailLabel3 = new MetroFramework.Controls.MetroLabel();
            this.NumberPhoneLabel4 = new MetroFramework.Controls.MetroLabel();
            this.NameBox1 = new System.Windows.Forms.TextBox();
            this.SurnameBox2 = new System.Windows.Forms.TextBox();
            this.EmailBox3 = new System.Windows.Forms.TextBox();
            this.NumberPhoneBox4 = new System.Windows.Forms.TextBox();
            this.ButtonRegistration = new MetroFramework.Controls.MetroButton();
            this.Close_Button = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // NameLabel1
            // 
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.Location = new System.Drawing.Point(12, 95);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(84, 20);
            this.NameLabel1.TabIndex = 0;
            this.NameLabel1.Text = "Введіть ім`я";
            // 
            // SurnameLabel2
            // 
            this.SurnameLabel2.AutoSize = true;
            this.SurnameLabel2.Location = new System.Drawing.Point(12, 147);
            this.SurnameLabel2.Name = "SurnameLabel2";
            this.SurnameLabel2.Size = new System.Drawing.Size(72, 20);
            this.SurnameLabel2.TabIndex = 1;
            this.SurnameLabel2.Text = "Прізвище";
            // 
            // EmailLabel3
            // 
            this.EmailLabel3.AutoSize = true;
            this.EmailLabel3.Location = new System.Drawing.Point(12, 193);
            this.EmailLabel3.Name = "EmailLabel3";
            this.EmailLabel3.Size = new System.Drawing.Size(48, 20);
            this.EmailLabel3.TabIndex = 2;
            this.EmailLabel3.Text = "E-mail";
            // 
            // NumberPhoneLabel4
            // 
            this.NumberPhoneLabel4.AutoSize = true;
            this.NumberPhoneLabel4.Location = new System.Drawing.Point(12, 246);
            this.NumberPhoneLabel4.Name = "NumberPhoneLabel4";
            this.NumberPhoneLabel4.Size = new System.Drawing.Size(120, 20);
            this.NumberPhoneLabel4.TabIndex = 3;
            this.NumberPhoneLabel4.Text = "Номер телефону";
            // 
            // NameBox1
            // 
            this.NameBox1.Location = new System.Drawing.Point(140, 95);
            this.NameBox1.Name = "NameBox1";
            this.NameBox1.Size = new System.Drawing.Size(457, 27);
            this.NameBox1.TabIndex = 4;
            // 
            // SurnameBox2
            // 
            this.SurnameBox2.Location = new System.Drawing.Point(140, 140);
            this.SurnameBox2.Name = "SurnameBox2";
            this.SurnameBox2.Size = new System.Drawing.Size(457, 27);
            this.SurnameBox2.TabIndex = 5;
            // 
            // EmailBox3
            // 
            this.EmailBox3.Location = new System.Drawing.Point(140, 186);
            this.EmailBox3.Name = "EmailBox3";
            this.EmailBox3.Size = new System.Drawing.Size(457, 27);
            this.EmailBox3.TabIndex = 6;
            // 
            // NumberPhoneBox4
            // 
            this.NumberPhoneBox4.Location = new System.Drawing.Point(140, 239);
            this.NumberPhoneBox4.Name = "NumberPhoneBox4";
            this.NumberPhoneBox4.Size = new System.Drawing.Size(457, 27);
            this.NumberPhoneBox4.TabIndex = 7;
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.Location = new System.Drawing.Point(140, 282);
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Size = new System.Drawing.Size(176, 29);
            this.ButtonRegistration.TabIndex = 8;
            this.ButtonRegistration.Text = "Додати анкету";
            this.ButtonRegistration.UseSelectable = true;
            this.ButtonRegistration.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(401, 282);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(196, 29);
            this.Close_Button.TabIndex = 9;
            this.Close_Button.Text = "Закрити";
            this.Close_Button.UseSelectable = true;
            this.Close_Button.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 333);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.ButtonRegistration);
            this.Controls.Add(this.NumberPhoneBox4);
            this.Controls.Add(this.EmailBox3);
            this.Controls.Add(this.SurnameBox2);
            this.Controls.Add(this.NameBox1);
            this.Controls.Add(this.NumberPhoneLabel4);
            this.Controls.Add(this.EmailLabel3);
            this.Controls.Add(this.NameLabel1);
            this.Controls.Add(this.SurnameLabel2);
            this.Name = "RegistrationForm";
            this.ShowIcon = false;
            this.Text = "Реєстрація";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel NameLabel1;
        private MetroFramework.Controls.MetroLabel SurnameLabel2;
        private MetroFramework.Controls.MetroLabel EmailLabel3;
        private MetroFramework.Controls.MetroLabel NumberPhoneLabel4;
        public TextBox NameBox1;
        public TextBox SurnameBox2;
        public TextBox EmailBox3;
        public TextBox NumberPhoneBox4;
        private MetroFramework.Controls.MetroButton ButtonRegistration;
        private MetroFramework.Controls.MetroButton Close_Button;
    }
}