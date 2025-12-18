using Banking.ConsoleApp;


public class SavingsAccountTests
{
    [Fact]
    public void ApplyInterest_IncreasesBalance()
    {
        var account = new SavingsAccount("S1", 0.10m);
        account.Deposit(100);
        account.ApplyInterest();

        Assert.Equal(110, account.Balance);
    }
}
