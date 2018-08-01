using System;

namespace loop_value
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("please enter the number");

            string userinputstr = Console.ReadLine();

            int userinputInt = int.Parse(userinputstr);

            int sumOutput = 0;

            for (int Loopvalue = 2; Loopvalue < 20; Loopvalue++)

            {
                Console.WriteLine(Loopvalue * userinputInt);

                sumOutput += Loopvalue * userinputInt;

            }
            Console.WriteLine(sumOutput);
            Console.ReadLine();
        }
    }
}

        }
    }
}
