using System;
using TaxExercise.Entities;
using System.Globalization;
using System.Collections.Generic;
using TaxExercise.Entities.Enum;
namespace TaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers:");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> ListPayer = new List<TaxPayer>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nTax payer #{i + 1} data:");
                Console.Write("Invididual or Company?:");
                Style style = Enum.Parse<Style>(Console.ReadLine(), true);
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Anual income: R$");
                double income = double.Parse(Console.ReadLine());
                if (style == Style.individual || style == Style.Individual)
                {
                    Console.Write("Health expenditures: R$");
                    double expend = double.Parse(Console.ReadLine());
                    ListPayer.Add(new Individual(name, income, expend));
                }
                else if (style == Style.Company || style == Style.company)
                {
                    Console.Write("Number of Employees:");
                    int numEmp = int.Parse(Console.ReadLine());
                    ListPayer.Add(new Company(name, income, numEmp));
                }
            }
            Console.WriteLine("\n***TAXES PAID***");
            double total = 0.0;
            foreach (TaxPayer tp in ListPayer)
            {
                Console.WriteLine($"{tp.Name}: {tp.Taxes():c}");
                total += tp.Taxes();
            }
            Console.WriteLine($"\nTOTAL TAXES: {total:c}");
        }
    }
}