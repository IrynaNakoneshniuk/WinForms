namespace ComboBox_Tsk1
{
    partial class MainForm
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
            this.PositionComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.NumberHouseComboBox = new System.Windows.Forms.TextBox();
            this.SityComboBox = new MetroFramework.Controls.MetroComboBox();
            this.StreetComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.LoadListButton = new MetroFramework.Controls.MetroButton();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.SurnameLable = new System.Windows.Forms.Label();
            this.SalaryLable = new System.Windows.Forms.Label();
            this.positionLable = new System.Windows.Forms.Label();
            this.CityLable = new System.Windows.Forms.Label();
            this.StreetLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.ItemHeight = 24;
            this.PositionComboBox.Location = new System.Drawing.Point(133, 188);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(603, 30);
            this.PositionComboBox.TabIndex = 0;
            this.PositionComboBox.UseSelectable = true;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SurnameTextBox.Location = new System.Drawing.Point(133, 87);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(603, 27);
            this.SurnameTextBox.TabIndex = 1;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalaryTextBox.Location = new System.Drawing.Point(133, 139);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(603, 27);
            this.SalaryTextBox.TabIndex = 2;
            // 
            // NumberHouseComboBox
            // 
            this.NumberHouseComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumberHouseComboBox.Location = new System.Drawing.Point(133, 366);
            this.NumberHouseComboBox.Name = "NumberHouseComboBox";
            this.NumberHouseComboBox.Size = new System.Drawing.Size(603, 27);
            this.NumberHouseComboBox.TabIndex = 3;
            // 
            // SityComboBox
            // 
            this.SityComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SityComboBox.FormattingEnabled = true;
            this.SityComboBox.ItemHeight = 24;
            this.SityComboBox.Location = new System.Drawing.Point(133, 248);
            this.SityComboBox.Name = "SityComboBox";
            this.SityComboBox.Size = new System.Drawing.Size(603, 30);
            this.SityComboBox.TabIndex = 4;
            this.SityComboBox.UseSelectable = true;
            // 
            // StreetComboBox
            // 
            this.StreetComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StreetComboBox.FormattingEnabled = true;
            this.StreetComboBox.ItemHeight = 24;
            this.StreetComboBox.Location = new System.Drawing.Point(133, 303);
            this.StreetComboBox.Name = "StreetComboBox";
            this.StreetComboBox.Size = new System.Drawing.Size(603, 30);
            this.StreetComboBox.TabIndex = 5;
            this.StreetComboBox.UseSelectable = true;
            // 
            // SaveButton
            // 
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Location = new System.Drawing.Point(133, 429);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(178, 29);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Зберегти";
            this.SaveButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SaveButton.UseSelectable = true;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadListButton
            // 
            this.LoadListButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadListButton.Location = new System.Drawing.Point(353, 429);
            this.LoadListButton.Name = "LoadListButton";
            this.LoadListButton.Size = new System.Drawing.Size(178, 29);
            this.LoadListButton.TabIndex = 7;
            this.LoadListButton.Text = "Список співробітників";
            this.LoadListButton.UseSelectable = true;
            this.LoadListButton.Click += new System.EventHandler(this.LoadListButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(558, 429);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(178, 29);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Закрити";
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SurnameLable
            // 
            this.SurnameLable.AutoSize = true;
            this.SurnameLable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SurnameLable.Location = new System.Drawing.Point(23, 90);
            this.SurnameLable.Name = "SurnameLable";
            this.SurnameLable.Size = new System.Drawing.Size(77, 20);
            this.SurnameLable.TabIndex = 9;
            this.SurnameLable.Text = "Прізвище";
            // 
            // SalaryLable
            // 
            this.SalaryLable.AutoSize = true;
            this.SalaryLable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SalaryLable.Location = new System.Drawing.Point(27, 139);
            this.SalaryLable.Name = "SalaryLable";
            this.SalaryLable.Size = new System.Drawing.Size(73, 20);
            this.SalaryLable.TabIndex = 10;
            this.SalaryLable.Text = "Зарплата";
            // 
            // positionLable
            // 
            this.positionLable.AutoSize = true;
            this.positionLable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.positionLable.Location = new System.Drawing.Point(27, 188);
            this.positionLable.Name = "positionLable";
            this.positionLable.Size = new System.Drawing.Size(60, 20);
            this.positionLable.TabIndex = 11;
            this.positionLable.Text = "Посада";
            // 
            // CityLable
            // 
            this.CityLable.AutoSize = true;
            this.CityLable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CityLable.Location = new System.Drawing.Point(27, 248);
            this.CityLable.Name = "CityLable";
            this.CityLable.Size = new System.Drawing.Size(48, 20);
            this.CityLable.TabIndex = 12;
            this.CityLable.Text = "Місто";
            // 
            // StreetLable
            // 
            this.StreetLable.AutoSize = true;
            this.StreetLable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StreetLable.Location = new System.Drawing.Point(23, 294);
            this.StreetLable.Name = "StreetLable";
            this.StreetLable.Size = new System.Drawing.Size(59, 20);
            this.StreetLable.TabIndex = 13;
            this.StreetLable.Text = "Вулиця";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(23, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Будинок";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(823, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StreetLable);
            this.Controls.Add(this.CityLable);
            this.Controls.Add(this.positionLable);
            this.Controls.Add(this.SalaryLable);
            this.Controls.Add(this.SurnameLable);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LoadListButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StreetComboBox);
            this.Controls.Add(this.SityComboBox);
            this.Controls.Add(this.NumberHouseComboBox);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.PositionComboBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Форма для реєстрації";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox PositionComboBox;
        private TextBox SurnameTextBox;
        private TextBox SalaryTextBox;
        private TextBox NumberHouseComboBox;
        private MetroFramework.Controls.MetroComboBox SityComboBox;
        private MetroFramework.Controls.MetroComboBox StreetComboBox;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroButton LoadListButton;
        private MetroFramework.Controls.MetroButton CloseButton;
        private Label SurnameLable;
        private Label SalaryLable;
        private Label positionLable;
        private Label CityLable;
        private Label StreetLable;
        private Label label1;
    }
}