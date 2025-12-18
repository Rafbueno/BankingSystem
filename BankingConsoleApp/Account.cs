namespace Banking.ConsoleApp;

public abstract class Account
{
// Public properties
    public string AccountNumber { get; }
    public decimal Balance { get; protected set; }

    // List of all transactions for this account
    public List<Transaction> Transactions { get; }

    // Constructor
    public Account(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
        Transactions = new List<Transaction>();
    }

    // Add money to the account
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        Balance = Balance + amount;
        AddTransaction(amount, "Deposit");
    }

    // Each account type must decide how withdrawals work
    public abstract void Withdraw(decimal amount);

    // Record a transaction
    protected void AddTransaction(decimal amount, string description)
    {
        Transaction transaction = new Transaction(amount, description);
        Transactions.Add(transaction);
    }
}