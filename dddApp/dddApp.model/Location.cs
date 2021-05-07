using dddApp.model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dddApp.model
{
    public class Location
    {
        public Vehicule Vehicule { get; }
        public Client Client { get; }
        public EtatEnum EtatAvantLocation { get; }
        public EtatEnum EtatApresLocation { get; }
        public DateTime DateDebutLocation { get; }
        public DateTime DateFinLocation { get; }
        public string EtatLocation { get; }
        public Location(Vehicule vehicule, Client client, EtatEnum etatAvantLocation, EtatEnum etatApresLocation, DateTime dateDebutLocation, DateTime dateFinLocation, string etatLocation)
        {
            this.Vehicule = vehicule;
            this.Client = client;
            this.EtatAvantLocation = etatAvantLocation;
            this.EtatApresLocation = etatApresLocation;
            this.DateDebutLocation = dateDebutLocation;
            this.DateFinLocation = dateFinLocation;
            this.EtatLocation = etatLocation;
        }

        public static Location CreerLocation(string vehiculeId, string clientId, DateTime dateDebut, DateTime dateFin, Client client, Vehicule vehicule, List<Location> locations)
        {
            Client.ClientExiste(clientId, client);

            if (vehicule == null)
            {
                throw new VehiculeNonTrouveException(vehiculeId);
            }

            if (dateDebut > dateFin)
            {
                throw new DateInvalidException();
            }

            vehicule.VerifierDisponibiliteVehicule(dateDebut, dateFin, locations);

            if (!client.PermisValide)
            {
                throw new PermisClientInvalidException();
            }

            Location location = new(vehicule, client, vehicule.Etat, vehicule.Etat, dateDebut, dateFin, "");

            return location;
        }
    }
}
