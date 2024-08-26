using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valikute_konstruktsionid
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("1 mis on sinu nimi? ");
            string a = (Console.ReadLine());
            Console.Write("2 mis on sinu nimi? ");
            string b = (Console.ReadLine());
            Console.WriteLine("te olete minu naabrid", a, "ja", b);

            int c = int.Parse(Console.ReadLine());
            Console.Write("kui pikk oled sa? ");
            if (vastus < 160)
            {
                Console.WriteLine("sa oled lühike");
            }
            if ()
            {
                Console.WriteLine("sa oled lühike");
            }
        }
    }
}
