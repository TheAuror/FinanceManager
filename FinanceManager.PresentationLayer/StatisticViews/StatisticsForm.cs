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
            _viewModel.UpdateTopList(!toggleSwitch.Checked);
            topBindingSource.DataSource = _viewModel.TopList;
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void refreshButton_Click(object sender, System.EventArgs e)
        {
            _viewModel.UpdateTopList(!toggleSwitch.Checked);
        }

        private void toggleSwitch_CheckedChanged(object sender, System.EventArgs e)
        {
            _viewModel.UpdateTopList(!toggleSwitch.Checked);
        }
    }
}
