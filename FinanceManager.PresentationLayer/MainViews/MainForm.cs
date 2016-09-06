using System.Windows.Forms;
using Autofac;
using FinanceManager.PresentationLayer.UserViews;

namespace FinanceManager.PresentationLayer.MainViews
{
    public partial class MainForm : Form
    {
        private readonly MainViewModel _mainViewModel;
        public MainForm(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            InitializeComponent();
            _mainViewModel.ItemNames.Add("asdasdasd");
            itemNameTextBox.AutoCompleteCustomSource = _mainViewModel.ItemNames;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            using (var lifetimeScope = Program.Container.BeginLifetimeScope())
            {
                var form = lifetimeScope.Resolve<LoginForm>();
                form.ShowDialog();
                if (form.DialogResult != DialogResult.OK)
                {
                    Close();
                }
                WindowState = FormWindowState.Maximized;
            }
        }

        private void toggleSwitch_CheckedChanged(object sender, System.EventArgs e)
        {

        }
    }
}
