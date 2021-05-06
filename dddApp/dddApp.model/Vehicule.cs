using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool EstDisponible(DateTime dateDebut, DateTime dateFin, List<Location> locations)
        {
            return !locations.Any(x =>
                x.Vehicule == this &&
                (
                    (dateDebut >= x.DateDebutLocation) &&
                    (x.DateDebutLocation <= dateFin)
                ) ||
                (
                    (dateDebut >= x.DateFinLocation) &&
                    (x.DateFinLocation <= dateFin)
                )
            );
        }
    }
}
