using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[] { '2', '5', '8', '9', '3','9', 'f', 'm', 'r' };

            var numbers = new List<int>();

            var str = "";
         
                                                                                
            foreach(var item in arr)
            {
                try
                {
                    str = item.ToString();
                    var number = int.Parse(str);

                    numbers.Add(number);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{item}'");
                }
                finally
                {
                    Console.WriteLine(item);
                }
                    
                    
            }
                                         
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
