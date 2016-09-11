using System.IO;
using System.Windows.Forms;

namespace FinanceManager.PresentationLayer.TransactionViews
{
    public partial class TransactionListForm : Form
    {
        private readonly TransactionListViewModel _viewModel;
        private FileInfo currentFile;
        public TransactionListForm(TransactionListViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
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
            dataGridView.Columns[3].DefaultCellStyle.Format = "C";
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
                currentFile = new FileInfo(openFileDialog.FileName);
            }
            _viewModel.LoadTransactions();
        }

        private void mentésMáskéntToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.Filter = "Csv fájlok (.csv)|*.csv|Minden fájl|*.*";
                saveFileDialog.DefaultExt = ".csv";
                saveFileDialog.AddExtension = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _viewModel.SaveDataToFile(saveFileDialog.FileName);
                    currentFile = new FileInfo(saveFileDialog.FileName);
                }
            }
        }

        private void mentésToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (currentFile == null)
            {
                mentésMáskéntToolStripMenuItem_Click(sender, e);
                return;
            }
            _viewModel.SaveDataToFile(currentFile.FullName);
        }
    }
}
