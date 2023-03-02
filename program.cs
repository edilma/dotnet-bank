BankAccount newAccount = new SavingsAccount("Jim", 250);

Console.WriteLine(newAccount.customerName + "'s starting balance is $" + newAccount.getBalance());
newAccount.deposit(100);



// he added $100 more
Console.WriteLine(newAccount.customerName + "'s starting balance is $" + newAccount.getBalance());
