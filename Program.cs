using System;
using static System.Console;
using static System.Array;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool flag = true;

            do
            {
                WriteLine("Enter the number of contestants (0 - 30)");
                count = Convert.ToInt32(Console.ReadLine());
            } while (count <= 0 && count >= 30);

            string[,] contestants = new string[2, count];

            for (int x = 0; x < count; ++x)
            {
                WriteLine("Enter the name of the contestant {0}: ", (x + 1));
                string name = Console.ReadLine();
                contestants[0, x] = name;

                do
                {
                    WriteLine("Please enter the talent code. Codes are S, D, " +
                        "M, and O.");
                    string talentCode = Console.ReadLine();
                    if (talentCode == "S" || talentCode == "S" || talentCode == "D" || talentCode == "M" || talentCode == "O")
                    {
                        contestants[1, x] = talentCode;
                        flag = false;
                    }
                    else
                    {
                        WriteLine("That is an invalid code. Try again using the correct code.");
                        flag = true;
                    }
                } while (flag);
            }

            int sCount = 0, dCount = 0, mCount = 0, oCount = 0;

            for (int x = 0; x < count; x++)
            {
                if (contestants[1, x] == "S")
                    ++sCount;
                else if (contestants[1, x] == "D")
                    ++dCount;
                else if (contestants[1, x] == "M")
                    ++mCount;
                else
                    ++oCount;
            }

            WriteLine("Number of contestants in each talent category are: ");
            WriteLine("Singing: {0}", sCount);
            WriteLine("Dancing: {0}", dCount);
            WriteLine("Music: {0}", mCount);
            WriteLine("Other: {0}", oCount);

            int totalEntries = 0;

            while (totalEntries < count)
            {
                WriteLine("Enter the talent code to get a list of contestants for that category.");
                string talentCode = Console.ReadLine();
                if (talentCode == "S" || talentCode == "S" || talentCode == "D" || talentCode == "M" || talentCode == "O")
                {
                    WriteLine("The names of contestants entered are: ");
                    for (int x = 0; x < count; ++x)
                    {
                        if (contestants[1, x] == talentCode)
                        {
                            WriteLine(contestants[0, x]);
                            ++totalEntries;
                        }

                    }
                }
                else
                {
                    WriteLine("Please enter valid talent code.");
                    
                }
            }
        }
    }
}

        
    

