using System;

namespace dddApp.model
{
    public class Vehicule
    {
        public string Immatriculation { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public long Kilometrage { get; set; }
        public DateTime DateDerniereRevision { get; set; }
        public VehiculeDisponibiliteEnum Disponibilite { get; set; }
        public EtatEnum Etat { get; set; }
        public string TypeCarburant { get; set; }
        public DateTime DateControleTechnique { get; set; }
        public VehiculeForfaitEnum TypeForfait { get; set; }
        public VehiculeCategorieEnum Categorie { get; set; }
        public int VignettePollution { get; set; }
        public Agence Agence { get; set; }


    }
}
