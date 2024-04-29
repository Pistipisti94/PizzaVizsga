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
        }
    }
}
