using System;
using System.Globalization;
class bee1048
{

    static void Main(string[] args)
    {
        float number;


        number = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (number >= 0 && number <= 25.00)
        {
            Console.WriteLine("range [0,25]");

        }
        else if (number >= 25.01 && number <= 50.00)
        {
            Console.WriteLine("range (25,50]");


        }
        else if (number >= 50.01 && number <= 75.00)
        {
            Console.WriteLine("range (50,75]");

        }
        else if (number >= 75.01 && number <= 100.00)
        {
            Console.WriteLine("range (75,100]");

        }
        else
        {
            Console.WriteLine("out of range");

        }


    }

}