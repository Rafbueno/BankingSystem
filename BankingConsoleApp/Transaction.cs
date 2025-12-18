namespace Banking.ConsoleApp;

public class Transaction
{
    public DateTime Date { get; }
    public decimal Amount { get; }
    public string Description { get; }

    public Transaction(decimal amount, string description)
    {
        Date = DateTime.Now;
        Amount = amount;
        Description = description;
    }
}
