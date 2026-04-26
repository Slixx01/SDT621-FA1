class ATMSystem
{
    public static void Main(string[] args)
    {

        Console.WriteLine("==== CTU SIMPLE ATM SYSTEM ====");
        Console.WriteLine("HI, WHAT IS YOUR NAME?");
        string Name = Console.ReadLine();

        Console.WriteLine($"Welcome {Name}!");

        double AccountBalance = 0;
        bool validBalance = false;
        while (!validBalance)
        {
            Console.Write("Enter account balance: ");
            try
            {
                AccountBalance = double.Parse(Console.ReadLine());
                validBalance = true;
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
        

        double WithdrawAmount = 0;
        bool validWithdraw = false;
        while (!validWithdraw)
        {
            Console.Write("Enter withdrawal amount: ");
            try
            {
                WithdrawAmount = double.Parse(Console.ReadLine());
                validWithdraw = true;
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
            }
        }

        if (AccountBalance < WithdrawAmount)
        {
           Console.WriteLine("Withdraw amount exceeds account balance");
           Console.WriteLine($"Available balance: {AccountBalance}");
        }
        else
        {
            Console.WriteLine("Withdrawal successful!");
            AccountBalance = AccountBalance - WithdrawAmount;
        }

        Console.WriteLine($"Updated Balance: {Math.Round(AccountBalance,2)}");
        Console.WriteLine($"Transaction Time: {DateTime.Now}");
    }
}