using System.Collections.Generic;

namespace dddApp.model
{
    public class Agence
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public Gerant Gerant { get; set; }
        public Technicien Technicien { get; set; }
        public List<Vehicule> Vehicules { get; set; }
    }
}
