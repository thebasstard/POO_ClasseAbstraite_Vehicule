using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClasseAbstraite_Vehicule
{
    abstract class Vehicule
    {
        private int matricule;
        private int modele;
        private double prix;
        private static int nb_vehicules = 0;

        public int Matricule
        {
            get { return matricule; }
        }

        
        public int Modele
        {
            get { return modele; }
            set { modele = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public static int Nb_vehicules
        {
            get { return nb_vehicules; }
        }

        public Vehicule(int modele, double prix)
        {
             
            nb_vehicules++;
            matricule = nb_vehicules;
            this.modele = modele;
            this.prix = prix;
        }

        public abstract void Demarrer();
        public abstract void Accelerer();

        public override string ToString()
        {
            return "Matricule: " + matricule + " Modéle: " + modele + " Prix: " + prix;
        }
        

    }
}
