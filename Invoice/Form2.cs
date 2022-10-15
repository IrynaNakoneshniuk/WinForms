using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddChekForm addChekForm = new AddChekForm();
            addChekForm.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadChek_Click(object sender, EventArgs e)
        {
            LoadInvoiceForm loadInvoiceForm = new LoadInvoiceForm();
            loadInvoiceForm.ShowDialog();
        }
    }
}
