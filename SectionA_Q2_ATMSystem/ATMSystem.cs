class ATMSystem
{
    public static void Main(string[] args)
    {

        Console.WriteLine("==== CTU SIMPLE ATM SYSTEM ====");
        Console.WriteLine("HI, WHAT IS YOUR NAME?");
        string Name = Console.ReadLine();

        Console.WriteLine($"Welcome {Name}!");

        Console.Write("Enter account balance: ");
        double AccountBalance = double.Parse(Console.ReadLine());

        Console.Write($"Enter Withdraw amount: ");
        double WithdrawAmount = double.Parse(Console.ReadLine());
    

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