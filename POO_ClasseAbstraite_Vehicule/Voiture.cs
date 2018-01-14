using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClasseAbstraite_Vehicule
{
    class Voiture : Vehicule
    {
        public Voiture(int modele, double prix) : base(modele, prix) { }

        public override void Demarrer()//Implémentation de la méthode abstraire Démarrer()
        {
            Console.Out.WriteLine("La voiture démarre....");
        }

        public override void Accelerer()//Implémentation de la méthode abstraire accélérer()
        {
            Console.Out.WriteLine("La voiture Accélére....");
        }

        public override string ToString()
        {
            return "Voiture_ " + base.ToString();
        }
       
    }
}
