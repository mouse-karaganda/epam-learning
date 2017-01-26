using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchException
{
    class Program
    {
        protected static void Divide()
        {
            try
            {
                int i = 10;
                int b = 0;
                //int c = i / b;

                int x = 5;
                int[] arr = { 1, 2, 3 };
                if (x >= arr.Length)
                {
                    //throw new Exception("Error with length");
                }
                Console.WriteLine($"x = {arr[x]}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: divide by zero");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: out of range");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }

        static void Main(string[] args)
        {
            Divide();
            Console.ReadLine();
        }
    }
}
