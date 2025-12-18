namespace Banking.ConsoleApp;

public class CheckingAccount : Account
{
    public decimal OverdraftLimit { get; }

    public CheckingAccount(string accountNumber, decimal overdraftLimit)
        : base(accountNumber)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.");
        }

        // Allow overdraft up to the limit
        decimal newBalance = Balance - amount;

        if (newBalance < -OverdraftLimit)
        {
            throw new InvalidOperationException("Overdraft limit exceeded.");
        }

        Balance = newBalance;
        AddTransaction(-amount, "Withdrawal");
    }
}
