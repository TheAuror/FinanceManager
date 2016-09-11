using System;
using System.Globalization;
using System.Windows.Forms;

namespace FinanceManager.PresentationLayer.StatisticViews
{
    public partial class StatisticsForm : Form
    {
        private readonly StatisticsViewModel _viewModel;
        public StatisticsForm(StatisticsViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, System.EventArgs e)
        {
            _viewModel.UpdateTopList();
            topBindingSource.DataSource = _viewModel.TopList;
            bottomLeftBindingSource.DataSource = _viewModel.BottomLeftList;
            bottomRightBindingSource.DataSource = _viewModel.BottomRightList;
            var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
            format.CurrencySymbol = " Ft";
            topDataGridView.Columns[1].DefaultCellStyle.Format = "C";
            topDataGridView.Columns[2].DefaultCellStyle.Format = "C";
            topDataGridView.Columns[3].DefaultCellStyle.Format = "C";
            bottomLeftDataGridView.Columns[1].DefaultCellStyle.Format = "C";
            bottomLeftDataGridView.Columns[2].DefaultCellStyle.Format = "p";
            bottomRightDataGridView.Columns[1].DefaultCellStyle.Format = "C";
            bottomRightDataGridView.Columns[2].DefaultCellStyle.Format = "p";
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void refreshButton_Click(object sender, System.EventArgs e)
        {
            _viewModel.UpdateTopList();
        }

        private void toggleSwitch_CheckedChanged(object sender, System.EventArgs e)
        {
            _viewModel.IsMontly = !toggleSwitch.Checked;
            _viewModel.UpdateTopList();
        }

        private void topDataGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            if(topDataGridView.SelectedRows.Count == 0)
                return;
            var rowName = topDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            if (_viewModel.SelectedRow != rowName)
            {
                _viewModel.SelectedRow = rowName;
                _viewModel.UpdateBottomLists();
            }
        }
    }
}
