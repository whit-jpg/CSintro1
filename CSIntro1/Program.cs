using System;//importing code another folder/file

namespace CSIntro1//our main folder of the project
{
    class Program//this is our main class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Moon");

            //string variable
            string eclipse = "control waves";
            //number variables
            int num1 = 75;
            float num2 = 75.360f;
            double num3 = 75.360f;

            //boolean variable
            bool boolean = true;

            Console.WriteLine("eclipse");
            Console.WriteLine("num2");
            Console.WriteLine("boolean");

            //press key to continue
            Console.ReadKey();

            //math
            int out1 = 3 + 4;
            float out2 = 3.5f * 75f;

            //constants
            const bool Moon = true;
            const string position = "Cresent";

            //concatenation
            string concat1 = "Moon's " + "Significance";
            Console.WriteLine(concat1);

            //working with variables
            int energysource = num1 * out1;
            Console.WriteLine(energysource);

            string concat2 = position + " " + position;

            //string interpolation
            Console.WriteLine("cresent is {0}. {1}, {2}", position, num1, out2);
        }
    }
}
