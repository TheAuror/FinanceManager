using System.Windows.Forms;

namespace FinanceManager.PresentationLayer.TransactionViews
{
    public partial class TransactionListForm : Form
    {
        private readonly TransactionListViewModel _viewModel;
        public TransactionListForm(TransactionListViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TransactionListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void FilterCheckChanged(object sender, System.EventArgs e)
        {
            _viewModel.GetIncomes = incomeCheckBox.Checked;
            _viewModel.GetExpenses = expenseCheckBox.Checked;
            _viewModel.LoadTransactions();
        }

        private void TransactionListForm_Load(object sender, System.EventArgs e)
        {
            _viewModel.LoadTransactions();
            dataGridView.DataSource = _viewModel.Transactions;
        }

        private async void beolvasásToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.CheckFileExists = true;
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "Csv fájlok (.csv)|*.csv|Minden fájl|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await _viewModel.SaveTransactionsAsync(openFileDialog.FileName);
                }
            }
            _viewModel.LoadTransactions();
        }
    }
}
