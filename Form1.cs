using MaterialSkin.Controls;
using MaterialSkin;

namespace WinFormsApp1
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void ChoiseDataButonClick(object sender, EventArgs e)
        {

            lableTime.Text = "Обрана дата:" + "  " +
                " " + Convert.ToString(dateTimePicker1.Value.ToLongDateString());
        }
    }
}