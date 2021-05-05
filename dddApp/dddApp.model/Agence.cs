using System.Collections.Generic;

namespace dddApp.model
{
    public class Agence
    {
        public string nom { get; set; }
        public string adresse { get; set; }
        public Gerant gerant { get; set; }
        public Technicien technicien { get; set; }
        public List<Vehicule> vehicules { get; set; }
    }
}
