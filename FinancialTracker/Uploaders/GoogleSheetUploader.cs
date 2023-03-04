using FinancialTracker.AuthConfigs;

namespace FinancialTracker;

public class GoogleSheetUploader : ITransactionUploader
{
    private readonly IAuthConfig _authConfig;

    public GoogleSheetUploader(IAuthConfig authConfig)
    {
        _authConfig = authConfig;
    }
    
    public void Upload(ITransactions transactions)
    {
        throw new NotImplementedException();
    }
}