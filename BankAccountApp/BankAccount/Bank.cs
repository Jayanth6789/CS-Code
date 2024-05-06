namespace Bank
{
    public class BankAccount
    {
        private string accountNumber;
        private string name;
        private string password;
        private double balance;
        private double interestRate;

        public BankAccount(string accountNumber, string name, string password, double balance, double interestRate)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.password = password;
            this.balance = balance;
            this.interestRate = interestRate;
        }


        public void Deposit(double amt)
        {
            if (amt > 0)
            {
                balance += amt;
                Console.WriteLine($"The {amt}rs has been credited to the account");
            }
            else 
            {
                Console.WriteLine("Invalid Amount");
            }
        }

        public void Withdraw(double amt,string passcode)
        {
            if (amt > balance && amt > 0 && password == passcode)
            {
                balance -= amt;
                Console.WriteLine($"{amt}rs has been debited from your account");
            }
            else if (this.password != passcode)
                Console.WriteLine("Invalid Password");
            else
                Console.WriteLine("Invalid Amount");
        }

        public void CreditIntrest()
        {
            double amt = (balance * interestRate) / 1200;
            balance += amt;
            Console.WriteLine($"The intrest amount of {amt}rs has been credited to your account");
        }


        public void AccountDetails()
        {
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Balance : {balance}rs");
            Console.WriteLine($"Rate of Intrest : {interestRate}%");
        }


        public void GetName()
        {
            Console.WriteLine($"Name : {name}");
        }

        public void GetBalance()
        {
            Console.WriteLine($"Account Balance : {balance}");
        }

        public void SetPassword(String passcode)
        { 
            password = passcode;
            Console.WriteLine("Password updated sucessfully");
        }

        public void GetIntrestRate()
        {
            Console.WriteLine($"The current Rate of Intrest Rate is {interestRate}%");
        }

        public void SetIntrestRate(double roi)
        {
            double change = interestRate / 10;
            if(change<=Math.Abs(interestRate-roi))
            {
                interestRate = roi;
                Console.WriteLine($"The Updated Rate of intrest is {interestRate}%");
            }
        }


    }
}
