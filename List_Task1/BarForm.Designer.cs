namespace Lists
{
    partial class BarForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBarForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(312, 29);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // CloseBarForm
            // 
            this.CloseBarForm.Location = new System.Drawing.Point(157, 142);
            this.CloseBarForm.Name = "CloseBarForm";
            this.CloseBarForm.Size = new System.Drawing.Size(94, 29);
            this.CloseBarForm.TabIndex = 2;
            this.CloseBarForm.Text = "Закрити";
            this.CloseBarForm.UseVisualStyleBackColor = true;
            this.CloseBarForm.Click += new System.EventHandler(this.ClickCloseBarForm);
            // 
            // BarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 208);
            this.Controls.Add(this.CloseBarForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "BarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ProgressBar progressBar1;
        public Label label1;
        private Button CloseBarForm;
    }
}