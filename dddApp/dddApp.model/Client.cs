using System;

namespace dddApp.model
{
    public class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool PermisValide { get; set; }
        public DateTime DateNaissance { get; set; }
        public string NumTelephone { get; set; }
        public string Adresse { get; set; }
    }
}
