using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            AssembledSetOfFigures();
        }
        
        static void AssembledSetOfFigures()
        {
            string triangleSize = GetUserValueByMassage("Hello!\nSize: ");
            int triangleSizeToConvert = Convert.ToInt32(triangleSize);
            GetUserValueByMassage("\nYour answer is ready, press enter..\n");
            Engine(triangleSizeToConvert);
            GetUserValueByMassage("\nPress enter..\n");
            SecondEngine(triangleSizeToConvert);
            GetUserValueByMassage("\nDo you want to see the rhombus, press enter..\n");
            ThirdEngine(triangleSizeToConvert);
            GetUserValueByMassage("\nUntil we meet again, I was glad to show my skills.\nExit..");
        }
        
        static void Engine(int worker)
        {
            int assistant = worker;
            
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

        
        static void SecondEngine(int worker)
        {
            for (int leadingSpaces = 0; leadingSpaces < worker; leadingSpaces++)
            {
                for (int secondLeadingSpaces = 0;
                     secondLeadingSpaces <= leadingSpaces;
                     secondLeadingSpaces++)
                    Console.Write(" ");
                
                for (int thirdLeadingSpaces = 0;
                     thirdLeadingSpaces <= (worker - leadingSpaces) - 1;
                     thirdLeadingSpaces++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        
        static void ThirdEngine(int worker)
        {
            for (int leadingSpaces = 0; leadingSpaces < 2 * worker - 1; leadingSpaces++)
            {
                int comparator;
                if (leadingSpaces < worker)
                    comparator = 2 * (worker - leadingSpaces) - 1;//2
                else
                    comparator = 2 * (leadingSpaces - worker + 1) + 1;//2
                
                for(int secondLeadingSpaces = 0; secondLeadingSpaces < comparator; secondLeadingSpaces++)
                    Console.Write(" ");
                for(int thirdLeadingSpaces = 0; thirdLeadingSpaces < 2 * worker - comparator; thirdLeadingSpaces++)
                    Console.Write("* ");
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