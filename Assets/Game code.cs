using System;

namespace Text_Based_Adventure_Game
{
    class MainClass#
    {
        public static void Main (string[] args)
        {
            //Ints:
            int correct = 0;

            //Strings:
            string gender;
            string Race;



            //Character Creation:
            do
            {
                Console.Clear():
                Console.WriteLine("Please choose a gender as below:"):
                Console.WriteLine("Male / Female"):
                gender = Console.ReadLine().ToUpper():
                if (gender == "MALE")
                {
                    correct = 1:
                }
                if (gender == "FEMALE")
                {
                    correct = 1:
                }
                else if (gender != "MALE" || gender != "FEMALE")
                {
                    Console.WriteLine("ERROR. Please try again.");
                    Console.ReadLine();
                }

            } while(correct == 0):
            correct = 0;


            //Race Creation:
            do
            {
                Console.Clear():
                Console.WriteLine("Please choose a race as below:"):
                Console.WriteLine("Human"):
                Console.WriteLine("Dwarf"):
                Console.WriteLine("Elf"):
                Console.WriteLine("Orc"):
                Console.WriteLine("Your Choice"):
                Race = Console.ReadLine().ToUpper():
                if (Race == "HUMAN" || Race == "DWARF" || Race == "ELF" || Race == "ORC")
                {
                    correct = 1:
                }
                else
                {
                    Console.WriteLine("ERROR. Please try again."):
                    Console.ReadLine():
                }
            } while(correct == 0);
        }
    }
}
