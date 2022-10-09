using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_TabControl
{
    public partial class Form1 : Form
    {
        Font SmallFont = new Font("Arial", 8, FontStyle.Bold);
        Font MediumFont = new Font("Arial", 15, FontStyle.Bold);
        Font LargeFont = new Font("Arial", 20, FontStyle.Bold);
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChekedFormatText.Items.Add("Small");
            ChekedFormatText.Items.Add("Medium");
            ChekedFormatText.Items.Add("Large");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.label1.Font = SmallFont;
        }

        private void ChekedFormatText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ChekedFormatText.SelectedIndex != -1)
            {
                if (ChekedFormatText.SelectedIndex == 0)
                {
                    this.label1.Font = SmallFont;
                }
                else if(ChekedFormatText.SelectedIndex == 1)
                {
                    this.label1.Font = MediumFont;
                }
                else if(ChekedFormatText.SelectedIndex == 2)
                {
                    this.label1.Font = LargeFont;
                }
                this.Update();
            }
        }
    }
}
