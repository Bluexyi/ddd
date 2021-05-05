using dddApp.model;
using dddApp.unitTest.mockRepository;
using dddApp.useCase;
using NUnit.Framework;
using System;
using System.Linq;

namespace dddApp.unitTest
{
    public class LouerUnVehiculeUnitTests
    {

        private LouerUnVehicule louerUnVehicule;

        private MockClientRepository clientRepository;
        private MockVehiculeRepository vehiculeRepository;
        private MockAgenceRepository agenceRepository;
        private MockLocationRepository locationRepository;

        [SetUp]
        public void Setup()
        {
            clientRepository = new MockClientRepository();
            vehiculeRepository = new MockVehiculeRepository();
            agenceRepository = new MockAgenceRepository();
            locationRepository = new MockLocationRepository();

            louerUnVehicule = new LouerUnVehicule(clientRepository, vehiculeRepository, locationRepository);
        }

        [Test]
        public void LocationDeVehiculePossible()
        {
            Client client = new()
            {
                PermisValide = true
            };
            Vehicule vehicule = new()
            {
                Disponibilite = VehiculeDisponibiliteEnum.DISPONIBLE
            };
            clientRepository.Add("13", client);
            vehiculeRepository.Add("2", vehicule);

            DateTime dateDebut = new(1993, 6, 7);
            DateTime dateFin = new(1993, 6, 8);

            Location location = louerUnVehicule.Louer("2", "13", dateDebut, dateFin);
            Assert.IsNotNull(location);
            Assert.AreEqual(location.DateDebutLocation, dateDebut);
            Assert.AreEqual(location.DateFinLocation, dateFin);
            Assert.AreEqual(location.Client, client);
            Assert.AreEqual(location.Vehicule, vehicule);
            Assert.AreEqual(locationRepository.GetAll().Count(), 1);
        }

    }
}