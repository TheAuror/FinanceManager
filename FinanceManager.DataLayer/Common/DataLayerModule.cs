using Autofac;

namespace FinanceManager.DataLayer.Common
{
    class DataLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SampleContext>()
                   .As<ISampleContext>()
                   .WithParameter("connectionString", "FinanceManager")
                   .InstancePerLifetimeScope();
        }
    }
}
