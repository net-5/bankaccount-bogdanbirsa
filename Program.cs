using System;

/*
    Simulate a bank account supporting opening/closing, withdrawals, and deposits of money.
    It should be possible to close an account; operations against a closed account must fail.
    Remember you are working with money so you should use an appropriate data type for it.
    */
namespace MyBankAccountHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Bogdan Birsa", 100);
            Console.WriteLine($"Contul {account.Number} a fost creat pentru {account.NameOfOwner} cu {account.Balance} valoare initiala.");

            account.MakeDeposit(4000, DateTime.Now, "Salariu");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(500, DateTime.Now, "Rata masina");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(1200, DateTime.Now, "Rata Scoala Informala");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(100, DateTime.Now, "Bilet Teatru Iasi");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(50, DateTime.Now, "Cumparaturi Lidl");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(2500, DateTime.Now, "Salariu al doilea job");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(1000000000, DateTime.Now, "Catigator loteria Romana");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
