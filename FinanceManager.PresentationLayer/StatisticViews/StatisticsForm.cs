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
            statisticsViewModelBindingSource.DataMember = "TopList";
            _viewModel.UpdateTopList(true);
        }
    }
}
