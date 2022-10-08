using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Xml.Serialization;

namespace List_Task2
{
    public partial class RegistrationForm : MaterialForm
    {
        public List<Questionary>? questionaries;
        public RegistrationForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            questionaries = new List<Questionary>();
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Questionary questionary = new Questionary(NameBox1.Text.ToString(), SurnameBox2.Text.ToString(),
                SurnameBox2.Text.ToString(), Convert.ToInt64(NumberPhoneBox4.Text.ToString()));
                this.questionaries.Add(questionary);
                NameBox1.Clear();
                SurnameBox2.Clear();
                EmailBox3.Clear();
                NumberPhoneBox4.Clear();
                MessageBox.Show("Questionary is saved!", "Збережено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Update();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string? Path = "UsersData.xml";
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(questionaries.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, questionaries);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(Path);
                    stream.Close();
                }
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            try
            {
                string? Path = "UsersData.xml";
                if (File.Exists(Path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(questionaries.GetType());
                    using (Stream fs = new FileStream(Path, FileMode.Open))
                    {
                        questionaries = (List<Questionary>)xmlSerializer.Deserialize(fs);
                        fs.Close();
                    }
                }
                this.Update();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
