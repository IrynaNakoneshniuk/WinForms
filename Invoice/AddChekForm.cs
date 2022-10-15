using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using System.Xml;
using System.Text.Json;
using Newtonsoft.Json;

namespace Invoice
{
    public partial class AddChekForm : Form
    {
        public List<Check> checks;
        public AddChekForm()
        {
            InitializeComponent();
            checks = new List<Check>();
            string? FileName = "MyInvoice.json";
            if (File.Exists(FileName))
            {
                string? JsonStr = File.ReadAllText(FileName);
                checks = (List<Check>)JsonConvert.DeserializeObject(JsonStr, typeof(List<Check>));
            }
        }

        private void AddChekForm_Load(object sender, EventArgs e)
        {
            string[] Group = new string[] { "Телевізор", "Радіоприймач", "Апаратура радіоуправління", "Радіопередатчик" };
            string[] Status = new string[] { "Готово", "В роботі" };
            comboBoxGroup.DataSource= Group;
            comboBoxStatus.DataSource= Status;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string FileName = "MyInvoice.json";
            Check check = new Check(this.comboBoxGroup.SelectedValue.ToString(),textBox2.Text,
               Convert.ToDateTime(textBox3.Text).Date, comboBoxStatus.SelectedValue.ToString());
            this.checks.Add(check);
            var option = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonConvert.SerializeObject(checks);
            File.WriteAllText(FileName, json);
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.Update();
            MessageBox.Show("Інформація збережена", "Збережено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
