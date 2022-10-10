namespace MonthCalendar_Tsk2
{
    public partial class Form1 : Form
    {
        public  DateTime[] dateTime;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTime= new DateTime[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dateTime[0] > DateTime.Now)
            {
                MessageBox.Show("Обрана дата перевищує допустиме значення", "Помилка",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTime[0] = DateTime.Now;
            }
            else
            {
                dateTime[0] = dateTimePicker1.Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTime[1] = dateTimePicker1.Value;
            if (dateTime[1] > DateTime.Now)
            {
                MessageBox.Show("Обрана дата перевищує допустиме значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTime[1]= DateTime.Now;
            }
            else
            {
                dateTime[1] = dateTimePicker1.Value;
                int days = (dateTime[0] - dateTime[1]).Days;
                label1.Text = String.Format("Кількість днів: {0}", days.ToString());
                this.Update();
            }
           
        }
    }
    
}