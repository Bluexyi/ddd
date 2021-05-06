using System;

namespace dddApp.model
{
    public class Client
    {
        public string Nom { get; }
        public string Prenom { get; }
        public bool PermisValide { get; }
        public DateTime DateNaissance { get; }
        public string NumTelephone { get; }
        public string Adresse { get; }

        public Client(string nom, string prenom, bool permisValide, DateTime dateNaissance, string numTelephone, string adresse)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.PermisValide = permisValide;
            this.DateNaissance = dateNaissance;
            this.NumTelephone = numTelephone;
            this.Adresse = adresse;
        }
    }
}
