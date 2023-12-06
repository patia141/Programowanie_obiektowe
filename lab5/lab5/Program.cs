using System;
using lab5.shapes;
using lab5.bank;

namespace lab5
{
    class Program
    {

        static void Main(string[] args)
        {
            Zad1();
            Zad2();
        }
        static void Zad2()
        {
            var konto = new Account();

            konto.Transactions.Add(new IncomeTransaction() { Amount = 100 });
            konto.Transactions.Add(new IncomeTransaction() { Amount = 400 });
            konto.Transactions.Add(new ExpenseTransaction() { Amount = 300 });
            konto.Transactions.Add(new ExpenseTransaction() { Amount = 200 });
            konto.Transactions.Add(new IncomeTransaction() { Amount = 500 });

            konto.DisplaySumary();
        }

        static void Zad1()
        {
            Shape shape = new Circle(5);
            Shape kwadrat = new Square(4);
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(kwadrat.CalculateArea());
        }
    }
}
