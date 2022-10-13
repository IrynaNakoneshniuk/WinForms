
using MetroFramework;
using MetroFramework.Forms;
using System.Net.NetworkInformation;
using static System.Windows.Forms.Timer;

namespace ComboBox_Tsk1
{
    public partial class MainForm :MetroForm
    {
        public Employee employee;
        public MainForm()
        {
            InitializeComponent();
            employee = new Employee();
        }
        private void LoadListButton_Click(object sender, EventArgs e)
        {
            FormWhithList formWhithList = new FormWhithList();
            formWhithList.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string? FileName = "EmplFile.txt";
                employee.IniEmployee(SurnameTextBox.Text, SityComboBox.SelectedValue.ToString(),
                    Convert.ToDouble(SalaryTextBox.Text), PositionComboBox.SelectedValue.ToString(), StreetComboBox.SelectedValue.ToString(),
                    Convert.ToInt32(NumberHouseComboBox.Text));
                SurnameTextBox.Clear();
                SalaryTextBox.Clear();
                NumberHouseComboBox.Clear();

                this.Update();
                MessageBox.Show(" Інформація збережена!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (StreamWriter sw = new StreamWriter(FileName, true))
                {
                    sw.WriteLine(employee.ToString());
                    sw.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string[] Positions = new string[] { "ТОП-менеджер", "Начальник відділу", "Менеджер", "Консультатнт" };
                string[] Sities = new string[] { "Вінниця", "Київ", "Харків" };
                string[] Streets = new string[] { "Антонова", "Бекетова", "Андріївська" };
                this.PositionComboBox.DataSource = Positions;
                this.SityComboBox.DataSource = Sities;
                this.StreetComboBox.DataSource = Streets;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}