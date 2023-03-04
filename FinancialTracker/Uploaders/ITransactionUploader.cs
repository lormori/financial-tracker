namespace FinancialTracker;

public interface ITransactionUploader
{
    public void Upload(ITransactions transactions);
}