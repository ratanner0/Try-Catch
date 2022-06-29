using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception)
            {

                Console.WriteLine("Formnat Exception, please only enter a number!");
            }
            finally
            {
                Console.WriteLine("This will always be ran");
            }
            Console.ReadKey();
        }
    }
}
