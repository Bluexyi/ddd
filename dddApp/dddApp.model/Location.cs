using dddApp.model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public static Location CreerLocation(string vehiculeId, string clientId, DateTime dateDebut, DateTime dateFin, Client client, Vehicule vehicule, List<Location> locations)
        {
            if (client == null)
            {
                throw new ClientNonTrouveException(clientId);
            }

            if (vehicule == null)
            {
                throw new VehiculeNonTrouveException(vehiculeId);
            }

            if (dateDebut > dateFin)
            {
                throw new DateInvalidException();
            }

            if (!vehicule.EstDisponible(dateDebut, dateFin, locations))
            {
                throw new VehiculeIndisponibleException();
            }

            if (!client.PermisValide)
            {
                throw new PermisClientInvalidException();
            }

            Location location = new()
            {
                Client = client,
                Vehicule = vehicule,
                DateDebutLocation = dateDebut,
                DateFinLocation = dateFin
            };
            return location;
        }
    }
}
