using System;

namespace FinalGCDeliverable1
{
    class Program
    {
        static void Main(string[] args)
            {
                bool LoopProgram = true;
                while (LoopProgram == true)
                {
                    Console.WriteLine
                        ("How many peanut butter and jelly sandwiches are needed");

                    string input = Console.ReadLine();
                    decimal number;
                    decimal.TryParse(input, out number);
                    decimal slices = number * 2;
                    decimal PB = number * 2;
                    decimal Jelly = number * 4;
                    Console.WriteLine(" Slices of bread: ");
                    Console.WriteLine(slices);
                    Console.WriteLine(" TBSP of peanutbutter: ");
                    Console.WriteLine(PB);
                    Console.WriteLine(" tsp of jelly: ");
                    Console.WriteLine(Jelly);

                    decimal loafs = (slices / 28);
                    loafs = Math.Ceiling(loafs);
                    decimal JOPB = PB / 32;
                    JOPB = Math.Ceiling(JOPB);
                    decimal JoJelly = Jelly / 48;
                    JoJelly = Math.Ceiling(JoJelly);




                    Console.WriteLine(" You will need " + loafs + " loafs of bread ");
                    Console.WriteLine(JOPB + " Jars of peanutbutter ");
                    Console.WriteLine(" and " + JoJelly + " jars of Jelly ");

                    Console.WriteLine(" Would you like to calculate for a different number ");

                    string ans = Console.ReadLine().ToUpper();
                    if (ans != null && ans == "Y")
                    {
                        LoopProgram = true;
                    }

                    else if (ans != null && ans == "YES")
                    {
                        LoopProgram = true;
                    }
                    else
                    {
                        LoopProgram = false; Console.WriteLine("Enjoy your sandwhiches, Goodbye");
                    }
                }
            }
        }
    }

