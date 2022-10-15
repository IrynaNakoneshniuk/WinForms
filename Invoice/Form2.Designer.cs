namespace Invoice
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.LoadChek = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(100, 167);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(243, 29);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Закрити";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LoadChek
            // 
            this.LoadChek.Location = new System.Drawing.Point(100, 96);
            this.LoadChek.Name = "LoadChek";
            this.LoadChek.Size = new System.Drawing.Size(243, 29);
            this.LoadChek.TabIndex = 1;
            this.LoadChek.Text = "Завантажити квитанції";
            this.LoadChek.UseVisualStyleBackColor = true;
            this.LoadChek.Click += new System.EventHandler(this.LoadChek_Click);
            // 
            // AddButton
            // 
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddButton.Location = new System.Drawing.Point(100, 32);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(243, 29);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Додати чек";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 249);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LoadChek);
            this.Controls.Add(this.AddButton);
            this.Name = "Form2";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button CloseButton;
        private Button LoadChek;
        private Button AddButton;
    }
}