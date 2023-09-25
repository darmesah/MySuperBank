namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Alex", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(200, DateTime.Now, "For shoes");
            Console.WriteLine(account.Balance);



            account.MakeWithdrawal(50, DateTime.Now, "For Book");
            Console.WriteLine(account.Balance);


            Console.WriteLine(account.GetAccountHistory());




            ////test for a negative balance:
            //try
            //{
            //    account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{

            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            ////test that initial balances must be positive
            //try
            //{
            //    BankAccount invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{

            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

        }

    }
}