namespace Invoice
{
    partial class AddChekForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.BrandLable = new System.Windows.Forms.Label();
            this.DateLable = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(597, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(597, 27);
            this.textBox3.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(165, 278);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(237, 29);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Зберегти";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(517, 278);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(245, 29);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Закрити";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Група виробу";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(165, 28);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(597, 28);
            this.comboBoxGroup.TabIndex = 9;
            // 
            // BrandLable
            // 
            this.BrandLable.AutoSize = true;
            this.BrandLable.Location = new System.Drawing.Point(44, 96);
            this.BrandLable.Name = "BrandLable";
            this.BrandLable.Size = new System.Drawing.Size(109, 20);
            this.BrandLable.TabIndex = 10;
            this.BrandLable.Text = "Марка виробу";
            // 
            // DateLable
            // 
            this.DateLable.AutoSize = true;
            this.DateLable.Location = new System.Drawing.Point(45, 154);
            this.DateLable.Name = "DateLable";
            this.DateLable.Size = new System.Drawing.Size(108, 20);
            this.DateLable.TabIndex = 11;
            this.DateLable.Text = "Дата прийому";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(165, 211);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(597, 28);
            this.comboBoxStatus.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Статус";
            // 
            // AddChekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.DateLable);
            this.Controls.Add(this.BrandLable);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Name = "AddChekForm";
            this.Text = "AddChekForm";
            this.Load += new System.EventHandler(this.AddChekForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private Button SaveButton;
        private Button CloseButton;
        private Label label1;
        private ComboBox comboBoxGroup;
        private Label BrandLable;
        private Label DateLable;
        private ComboBox comboBoxStatus;
        private Label label2;
    }
}