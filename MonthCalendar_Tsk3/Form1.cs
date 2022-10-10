namespace MonthCalendar_Tsk3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextChange(object sender, EventArgs e)
        {
            string? Date = textBoxDay.Text + "." + textBoxMonth.Text + "." + textBoxYear.Text;
            DateTime dateTime = Convert.ToDateTime(Date);
            monthCalendar1.SetDate(dateTime);
            this.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}