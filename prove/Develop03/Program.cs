using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;





class Program
{
    static void Main(string[] args)
    {
        
        Scriptures scripture = new ("1 Nephi", 1, 1,"I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.");
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\n\n\nPress Enter to continue or type 'quit' to exit.");
while (true)
        {
            string promptKey = Console.ReadLine();
            if (promptKey.ToLower() == "quit")
            {
                break;
            }
            if (!scripture.HideWords())
            {
                Console.WriteLine("Congratulations!");
                break;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\n\n\nPress Enter to continue or type 'quit' to exit.");
        }
    }
}