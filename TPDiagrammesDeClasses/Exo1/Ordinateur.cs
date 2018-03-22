using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1
{
    class Ordinateur
    {
        private string nom;
        private int puissance;
        private int taille;
        private File gère;

        public Ordinateur(string nom, int puissance, int taille)
        {
            this.nom = nom;
            this.puissance = puissance;
            this.taille = taille;

            gère = new File();

        }

        public void allumer() { }
        public void éteindre() { }
    }
}
