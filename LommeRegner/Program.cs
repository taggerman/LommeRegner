using System;
using System.Text;
using System.Threading.Tasks;

namespace lommeregner
{
    class program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.WriteLine("LOMMEREGNER");
                Console.WriteLine("-----------");
                Console.WriteLine("INDTAST DIT FØRSTE NUMMER:)");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("INDTAST DIT ANDET NUMMER:)");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("INSTAST DIT SYMBOL ,/,+,-,*,");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("= " + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("MINUS" + res);
                        break;
                    case "*":
                        res = num1 + num2;
                        Console.WriteLine("GANGE" + res);
                        break;
                    case "/":
                        res = num1 - num2;
                        Console.WriteLine("DIVIDERE" + res);
                        break;
                    default:
                        Console.WriteLine("FORKERT INDPUT");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("VIL DU PRØVE IGEN SÅ TRY ,Y,");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }
}