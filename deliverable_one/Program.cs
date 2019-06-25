//grand circus
//deliverable_one
//currency format converter
//cody shanley 2019

using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace deliverable_one
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[3];
            double total, avg, hiNum, lowNum;

            //get input from user
            Console.WriteLine("Please enter three different dollar amounts:");

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Amount #" + i + ": ");
                num[i] = Convert.ToDouble(Console.ReadLine());
            }

            //calculate and display total, average & low/high numbers
            total = Math.Round(num.Sum(), 2);
            Console.WriteLine("\nTotal: " + total);
            Console.WriteLine("Average: " + Math.Round(num.Average(), 2));
            Console.WriteLine("Lowest Number: " + Math.Round(num.Min(), 2));
            Console.WriteLine("Highest Number: " + Math.Round(num.Max(), 2));

            //display total in US, Swedish, Japanese, and Thai
            Console.WriteLine("\nUSD: " + total.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("SEK: " + total.ToString("c", CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.WriteLine("JPY: " + total.ToString("c", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("THB: " + total.ToString("c", CultureInfo.CreateSpecificCulture("th-TH")));
        }
    }
}
