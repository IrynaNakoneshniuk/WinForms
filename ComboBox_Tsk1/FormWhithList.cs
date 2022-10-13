using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace ComboBox_Tsk1
{
    public partial class FormWhithList : MetroForm
    {
        public FormWhithList()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormWhithList_Load(object sender, EventArgs e)
        {
            try
            {
                string? FileName = "EmplFile.txt";
                string[] Employee = File.ReadAllLines(FileName);
                this.listBox1.DataSource = Employee;
            }catch(Exception ex)
            {
                MessageBox.Show(Text, ex.Message);  
            }
            
        }
    }
}
