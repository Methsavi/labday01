using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapday01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenth: ");
            double lenth = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            double area = Area(lenth, width);

            Console.WriteLine("Your Area is: " + area);
            Console.ReadLine();

        }
        static double Area(double lenth, double width)
        {
            return lenth * width;
        }
    }
    
}
