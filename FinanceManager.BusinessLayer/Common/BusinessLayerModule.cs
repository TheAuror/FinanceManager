using Autofac;
using FinanceManager.DataLayer;

namespace FinanceManager.BusinessLayer.Common
{
    class BusinessLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyModules(typeof (ISampleContext).Assembly);
        }
    }
}
