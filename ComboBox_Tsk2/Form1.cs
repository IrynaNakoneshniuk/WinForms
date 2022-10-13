namespace ComboBox_Tsk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
            this.timer1.Tick += timer1_Tick;
            this.progressBar1.Minimum = 1;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Step = 1;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                this.progressBar1.PerformStep();
                Thread.Sleep(100);
                this.Update();
                if (i == 100)
                {
                    this.timer1.Stop();
                }
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}