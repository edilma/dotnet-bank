public class BankAccount
{
    public string customerName = "";
    public double balance = 0;
   

    public BankAccount(string newCustomerName,
         double newBalance)
    {
        customerName = newCustomerName;
        balance = newBalance;

    }

    public void deposit(double amount){
        if(amount<=0){
            throw new System.Exception("No negative deposits allowed");
        }
        balance += amount;
    }

    public double getBalance(){
        return balance;
    }
}