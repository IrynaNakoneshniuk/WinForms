using System.IO;

namespace Lists
{
    public partial class MainForm : Form
    {
        public BarForm barForm;

        public MainForm()
        {
            InitializeComponent();
            barForm = new BarForm();
            
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClickAmountSymbol(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\ZbooK\source\repos\Lists\"+textBox1.Text))
            {
               
                string? FileText = System.IO.File.ReadAllText(@"C:\Users\ZbooK\source\repos\Lists\"+textBox1.Text);
                barForm.progressBar1.Minimum = 0;
                barForm.progressBar1.Maximum = 500;
                barForm.progressBar1.Value = FileText.Length;
                barForm.label1.Text= "Ê³כüך³סעü סטלגמכ³ג ף פאיכ³: "+" "+FileText.Length.ToString();
                barForm.Show();
            }
            else
            {
                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}