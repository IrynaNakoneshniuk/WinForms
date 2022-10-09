namespace Lab_TabControl2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.label1.Text = radioButton1.Text;
                this.Update();
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.label1.ForeColor = System.Drawing.Color.Green;
                this.Update();
            }
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                this.label1.ForeColor = System.Drawing.Color.Red;
                this.Update();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.label1.Text = radioButton2.Text;
                this.Update();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font= new Font("Serif", 20,FontStyle.Bold);
            this.Update();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font("Serif", 10, FontStyle.Bold);
            this.Update();
        }
    }
}