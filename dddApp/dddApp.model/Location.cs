using System;

namespace dddApp.model
{
    public class Location
    {
        public Vehicule Vehicule { get; set; }
        public Client Client { get; set; }
        public EtatEnum EtatAvantLocation { get; set; }
        public EtatEnum EtatApresLocation { get; set; }
        public DateTime DateDebutLocation { get; set; }
        public DateTime DateFinLocation { get; set; }
        public string EtatLocation { get; set; }
    }
}
