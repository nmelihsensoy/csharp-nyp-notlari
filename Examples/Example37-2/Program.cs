using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example37_2
{
    public interface ITransactions
    {
        void showTransaction();
        double getAmount();
    }
    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "2/9/2019", 48900.00);
            Transaction t2 = new Transaction("002", "12/09/2020", 991900.00);

            t1.showTransaction();
            Console.WriteLine();
            t2.showTransaction();
            Console.ReadLine();
        }
    }
}
