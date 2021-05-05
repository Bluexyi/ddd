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

        public Location Louer(string vehiculeId, string clientId, DateTime dateDebut, DateTime dateFin, string etatVehicule)
        {
            Client client = clientRepository.GetById(clientId);
            Vehicule vehicule = vehiculeRepository.GetById(vehiculeId);
            
            if (client == null) {
                throw new ClientNonTrouveException(clientId);
            }

            if (vehicule == null) {
                throw new VehiculeNonTrouveException(vehiculeId);
            }

            if (dateDebut > dateFin)
            {
                throw new DateInvalidException();
            }

            if (vehicule.disponibilite != "disponible")
            {
                throw new VehiculeIndisponibleException();
            }

            if (!client.permisValide)
            {
                throw new PermisClientInvalidException();
            }

            Location location = new Location
            {
                client = client,
                vehicule = vehicule,
                dateDebutLocation = dateDebut,
                dateFinLocation = dateFin,
                etatAvantLocation = etatVehicule
            };

            locationRepository.Save(location);

            return location;
        }
    }
}
