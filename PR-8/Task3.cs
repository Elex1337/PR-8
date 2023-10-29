using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_8
{
    using System;

    class Program
    {
        static void Main1()
        {
            double[] months = { 1, 2, 3, 4, 5 };
            double[] sales = { 10, 15, 12, 18, 16 };

            double x̄ = CalculateMean(months);
            double ȳ = CalculateMean(sales);

            double covXY = CalculateCovariance(months, sales, x̄, ȳ);
            double varX = CalculateVariance(months, x̄);

            double a = covXY / varX;
            double b = ȳ - a * x̄;

            double[] futureMonths = { 6, 7, 8 };
            double[] predictedSales = PredictSales(futureMonths, a, b);

            Console.WriteLine("Прогноз объемов продаж на следующие три месяца:");
            for (int i = 0; i < futureMonths.Length; i++)
            {
                Console.WriteLine($"Месяц {futureMonths[i]}: {predictedSales[i]}");
            }
        }

        static double CalculateMean(double[] data)
        {
            double sum = 0;
            foreach (double value in data)
            {
                sum += value;
            }
            return sum / data.Length;
        }

        static double CalculateCovariance(double[] x, double[] y, double x̄, double ȳ)
        {
            double cov = 0;
            for (int i = 0; i < x.Length; i++)
            {
                cov += (x[i] - x̄) * (y[i] - ȳ);
            }
            return cov / x.Length;
        }

        static double CalculateVariance(double[] data, double x̄)
        {
            double var = 0;
            foreach (double value in data)
            {
                var += Math.Pow(value - x̄, 2);
            }
            return var / data.Length;
        }

        static double[] PredictSales(double[] months, double a, double b)
        {
            double[] predictions = new double[months.Length];
            for (int i = 0; i < months.Length; i++)
            {
                predictions[i] = a * months[i] + b;
            }
            return predictions;
        }
    }
}