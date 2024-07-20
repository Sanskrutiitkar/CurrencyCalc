using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculato
{
    internal class Program
    {
        static void Main(string[] args)

        {
            bool isValid = false;
            do
            {
                Console.Write("Enter the amount (should not exceed 50000 and be a multiple of 100): ");
                int amount = int.Parse(Console.ReadLine());

                // Validation
                if (amount <= 50000 && amount % 100 == 0)
                {
                    CalculateDenominations(amount);
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid amount according to conditions");
                }
            }
           while(!isValid);
        }

        static void CalculateDenominations(int amount)
        {
         
            int[] denominations = { 2000, 500, 200, 100 };
            int[] count = new int[denominations.Length];

            for (int i = 0; i < denominations.Length; i++)
            {
                if (amount >= denominations[i])
                {
                    count[i] = amount / denominations[i];
                    amount %= denominations[i];
                }
            }

            for (int i = 0; i < denominations.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{denominations[i]}: {count[i]}");
                }
            }
        }
    }
}
