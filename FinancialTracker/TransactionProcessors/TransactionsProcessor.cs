using FinancialTracker.Mappers;

namespace FinancialTracker.TransactionProcessors;

public class TransactionsProcessor : ITransactionsProcessor
{
    private readonly ITransactionsMapper[] _transactionsMappers;
    private readonly ITransactionUploader _uploader;

    public TransactionsProcessor(ITransactionsMapper[] transactionsMappers, ITransactionUploader uploader)
    {
        _transactionsMappers = transactionsMappers;
        _uploader = uploader;
    }

    public void Process(string transactionFilePath)
    {
        // TODO: Get hold of correct processor
        var mappedTransactions = _transactionsMappers[0].MapTransactions(transactionFilePath);
        _uploader.Upload(mappedTransactions);
    }
}