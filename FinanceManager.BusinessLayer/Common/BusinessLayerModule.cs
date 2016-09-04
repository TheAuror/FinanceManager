using Autofac;
using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.BusinessLayer.TransactionModels;
using FinanceManager.BusinessLayer.UserModels;
using FinanceManager.DataLayer;

namespace FinanceManager.BusinessLayer.Common
{
    class BusinessLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TransactionService>().
                    As<ITransactionService>().
                    InstancePerLifetimeScope();

            builder.RegisterType<CategoryService>().
                    As<ICategoryService>().
                    InstancePerLifetimeScope();

            builder.RegisterType<UserService>().
                    As<IUserService>().
                    InstancePerLifetimeScope();

            builder.RegisterAssemblyModules(typeof (ISampleContext).Assembly);
        }
    }
}
