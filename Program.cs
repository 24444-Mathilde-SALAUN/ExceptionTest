using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[2];
            try
            {
                array[0] = 1;
                array[1] = 2;
                array[2] = 3;
                foreach (int i in array)
                {
                    Console.WriteLine(i);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"An Out of Range exception was thrown");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An exception was thrown.");
            }
            finally
            {
                Console.WriteLine($"Finished process, exception thrown, all issues closed.");
            }
            try
            {
                Divide(6, 0, "6/0");
            }
            catch (DivideByZeroException div0)
            {
                Console.WriteLine($"A Divide by 0 exception was thrown.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An exception was thrown.");
            }
            finally
            {
                Console.WriteLine($"Finished process, exception thrown, all issues closed.");
            }
            try
            {
                Show(null, 59);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"Finished process, exception thrown, all issues closed.");
            }
        }
        public static void Divide(int a, int b, string s)
        {
            int c = a / b;
            Console.WriteLine($"{s.ToUpper()} : {c}");
        }
        

        public static void Show(string s, int i)
        {
            Console.WriteLine($"{s} is {i} years old");
        }
    }
}
