using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab4_Client.ServiceReference1.MyfirstwebserviceSoapClient service = new Lab4_Client.ServiceReference1.MyfirstwebserviceSoapClient();

            int sum = service.Add(2, 3);
            Console.WriteLine("The sum is " + sum.ToString());
            Console.WriteLine("5 lei in euro: " + service.ConvertToEuro(5));
            Console.WriteLine("42 F in celsius: " + service.FtoC(42));
            Console.WriteLine("20 C in Fahrenheit: " + service.CtoF(20));
            Console.WriteLine("Current date and time: " + service.ShowDateAndTime());
            Console.WriteLine("Lista: ");
            var list = service.ShowList();

            list.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
