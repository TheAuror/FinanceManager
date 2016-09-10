using System.Windows.Forms;
using Autofac;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.PresentationLayer.TransactionItemViews;
using FinanceManager.PresentationLayer.UserViews;
using System;
using System.Linq;
using FinanceManager.PresentationLayer.StatisticViews;
using FinanceManager.PresentationLayer.TransactionViews;

namespace FinanceManager.PresentationLayer.MainViews
{
    public partial class MainForm : Form
    {
        private readonly MainViewModel _mainViewModel;
        public MainForm(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            InitializeComponent();
            itemNameTextBox.AutoCompleteCustomSource = _mainViewModel.ItemNames;
        }

        private void MainForm_Load(object sender, EventArgs e)
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
            itemNameTextBox.AutoCompleteCustomSource = _mainViewModel.ItemNames;
            _mainViewModel.Transaction.CreatedTime = dateTimePicker.Value;
        }

        private void toggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSwitch.Checked)
            {
                _mainViewModel.Transaction.Type = BaseModel.TypeEnum.Income;
                _mainViewModel.LoadIncomeItems();
                itemNameTextBox.AutoCompleteCustomSource = _mainViewModel.ItemNames;
            }
            else
            {
                _mainViewModel.Transaction.Type = BaseModel.TypeEnum.Expense;
                _mainViewModel.LoadExpenseItems();
                itemNameTextBox.AutoCompleteCustomSource = _mainViewModel.ItemNames;
            }
        }

        private void saveTransactionButton_Click(object sender, EventArgs e)
        {
            _mainViewModel.SaveTransaction();
            itemNameTextBox.Text = "";
            valueTextBox.Text = "0";
            regularCheckBox.Checked = false;
            itemNameTextBox.Focus();
            itemNameTextBox.AutoCompleteCustomSource = _mainViewModel.ItemNames;
            using (var lifetimeScope = Program.Container.BeginLifetimeScope())
            {
                var a = lifetimeScope.Resolve<TransactionListViewModel>();
                a.LoadTransactions();
            }
        }

        private void itemNameTextBox_TextChanged(object sender, EventArgs e)
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

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _mainViewModel.Transaction.CreatedTime = dateTimePicker.Value;
        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            if(valueTextBox.Text != "")
                _mainViewModel.Transaction.Value = int.Parse(valueTextBox.Text);
        }

        private void itemListOpenButton_Click(object sender, EventArgs e)
        {
            using (var lifetimeScope = Program.Container.BeginLifetimeScope())
            {
                var form = lifetimeScope.Resolve<TransactionItemListForm>();

                form.MdiParent = this;
                form.Dock = DockStyle.Left;                                              
                form.Show();
                form.WindowState = FormWindowState.Maximized;
            }
        }

        private void itemNameTextBox_KeyDown(object sender, KeyEventArgs f)
        {
            if (f.KeyData == Keys.Enter)
            {
                if (toggleSwitch.Checked)
                {
                    var transactionItemModel = _mainViewModel.IncomeItems.FirstOrDefault(e => e.Name == itemNameTextBox.Text);
                    if (transactionItemModel != null)
                        valueTextBox.Text = transactionItemModel.LastValue?.ToString() ?? "0";
                }
                if (!toggleSwitch.Checked)
                {
                    var transactionItemModel = _mainViewModel.ExpenseItems.FirstOrDefault(e => e.Name == itemNameTextBox.Text);
                    if (transactionItemModel != null)
                        valueTextBox.Text = transactionItemModel.LastValue?.ToString() ?? "0";
                }
            }
        }

        private void transactionListOpenButton_Click(object sender, EventArgs e)
        {
            using (var lifetimeScope = Program.Container.BeginLifetimeScope())
            {
                var form = lifetimeScope.Resolve<TransactionListForm>();

                form.MdiParent = this;
                form.Dock = DockStyle.Left;
                form.Show();
                form.WindowState = FormWindowState.Maximized;
            }
        }

        private void statisticsOpenButton_Click(object sender, EventArgs e)
        {
            using (var lifetimeScope = Program.Container.BeginLifetimeScope())
            {
                var form = lifetimeScope.Resolve<StatisticsForm>();

                form.MdiParent = this;
                form.Dock = DockStyle.Left;
                form.Show();
                form.WindowState = FormWindowState.Maximized;
            }
        }
    }
}