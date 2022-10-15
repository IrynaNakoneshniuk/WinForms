namespace Invoice
{
    partial class LoadInvoiceForm
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ViewAllButton = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(260, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(478, 284);
            this.treeView1.TabIndex = 0;
            // 
            // ViewAllButton
            // 
            this.ViewAllButton.Location = new System.Drawing.Point(21, 12);
            this.ViewAllButton.Name = "ViewAllButton";
            this.ViewAllButton.Size = new System.Drawing.Size(209, 29);
            this.ViewAllButton.TabIndex = 1;
            this.ViewAllButton.Text = "Відсортувати за датою";
            this.ViewAllButton.UseVisualStyleBackColor = true;
            this.ViewAllButton.Click += new System.EventHandler(this.ViewAllButton_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(21, 267);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(209, 29);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // LoadInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 348);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.ViewAllButton);
            this.Controls.Add(this.treeView1);
            this.Name = "LoadInvoiceForm";
            this.Text = "LoadInvoiceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView treeView1;
        private Button ViewAllButton;
        private Button buttonClose;
        private DateTimePicker dateTimePicker1;
    }
}