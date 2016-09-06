using System.Windows.Forms;
using Autofac;
using FinanceManager.BusinessLayer.Common;
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
            _mainViewModel.LoadTransactionItems();
            _mainViewModel.Transaction.CreatedTime = dateTimePicker.Value;
        }

        private void toggleSwitch_CheckedChanged(object sender, System.EventArgs e)
        {
            if (toggleSwitch.Checked)
            {
                _mainViewModel.Transaction.Type = BaseModel.TypeEnum.Income;
            }
            else
            {
                _mainViewModel.Transaction.Type = BaseModel.TypeEnum.Expense;
            }
        }

        private void saveTransactionButton_Click(object sender, System.EventArgs e)
        {
            _mainViewModel.SaveTransaction();
            itemNameTextBox.Text = "";
            valueTextBox.Text = "";
            regularCheckBox.Checked = false;
            itemNameTextBox.Focus();
        }

        private void itemNameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            _mainViewModel.Transaction.Item.Name = itemNameTextBox.Text;
        }

        private void valueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, System.EventArgs e)
        {
            _mainViewModel.Transaction.CreatedTime = dateTimePicker.Value;
        }

        private void valueTextBox_TextChanged(object sender, System.EventArgs e)
        {
            _mainViewModel.Transaction.Value = int.Parse(valueTextBox.Text);
        }
    }
}
