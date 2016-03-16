using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int number = int.Parse(Console.ReadLine());
                double result = Math.Sqrt(number);

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Invalid number\n" + ae.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number\n" + fe.Message);
            }
            catch (OverflowException ofe)
            {
                Console.WriteLine("Invalid number\n" + ofe.Message);
            }
            finally
            {
                Console.WriteLine("Good- bye");
            }

        }
    }
}
