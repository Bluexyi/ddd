using System;

namespace dddApp.model
{
    public class Client
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public bool permisValide { get; set; }
        public DateTime dateNaissance { get; set; }
        public string numTelephone { get; set; }
        public string adresse { get; set; }
    }
}
