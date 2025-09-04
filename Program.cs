using System.ComponentModel;

namespace _4U_Assignment_One___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, favMovie;

            firstName = "Sarah";
            favMovie = "The Matrix";
            
            Console.WriteLine($"Hello, my name is {firstName.ToLower()} y mi película favorita es {favMovie.ToLower()}.");
            firstName = firstName.ToUpper();
            favMovie = favMovie.ToUpper();

           Console.WriteLine($"Hello, my name is {firstName} y mi película favorita es {favMovie}.");
           



        }
    }
}
