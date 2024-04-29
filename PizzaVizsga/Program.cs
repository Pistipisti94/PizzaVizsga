using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaVizsga
{
    internal class Program
    {
        static Adatbazis adatbazis = new Adatbazis();
        static List<Futar> futars = new List<Futar>();
        static void Main(string[] args)
        {
            futars = adatbazis.GetAllFutar();
            feladat01();
        }

        private static void feladat01()
        {
            Console.WriteLine("1.feladat");
            foreach (var item in futars)
            {
                Console.WriteLine($"\t {item.fazon} {item.fnev} {item.ftel} {item.ertek}");
            }
        }
    }
}
