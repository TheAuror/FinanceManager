using System;
using System.Windows.Forms;
using Autofac;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.PresentationLayer.MainViews;

namespace FinanceManager.PresentationLayer.TransactionItemViews
{
    public partial class TransactionItemListForm : Form
    {
        private readonly TransactionItemListViewModel _itemListViewModel;
        public TransactionItemListForm(TransactionItemListViewModel itemListViewModel)
        {
            _itemListViewModel = itemListViewModel;
            InitializeComponent();
            itemLastValueTextBox.Text = "0";
        }

        private void TransactionItemListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void itemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _itemListViewModel.TransactionItem.Name = itemNameTextBox.Text;
        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            _itemListViewModel.TransactionItem.Category.Name = categoryTextBox.Text;
        }

        private void itemLastValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (itemLastValueTextBox.Text != "")
                _itemListViewModel.TransactionItem.LastValue = int.Parse(itemLastValueTextBox.Text);
        }

        private void itemLastValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void typeToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            _itemListViewModel.TransactionItem.Type = typeToggleSwitch.Checked
                ? BaseModel.TypeEnum.Income
                : BaseModel.TypeEnum.Expense;
        }

        private void FilterCheckChanged(object sender, EventArgs e)
        {
            _itemListViewModel.GetIncomes = incomeFilterCheckBox.Checked;
            _itemListViewModel.GetExpenses = expenseFilterCheckBox.Checked;
            _itemListViewModel.LoadTransactionItems();
        }

        private void itemSaveButtom_Click(object sender, EventArgs e)
        {
            _itemListViewModel.SaveTransaction();
            itemNameTextBox.Text = "";
            categoryTextBox.Text = "";
            itemLastValueTextBox.Text = "0";
            itemNameTextBox.Focus();
            _itemListViewModel.LoadTransactionItems();
            // I realy don't know if this solution is reckless or beautiful, but it's working ^^
            using (var lifetimeScope = Program.Container.BeginLifetimeScope())
            {
                var a = lifetimeScope.Resolve<MainViewModel>();
                a.LoadTransactionItems();
            }
        }

        private void TransactionItemListForm_Load(object sender, EventArgs e)
        {
            _itemListViewModel.LoadTransactionItems();
            dataGridView.DataSource = _itemListViewModel.TransactionItems;
        }

        private async void beolvasásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.CheckFileExists = true;
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "Csv fájlok (.csv)|*.csv|Minden fájl|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await _itemListViewModel.SaveTransactionItemsAsync(openFileDialog.FileName);                       
                }
            }
        }
    }
}
