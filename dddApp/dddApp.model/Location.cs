using System;

namespace dddApp.model
{
    public class Location
    {
        public Vehicule vehicule { get; set; }
        public Client client { get; set; }
        public string etatAvantLocation { get; set; }
        public string etatApresLocation { get; set; }
        public DateTime dateDebutLocation { get; set; }
        public DateTime dateFinLocation { get; set; }
    }
}
