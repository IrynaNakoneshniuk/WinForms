namespace WinFormsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.ChoiseDateButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lableTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ChoiseDateButton
            // 
            this.ChoiseDateButton.AutoSize = true;
            this.ChoiseDateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChoiseDateButton.Depth = 0;
            this.ChoiseDateButton.Location = new System.Drawing.Point(160, 107);
            this.ChoiseDateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChoiseDateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChoiseDateButton.Name = "ChoiseDateButton";
            this.ChoiseDateButton.Primary = false;
            this.ChoiseDateButton.Size = new System.Drawing.Size(131, 36);
            this.ChoiseDateButton.TabIndex = 1;
            this.ChoiseDateButton.Text = "Обрати дату";
            this.ChoiseDateButton.UseVisualStyleBackColor = true;
            this.ChoiseDateButton.Click += new System.EventHandler(this.ChoiseDataButonClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lableTime
            // 
            this.lableTime.AutoSize = true;
            this.lableTime.Location = new System.Drawing.Point(130, 185);
            this.lableTime.Name = "lableTime";
            this.lableTime.Size = new System.Drawing.Size(0, 20);
            this.lableTime.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(477, 353);
            this.Controls.Add(this.lableTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ChoiseDateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialFlatButton ChoiseDateButton;
        private DateTimePicker dateTimePicker1;
        private Label lableTime;
    }
}