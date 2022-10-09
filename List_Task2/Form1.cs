
namespace List_Task2
{
    using MetroFramework;
    using MaterialSkin;
    using MaterialSkin.Controls;

    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void ClickRegistrationButton(object sender, EventArgs e)
        {
            RegistrationForm registrationForm= new RegistrationForm();
            registrationForm.Show(); 
        }
        private void RedactButton_Click(object sender, EventArgs e)
        {
            RedactForm redactForm= new RedactForm();
            redactForm.Show();
        }

        private void ExitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}