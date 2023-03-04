namespace FinancialTracker.Mappers;

public interface ITransactionsMapper
{
    public ITransactions MapTransactions(string transactionsFilePath);
}