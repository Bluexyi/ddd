using dddApp.model;
using System;

namespace dddApp.useCase
{
    public class LouerUnVehicule
    {
        private ClientRepository clientRepository;
        private VehiculeRepository vehiculeRepository;
        private AgenceRepository agenceRepository;
        private LocationRepository locationRepository;

        public LouerUnVehicule(ClientRepository clientRepository, VehiculeRepository vehiculeRepository, AgenceRepository agenceRepository, LocationRepository locationRepository)
        {
            this.clientRepository = clientRepository;
            this.vehiculeRepository = vehiculeRepository;
            this.agenceRepository = agenceRepository;
            this.locationRepository = locationRepository;
        }

        public Location Louer(Vehicule vehicule, Client client, DateTime dateDebut, DateTime dateFin, string etatVehicule)
        {
            if (dateDebut > dateFin)
            {
                return null;
            }

            if (vehicule.disponibilite != "disponible")
            {
                return null;
            }

            if (!client.permisValide)
            {
                return null;
            }

            Location location = new Location
            {
                client = client,
                vehicule = vehicule,
                dateDebutLocation = dateDebut,
                dateFinLocation = dateFin,
                etatAvantLocation = etatVehicule
            };

            return location;
        }
    }
}
