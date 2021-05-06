using dddApp.model;
using dddApp.model.Exceptions;
using System;

namespace dddApp.useCase
{
    public class AnnulerReservation {
        private readonly LocationRepository locationRepository;

        public AnnulerReservation(LocationRepository locationRepository)
        {
            this.locationRepository = locationRepository;
        }

        public bool Annuler(string locationId, DateTime dateAnnulation) {
            Location location = locationRepository.GetById(locationId);

            if (location == null) {
                throw new LocationNonTrouveException(locationId);
            }

            bool payeSupplement = location.DateDebutLocation.Subtract(dateAnnulation).Hours < 24;

            location.EtatLocation = "Annulé";

            locationRepository.Update(locationId, location);

            return payeSupplement;
        }
    }
}