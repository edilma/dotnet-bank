public class CheckingAccount : BankAccount{

    public CheckingAccount (string newCustomerName, double newBalance): 
    base(newCustomerName, newBalance){
        balance +=100;
    }
}