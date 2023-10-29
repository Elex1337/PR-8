using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_8
{
    using System;

    class Task2
    {
        static void Main()
        {
            DateTime currentTime = DateTime.Now;
            bool isDiscountTime = currentTime.Hour >= 8 && currentTime.Hour < 12;

            string[] products = { "Молоко", "Хлеб", "Яйца", "Масло" };
            double[] prices = { 1.5, 0.8, 1.2, 2.0 };

            Console.WriteLine("Доступные продукты:");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]} - {prices[i]:C}");
            }

            Console.WriteLine("\nВыберите продукты (через пробел):");
            string[] selectedProducts = Console.ReadLine().Split(' ');

            double totalCost = 0;

            foreach (string index in selectedProducts)
            {
                int productIndex = int.Parse(index) - 1;

                if (productIndex >= 0 && productIndex < products.Length)
                {
                    totalCost += prices[productIndex];
                }
            }

            if (isDiscountTime)
            {
                double discount = totalCost * 0.05;
                totalCost -= discount;
                Console.WriteLine($"\nПрименена скидка 5%: -{discount:C}");
            }

            Console.WriteLine($"\nИтоговая сумма: {totalCost:C}");
        }
    }
}

