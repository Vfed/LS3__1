using System;

namespace LS3__1
{
    class Program
    {
        static void Main(string[] args)
        {
            string error = "";
            do
            {
                error = "";
                Console.Write("Enter your name :");
                string Name = Console.ReadLine();
                Name = Name.Trim();
                if (Name.Length < 3)
                {
                    error += "Your name mast be more than 3 letters ;";
                }
                Console.Write("Enter your age :");
                bool ageCheak = Int32.TryParse(Console.ReadLine(), out int age);
                if (!ageCheak)
                {
                    error += "Wrong age enter;";
                }
                if (age <= 0)
                {
                    error += "Your age must be more than 0";
                }
                if (error.Length > 0)
                {
                    Console.WriteLine(error);
                }
                else
                {
                    Console.WriteLine("Hi ," + Name + ", i know your age is " + age);
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (error.Length > 0);
        }
    }
}
