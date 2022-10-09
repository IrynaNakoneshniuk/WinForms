namespace List_Task2
{
    partial class RedactForm
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
            this.RedactButton = new MetroFramework.Controls.MetroButton();
            this.RemoveButton = new MetroFramework.Controls.MetroButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ButtonLoad = new MetroFramework.Controls.MetroButton();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.UpdateButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // RedactButton
            // 
            this.RedactButton.Location = new System.Drawing.Point(54, 232);
            this.RedactButton.Name = "RedactButton";
            this.RedactButton.Size = new System.Drawing.Size(235, 29);
            this.RedactButton.TabIndex = 0;
            this.RedactButton.Text = "Редагувати";
            this.RedactButton.UseSelectable = true;
            this.RedactButton.Click += new System.EventHandler(this.RedactButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(308, 232);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(226, 29);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Видалити";
            this.RemoveButton.UseSelectable = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(54, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(480, 144);
            this.listBox1.TabIndex = 2;
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(54, 276);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(480, 29);
            this.ButtonLoad.TabIndex = 3;
            this.ButtonLoad.Text = "Завантажити";
            this.ButtonLoad.UseSelectable = true;
            this.ButtonLoad.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(54, 323);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(480, 29);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Закрити";
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(54, 379);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(480, 29);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Оновити";
            this.UpdateButton.UseCompatibleTextRendering = true;
            this.UpdateButton.UseSelectable = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RedactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 420);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.RedactButton);
            this.Name = "RedactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedactForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton RedactButton;
        private MetroFramework.Controls.MetroButton RemoveButton;
        private ListBox listBox1;
        private MetroFramework.Controls.MetroButton ButtonLoad;
        private MetroFramework.Controls.MetroButton CloseButton;
        private MetroFramework.Controls.MetroButton UpdateButton;
    }
}