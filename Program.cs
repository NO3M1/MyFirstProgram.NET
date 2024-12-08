using System.Runtime.CompilerServices;
using System.Xml;

namespace MyFirstProgram.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I like .NET");
            Console.WriteLine("It's really good");
            Console.Beep();

            /*VARIABLES*/

            int x; //declaration
            x = 123; //initialization

            int y = 321; //declaration and initialization

            int z = x + y;

            int age = 21; //whole integer
            double height = 300.5; //decimal numbers
            bool alive = true; //true or false
            char symbol = '@'; //single character
            String name = "Noemi";

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive );
            Console.WriteLine("Your symbol is " + symbol );


            String userName = symbol + name;
            Console.WriteLine("Your username is:" + userName);


            /*CONSTANTS = immutable values whicgare known at compile time and do not change*/

            const double pi = 3.14159;
            Console.WriteLine(pi);

            /*TYPE CASTING
             * = converting a value to a different data type
             * useful when we accept user input (string)
             */

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 1235;
            double d = Convert.ToDouble(c) + 0.1; //1235.1

            int e = 321;
            String f = Convert.ToString(e);

            String i = "true";
            bool j = Convert.ToBoolean(i);  

            Console.WriteLine(b.GetType());
            Console.WriteLine(d); // 1235.1 
            Console.WriteLine(f); //321
            Console.WriteLine(i); //true
            Console.WriteLine(i.GetType());





            Console.ReadKey();


        }
    }
}
