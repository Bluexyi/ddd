using dddApp.model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dddApp.useCase
{
    public class LouerUnVehicule
    {
        private readonly ClientRepository clientRepository;
        private readonly VehiculeRepository vehiculeRepository;
        private readonly LocationRepository locationRepository;

        public LouerUnVehicule(
            ClientRepository clientRepository,
            VehiculeRepository vehiculeRepository,
            LocationRepository locationRepository
        )
        {
            this.clientRepository = clientRepository;
            this.vehiculeRepository = vehiculeRepository;
            this.locationRepository = locationRepository;
        }

        public Location Louer(string vehiculeId, string clientId, DateTime dateDebut, DateTime dateFin)
        {
            Client client = clientRepository.GetById(clientId);
            Vehicule vehicule = vehiculeRepository.GetById(vehiculeId);
            List<Location> locations = locationRepository.GetAll().ToList();

            Location location = Location.CreerLocation(vehiculeId, clientId, dateDebut, dateFin, client, vehicule, locations);

            locationRepository.Save(location);

            return location;
        }
    }
}
