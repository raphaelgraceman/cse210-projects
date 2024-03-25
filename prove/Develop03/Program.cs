using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

        Scripture myScripture = new Scripture(new Reference("John", 3, 16), "And it came to pass..");

        // WHILE TRUE
        //      CLEAR CONSOLE
        //      myScripture.GetDisplayText()
        //      PUT "Press enter to continue or type 'exit' to quit"
        //      input = Get
        //      IF input == 'quit'
        //          BREAK
        //      myScripture.HideRandomWords( 3 )
        //      IF myScripture.AllWordsHidden()
        //          BREAK
        while(true)
        {
            Console.Clear();
            myScripture.GetDisplayText();

            //Ask user input nd print to the console.
            Console.WriteLine("Press enter to continue or type 'exist to qui't");
             string input = Console.ReadLine();
            
            if (input == "exit")
            {
                break;
            }
            
            myScripture.HideRandomWords(3);
            
            if (myScripture.AllWordsHidden())
            {
                break;
            }

        }
}
}


   
