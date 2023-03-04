using Autofac;
using FinancialTracker.AuthConfigs;
using FinancialTracker.Mappers;

namespace FinancialTracker.Autofac;

public class AutofacModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<GoogleSheetUploader>().AsImplementedInterfaces();
        builder.RegisterType<GoogleSheetAuthConfig>().AsImplementedInterfaces();
        builder.RegisterType<SantanderTransactionsMapper>().AsImplementedInterfaces();
        builder.RegisterType<AmexTransactionsMapper>().AsImplementedInterfaces();
    }
}