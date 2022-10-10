using System.Text.Json;
using System.Xml;


namespace MonthCalendar_Tsk1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "MyFile.json";
                var person = new Person
                {
                    Name = textSecondName.Text.ToString(),
                    Surname = textBoxSurname.Text.ToString(),
                    SecondName = textSecondName.Text.ToString(),
                    Point = textBoxPoint.Text.ToString(),
                    Date = Convert.ToDateTime(textBoxDate.Text),
                    Status = textBoxStatus.Text.ToString(),
                    Other = textBoxOther.Text.ToString(),
                };
                var option = new JsonSerializerOptions { WriteIndented = true };
                string? JsonPerson = JsonSerializer.Serialize(person, option);
                if (!File.Exists(fileName))
                {

                    File.WriteAllText(fileName, JsonPerson);

                }
                else
                {
                    StreamWriter file = new StreamWriter(fileName, append: true);
                    file.WriteLine(JsonPerson);
                    file.Close();
                }
                MessageBox.Show("Information is saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}