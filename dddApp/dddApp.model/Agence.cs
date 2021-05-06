using System.Collections.Generic;

namespace dddApp.model
{
    public class Agence
    {
        public string Nom { get; }
        public string Adresse { get; }
        public Gerant Gerant { get; }
        public Technicien Technicien { get; }
        public List<Vehicule> Vehicules { get; }

        public Agence(string nom, string adresse, Gerant gerant, Technicien technicien, List<Vehicule> vehicules) 
        {
            this.Nom = nom;
            this.Adresse = adresse;
            this.Gerant = gerant;
            this.Technicien = technicien;
            this.Vehicules = vehicules;
        }
    }
}
