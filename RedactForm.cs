using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Xml;
using System.Xml.Serialization;

namespace List_Task2
{
    public partial class RedactForm: MaterialForm
    {

        public List<Questionary> questionaries;
        public RedactForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, 
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            questionaries = new List<Questionary>();
        }
        private void metroButton3_Click(object sender, EventArgs e)
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
                    if (questionaries != null)
                        for (int i = 0; i < questionaries.Count; i++)
                        {
                            listBox1.Items.Add(questionaries[i]);
                        }
                }

                this.Update();
                listBox1.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.questionaries.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Remove(listBox1.SelectedItem);
                this.Update();
                listBox1.Show();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
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
        private void RedactButton_Click(object sender, EventArgs e)
        {
            try
            { 
                RegistrationForm registrationForm = new RegistrationForm();
                if (listBox1.SelectedIndex >= 0)
                {
                    registrationForm.NameBox1.Text = questionaries[listBox1.SelectedIndex].Name;
                    registrationForm.SurnameBox2.Text = questionaries[listBox1.SelectedIndex].Surname;
                    registrationForm.EmailBox3.Text = questionaries[listBox1.SelectedIndex].Email;
                    registrationForm.NumberPhoneBox4.Text = questionaries[listBox1.SelectedIndex].Phone.ToString();
                    questionaries.RemoveAt(listBox1.SelectedIndex);
                }
                for (int i = 0; i < questionaries.Count; i++)
                {
                    registrationForm.questionaries.Add(questionaries.ElementAt(i));
                }
                registrationForm.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }  
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.Update();
        }
    }
}
