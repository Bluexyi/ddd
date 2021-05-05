using System;

namespace dddApp.model
{
    public class Vehicule
    {
        public string immatriculation { get; set; }
        public string marque { get; set; }
        public string modele { get; set; }
        public int kilometrage { get; set; }
        public DateTime dateDerniereRevision { get; set; }
        public string disponibilite { get; set; }
        public string typeCarburant { get; set; }
        public DateTime dateControleTechnique { get; set; }
        public int typeForfait { get; set; }
        public string categorie { get; set; }
        public int vignettePollution { get; set; }
        public Agence agence { get; set; }


    }
}
