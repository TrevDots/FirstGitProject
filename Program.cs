using System;

namespace MyNewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string aFriend = "Bill";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello "+ aFriend);

            aFriend = Console.ReadLine();
            Console.WriteLine($"Hello {aFriend}");

            string firstFriend = "Maria";
            string secondFriend = "Sage";

            Console.WriteLine ($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine ($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine ($"The name {secondFriend} has {secondFriend.Length} letters.");

        }
    }
}
