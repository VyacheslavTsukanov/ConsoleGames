using System;

namespace SharpInnkeepersLegacy
{
    public class BartenderSister
    {
        int counter;
        public BartenderSister()
        {
            counter = 0;
        }
        public void Turn()
        {
            Console.Clear();
            Console.WriteLine(".&&&&&&&&&&&&&&&&&.");
            Console.WriteLine("&&=====....=====&&&");
            Console.WriteLine("&&.---...@..---.&&&");
            Console.WriteLine("$..($)...@..($).&&/");
            Console.WriteLine("#.......@@........$");
            Console.WriteLine("..**...&&...**....#");
            Console.WriteLine(".--.........*.--...");

            counter++;
            switch (counter % 4)
            {
                case 0:
                    Console.WriteLine(".....--------//....");
                    Console.WriteLine("..---=======---....");
                    Console.WriteLine("...................");
                    break;
                case 1:
                    Console.WriteLine("...................");
                    Console.WriteLine("..---=======---....");
                    Console.WriteLine(".....--------//....");
                    break;

            }
            
        }
        
    }
}
