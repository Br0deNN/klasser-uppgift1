using klasser_uppgift1;
using System;
namespace uppgift1
{
    public class Program
    {
        public static void Main()
        {
            fordon bil = new fordon("BMW", "Sedan", "Svart", 2006, 13000);

            Console.WriteLine(bil.märke);
            Console.WriteLine(bil.modell);
            Console.WriteLine(bil.färg);
            Console.WriteLine(bil.årsmodell);
            Console.WriteLine(bil.mil);



        }
    }
}