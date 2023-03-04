namespace FinancialTracker.Mappers;

public interface IExpensesMapper
{
    public ITransactions MapExpenses(string expensesFilePath);
}