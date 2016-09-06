using System;
using System.Windows.Forms;
using Autofac;
using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.BusinessLayer.TransactionModels;
using FinanceManager.BusinessLayer.UserModels;
using FinanceManager.PresentationLayer.MainViews;
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
            builder.RegisterType<LoginViewModel>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<LoginForm>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<MainViewModel>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<MainForm>().AsSelf().InstancePerLifetimeScope();

            Container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<MainForm>());
        }
    }
}
