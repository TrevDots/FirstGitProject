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
        }
    }
}
