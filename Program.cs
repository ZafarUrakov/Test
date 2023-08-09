using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string triangleSize = GetUserValueByMassage("Hello!\nTraingle size: ");
            double triangleSizeToConvert = Convert.ToDouble(triangleSize);
            GetUserValueByMassage("\nYour answer is ready, press enter..\n");
            mechanism(triangleSizeToConvert);
        }
        
        static void mechanism(double worker)
        {
            double assistant = worker;
            
            for (int leadingSpaces = 1; leadingSpaces <= worker; leadingSpaces++)
            {
                for (int secondLeadingSpaces = 0;
                     secondLeadingSpaces <= worker;
                     secondLeadingSpaces++)
                {
                    if (secondLeadingSpaces >= assistant)
                        Console.Write("* ");
                    else
                        Console.Write(" ");
                }

                assistant--;
                Console.WriteLine();

            }
        }

        static string GetUserValueByMassage(string massage)
        {
            Console.Write(massage);
            return Console.ReadLine();
        }
        
    }
}