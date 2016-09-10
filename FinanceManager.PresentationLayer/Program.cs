using System;
using System.Windows.Forms;
using Autofac;
using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.BusinessLayer.TransactionModels;
using FinanceManager.BusinessLayer.UserModels;
using FinanceManager.PresentationLayer.MainViews;
using FinanceManager.PresentationLayer.StatisticViews;
using FinanceManager.PresentationLayer.TransactionItemViews;
using FinanceManager.PresentationLayer.TransactionViews;
using FinanceManager.PresentationLayer.UserViews;

namespace FinanceManager.PresentationLayer
{
    static class Program
    {
        public static IContainer Container;
        [STAThread]
        static void Main()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(typeof(ICategoryService).Assembly);
            builder.RegisterAssemblyModules(typeof(ITransactionService).Assembly);
            builder.RegisterAssemblyModules(typeof(IUserService).Assembly);
            builder.RegisterType<LoginViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<LoginForm>().AsSelf().SingleInstance();
            builder.RegisterType<TransactionItemListViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<TransactionItemListForm>().AsSelf().SingleInstance();
            builder.RegisterType<TransactionListViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<TransactionListForm>().AsSelf().SingleInstance();
            builder.RegisterType<StatisticsViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<StatisticsForm>().AsSelf().SingleInstance();
            builder.RegisterType<MainViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<MainForm>().AsSelf().SingleInstance();

            Container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<MainForm>());
        }
    }
}
