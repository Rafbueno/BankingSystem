using Banking.ConsoleApp;

public class BankTests
{
    [Fact]
    public void Transfer_MovesMoneyBetweenAccounts()
    {
        var bank = new Bank();
        var a1 = new CheckingAccount("A1", 100);
        var a2 = new SavingsAccount("A2", 0.01m);

        bank.AddAccount(a1);
        bank.AddAccount(a2);

        a1.Deposit(300);
        bank.Transfer("A1", "A2", 100);

        Assert.Equal(200, a1.Balance);
        Assert.Equal(100, a2.Balance);
    }

    [Fact]
    public void GetAccount_ReturnsCorrectAccount()
    {
        var bank = new Bank();
        var account = new CheckingAccount("X1", 50);
        bank.AddAccount(account);

        var result = bank.GetAccount("X1");

        Assert.Equal(account, result);
    }

    [Fact]
    public void Transfer_ThrowsIfInsufficientFunds()
    {
        var bank = new Bank();
        var a1 = new SavingsAccount("A1", 0.01m);
        var a2 = new SavingsAccount("A2", 0.01m);

        bank.AddAccount(a1);
        bank.AddAccount(a2);

        Assert.Throws<InvalidOperationException>(() =>
            bank.Transfer("A1", "A2", 50));
    }
}


