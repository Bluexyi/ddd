using dddApp.model;
using dddApp.useCase.Exceptions;
using System;
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
            
            if (client == null) {
                throw new ClientNonTrouveException(clientId);
            }

            if (vehicule == null) {
                throw new VehiculeNonTrouveException(vehiculeId);
            }

            if (dateDebut >= dateFin)
            {
                throw new DateInvalidException();
            }

            if (locationRepository.GetAll().Any(x =>
                x.Vehicule == vehicule &&
                (
                    (dateDebut >= x.DateDebutLocation) &&
                    (x.DateDebutLocation <= dateFin)
                ) ||
                (
                    (dateDebut >= x.DateFinLocation) &&
                    (x.DateFinLocation <= dateFin)
                )
            ))
            {
                throw new VehiculeIndisponibleException();
            }

            if (vehicule.Disponibilite != VehiculeDisponibiliteEnum.DISPONIBLE)
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

            locationRepository.Save(location);

            return location;
        }
    }
}
