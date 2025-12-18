namespace Banking.ConsoleApp;

public class SavingsAccount : Account
{
    public decimal InterestRate { get; }

    public SavingsAccount(string accountNumber, decimal interestRate)
        : base(accountNumber)
    {
        InterestRate = interestRate;
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.");
        }

        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        Balance = Balance - amount;
        AddTransaction(-amount, "Withdrawal");
    }

    public void ApplyInterest()
    {
        decimal interest = Balance * InterestRate;
        Balance = Balance + interest;

        AddTransaction(interest, "Interest Applied");
    }
}
