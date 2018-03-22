using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo2
{
    class MessageElectronique
    {
        private string titre;
        private string adresseDestinataire;
        private Corps composeCorps;
        private En_tête composeTete;
        List<PièceJointe> contenir;

        public MessageElectronique(string titre, string adresseDestinataire)
        {
            this.titre = titre;
            this.adresseDestinataire = adresseDestinataire;
            composeCorps = new Corps();
            composeTete = new En_tête();
        }
        

    }
}
