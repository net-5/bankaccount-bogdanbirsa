using System;
/*
    Simulate a bank account supporting opening/closing, withdrawals, and deposits of money.
    It should be possible to close an account; operations against a closed account must fail.
    Remember you are working with money so you should use an appropriate data type for it.
    */
namespace classes
{

    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }


        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
            Date = DateTime.Now;
        }
    }
}