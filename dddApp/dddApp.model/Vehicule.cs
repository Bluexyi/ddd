using System;
using System.Collections.Generic;
using System.Linq;

namespace dddApp.model
{
    public class Vehicule
    {
        public string Immatriculation { get; }
        public string Marque { get; }
        public string Modele { get; }
        public long Kilometrage { get; }
        public DateTime DateDerniereRevision { get; }
        public VehiculeDisponibiliteEnum Disponibilite { get; }
        public EtatEnum Etat { get; }
        public string TypeCarburant { get; }
        public DateTime DateControleTechnique { get; }
        public VehiculeForfaitEnum TypeForfait { get; }
        public VehiculeCategorieEnum Categorie { get; }
        public int VignettePollution { get; }
        public Agence Agence { get; }
        public Vehicule(string immatriculation, string marque, string modele, long kilometrage, 
            DateTime dateDerniereRevision, VehiculeDisponibiliteEnum disponibilite, EtatEnum etat, 
            string typeCarburant, DateTime dateControleTechnique, VehiculeForfaitEnum typeForfait, VehiculeCategorieEnum categorie, int vignettePollution, Agence agence)
        {
            this.Immatriculation = immatriculation;
            this.Marque = marque;
            this.Modele = modele;
            this.Kilometrage = kilometrage;
            this.DateDerniereRevision = dateDerniereRevision;
            this.Disponibilite = disponibilite;
            this.Etat = etat;
            this.TypeCarburant = typeCarburant;
            this.DateControleTechnique = dateControleTechnique;
            this.TypeForfait = typeForfait;
            this.Categorie = categorie;
            this.VignettePollution = vignettePollution;
            this.Agence = agence;
        }

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
