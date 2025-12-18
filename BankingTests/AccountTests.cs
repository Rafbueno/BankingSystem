using Banking.ConsoleApp;

public class AccountTests
{
    [Fact]
    public void Deposit_IncreasesBalance()
    {
        var account = new CheckingAccount("A1", 100);
        account.Deposit(200);

        Assert.Equal(200, account.Balance);
    }

    [Fact]
    public void Deposit_InvalidAmount_Throws()
    {
        var account = new CheckingAccount("A1", 100);

        Assert.Throws<ArgumentException>(() => account.Deposit(-10));
    }
}
