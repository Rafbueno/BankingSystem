namespace Banking.ConsoleApp;

public class Bank
{
    private List<Account> accounts;
    public Bank()
    {
        accounts = new List<Account>();
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public Account GetAccount(string accountNumber)
    {
        for (int i = 0; i < accounts.Count; i++)
        {
            if (accounts[i].AccountNumber == accountNumber)
            {
                return accounts[i];
            }
        }

        throw new InvalidOperationException("Account not found.");
    }

    public void Transfer(string fromAccountNumber, string toAccountNumber, decimal amount)
    {
        Account fromAccount = GetAccount(fromAccountNumber);
        Account toAccount = GetAccount(toAccountNumber);

        fromAccount.Withdraw(amount);
        toAccount.Deposit(amount);
    }
}
