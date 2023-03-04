namespace FinancialTracker.TransactionProcessors;

public interface ITransactionsProcessor
{
    void Process(string transactionFilePath);
}