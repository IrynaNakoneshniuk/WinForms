namespace List_Task2
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ButtonRegistration = new MetroFramework.Controls.MetroButton();
            this.RedactButton = new MetroFramework.Controls.MetroButton();
            this.ExitButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.Location = new System.Drawing.Point(79, 78);
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Size = new System.Drawing.Size(202, 29);
            this.ButtonRegistration.TabIndex = 0;
            this.ButtonRegistration.Text = "Реєстрація";
            this.ButtonRegistration.UseSelectable = true;
            this.ButtonRegistration.Click += new System.EventHandler(this.ClickRegistrationButton);
            // 
            // RedactButton
            // 
            this.RedactButton.Location = new System.Drawing.Point(79, 146);
            this.RedactButton.Name = "RedactButton";
            this.RedactButton.Size = new System.Drawing.Size(202, 29);
            this.RedactButton.TabIndex = 2;
            this.RedactButton.Text = "Редагувати";
            this.RedactButton.UseSelectable = true;
            this.RedactButton.Click += new System.EventHandler(this.RedactButton_Click);
            // 
            // ExitButton1
            // 
            this.ExitButton1.Location = new System.Drawing.Point(79, 212);
            this.ExitButton1.Name = "ExitButton1";
            this.ExitButton1.Size = new System.Drawing.Size(202, 29);
            this.ExitButton1.TabIndex = 3;
            this.ExitButton1.Text = "Вихід";
            this.ExitButton1.UseSelectable = true;
            this.ExitButton1.Click += new System.EventHandler(this.ExitButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 268);
            this.Controls.Add(this.ExitButton1);
            this.Controls.Add(this.RedactButton);
            this.Controls.Add(this.ButtonRegistration);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна сторінка";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton ButtonRegistration;
        private MetroFramework.Controls.MetroButton RedactButton;
        public ListBox listBox;
        private MetroFramework.Controls.MetroButton ExitButton1;

    }
}