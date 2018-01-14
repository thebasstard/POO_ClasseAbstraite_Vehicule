using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClasseAbstraite_Vehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture(2005, 200000);
            Console.Out.WriteLine(v);
            v.Demarrer();
            v.Accelerer();
            Camion c = new Camion(2003, 4560000);
            Console.Out.WriteLine(c);
            c.Demarrer();
            c.Accelerer();
            Console.ReadKey();
            
        }
    }
}
