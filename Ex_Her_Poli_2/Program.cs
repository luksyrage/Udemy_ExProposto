using System;
using System.Globalization;
using Ex_Her_Poli_2.Entities;

namespace Ex_Her_Poli_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxPayer payer;

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("Tax payer #1 data:");
                Console.WriteLine("Individual or company(i / c) ? ");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Anual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.WriteLine("Health expenditure: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    payer = (new TaxPayerIndividual(health, name, income));

                } else if (type == 'c')
                {
                    Console.WriteLine("Number of employees: ");
                    int employee = int.Parse(Console.ReadLine());

                    payer = (new TaxPayerCompany(employee, name, income));

                }

            }

            Console.WriteLine("TAXES PAID: ");


        }

    }
}
