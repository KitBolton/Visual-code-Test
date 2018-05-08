using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
   class Program
   {
       static void Main(string[] args)
       {
          int numberOfSales = 0;
          double[] sales;

          Console.WriteLine ("please enter number of sales ");
          numberOfSales = Convert.ToInt32(Console.ReadLine());

          sales = new double[numberOfSales];

          for (int i = 0; i < numberOfSales; i++)
          {
              Console.Write("Please enter sale #{0}: ", i + 1);
              sales[i] = Convert.ToDouble(Console.ReadLine());
          }

          double sum = sales.Sum();
          for (int i = 0; i < numberOfSales; i++)
          {
              double contribution = sales[i] / sum;
              Console.WriteLine("sale # {0} was {1:C2} and contributed {2:P2}", i + 1, sales[i], contribution);
          }
          Console.WriteLine("Total sum of sales is {0:C2}", sum);
       }
   }
}