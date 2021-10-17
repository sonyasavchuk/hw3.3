using System;

namespace hw3
{
    class Converter
    {
        double usd;
        double eur;
        public Converter(double usd, double eur)
        {
            this.usd = usd;
            this.eur = eur;
        }
        public double ToUsd(double sum)
        {
            return (sum * usd);
        }
        public double ToEur(double sum)
        {
            return (sum * eur);
        }
        public double FromUsd(double sum)
        {
            return (sum / usd);
        }
        public double FromEur(double sum)
        {
            return (sum / eur);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter usd");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter eur");
            double eur = Convert.ToDouble(Console.ReadLine());
            Converter conv = new Converter(usd, eur);
            Console.WriteLine("Enter your sum");
            double sum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("To eur "+conv.ToEur(sum1));
            Console.WriteLine("To usd " + conv.ToUsd(sum1));
            Console.WriteLine("From eur " + conv.FromEur(sum1));
            Console.WriteLine("From usd " + conv.FromUsd(sum1));
        }
    }
}
