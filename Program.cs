using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Variables";

            char letter;   letter = 'A';   //Declared then initialised.
            int number;    number = 100;   //Declared then initialised.
            float body = 98.6f;            //Declared and initialised. 
            double pi = 3.14159;           //Declared and initialised.  
            decimal sum = 1000.00m;        //Declared and initialised.  
            bool flag = false;             //Declared and initialised.  
            string text = "C# is Fun";     //Declared and initialised. 

            Console.WriteLine("char letter:\t" + letter );
            Console.WriteLine("int number:\t" + number );
            Console.WriteLine("float body:\t" + body );
            Console.WriteLine("double pi:\t" + pi );
            Console.WriteLine("deciaml sum:\t" + sum );
            Console.WriteLine("bool flag:\t" + flag );
            Console.WriteLine("string text:\t" + text );
            Console.ReadKey();






        }
    }
}
