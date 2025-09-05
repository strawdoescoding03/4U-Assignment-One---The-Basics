using System.ComponentModel;

namespace _4U_Assignment_One___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string firstName, favMovie, favQuote;

            firstName = "Sarah";
            favMovie = "The Matrix";
            favQuote = "There is no spoon.";

            //1
            Console.WriteLine($"Hello, je m'appelle {firstName.ToLower()} y mi película favorita es {favMovie.ToLower()}.");
            firstName = firstName.ToUpper();
            favMovie = favMovie.ToUpper();

            Console.WriteLine($"Hello, je m'appelle {firstName} y mi película favorita es {favMovie}.");
            Console.WriteLine(favMovie.Contains("THE"));
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");

            Console.WriteLine(favMovie);

            Console.WriteLine("Press Enter to Move...");
            Console.ReadLine();
            Console.Clear();


            //2
            favQuote = favQuote.ToLower();
            favQuote = favQuote.Replace("a", "").Replace("e", " ").Replace("i", " ").Replace("o", " ").Replace("u", " ");;



            Console.WriteLine(favQuote);





        }
    }
}
