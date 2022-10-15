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
using System.Text.Json;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace Invoice
{
    public partial class LoadInvoiceForm : Form
    {
        public List<Check> checks;
        public LoadInvoiceForm()
        {
            InitializeComponent();
            checks = new List<Check>();
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Group = new string[] { "Телевізор", "Радіоприймач", "Апаратура радіоуправління",
                "Радіопередатчик" };
                string? FileName = "MyInvoice.json";
                string? JsonStr = new StreamReader(FileName).ReadToEnd();
                checks = (List< Check >)JsonConvert.DeserializeObject(JsonStr,typeof(List<Check>));
                if(checks.Count > 0)
                {
                    foreach (string s in Group)
                    {
                        TreeNode treeNode = new TreeNode(s);
                        this.treeView1.Nodes.Add(treeNode);
                          foreach (Check check in this.checks)
                          {
                                if (check.Name == s&& check.dateTime==dateTimePicker1.Value.Date)
                                {
                                    this.treeView1.Nodes[this.treeView1.Nodes.IndexOf(treeNode)].Nodes.Add(check.ToString());
                                }
                          }
                    }
                }
                else
                {
                    MessageBox.Show("Invoice list is empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
