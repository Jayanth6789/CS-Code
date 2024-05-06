using Bank;

namespace User
{
    public class User1
    {
        static void Main(string[] args)
        {
            BankAccount person1 = new BankAccount("1234", "Bot", "111", 0, 12);
            person1.AccountDetails();
            person1.Deposit(100.5);
            person1.Deposit(-10);
            person1.GetBalance();
            person1.Withdraw(-10,"123");
            person1.Withdraw(10, "12");
            person1.Withdraw(100, "123");
            person1.SetIntrestRate(10.8);
            person1.SetIntrestRate(20);
            person1.AccountDetails();
            person1.SetPassword("234");
            person1.CreditIntrest();
        }
    }
}
