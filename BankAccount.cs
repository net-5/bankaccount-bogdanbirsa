using classes;
using System;
using System.Collections.Generic;
using System.Text;
/*
    Simulate a bank account supporting opening/closing, withdrawals, and deposits of money.
    It should be possible to close an account; operations against a closed account must fail.
    Remember you are working with money so you should use an appropriate data type for it.
    */

namespace MyBankAccountHomeWork
{
    public enum OpenOrClose
    {
        Open,
        Closed
    }
    public class BankAccount
    {
        public OpenOrClose Status { get; set; }
        public string Number { get; }
        public string NameOfOwner { get; set; }
        private static int accountID = 1119860730;
        private List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string name, decimal initialBalance)
        {
            Number = accountID.ToString();
            accountID++;

            NameOfOwner = name;
            MakeDeposit(initialBalance, DateTime.Now, "VALOARE INITIALA");
        }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance = balance + item.Amount;
                }

                return balance;
            }
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (Status == OpenOrClose.Closed)
            {
                Console.WriteLine($"Cont inchis, {nameof(MakeDeposit)} operatiune respinsa.");
                return;
            }
            if 
                (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Valoarea din depozit trebuie sa fie pozitiva");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (Status == OpenOrClose.Closed)
            {
                Console.WriteLine($"Cont inchis, {nameof(MakeWithdrawal)} operatiune respinsa.");
                return;
            }
            if 
                (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "AValoarea din retragere trebuie sa fie pozitiva");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Fonduri insuficiente pentru retragere");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
        public string GetAccountHistory()
        {
            if (Status == OpenOrClose.Closed)
            {
                Console.WriteLine($"Cont inchis, {nameof(GetAccountHistory)} operatiune respinsa.");
                
            }
            var report = new System.Text.StringBuilder();

            report.AppendLine("Date\tAmount\tNote");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}







