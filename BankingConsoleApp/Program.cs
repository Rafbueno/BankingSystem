using Banking.ConsoleApp;

Console.WriteLine("=== Simple Banking System ===");

Bank bank = new Bank();

CheckingAccount checking = new CheckingAccount("CHK001", 200);
SavingsAccount savings = new SavingsAccount("SAV001", 0.05m);

bank.AddAccount(checking);
bank.AddAccount(savings);

checking.Deposit(500);
Console.WriteLine("Deposited 500 into Checking.");

bank.Transfer("CHK001", "SAV001", 200);
Console.WriteLine("Transferred 200 from Checking to Savings.");

savings.ApplyInterest();
Console.WriteLine("Interest applied to Savings.");

Console.WriteLine();
Console.WriteLine("Final Balances:");
Console.WriteLine("Checking: " + checking.Balance);
Console.WriteLine("Savings: " + savings.Balance);

