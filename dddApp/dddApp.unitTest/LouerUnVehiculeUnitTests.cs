using dddApp.model;
using dddApp.unitTest.mockRepository;
using dddApp.useCase;
using dddApp.model.Exceptions;
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
        private MockLocationRepository locationRepository;

        [SetUp]
        public void Setup()
        {
            clientRepository = new MockClientRepository();
            vehiculeRepository = new MockVehiculeRepository();
            locationRepository = new MockLocationRepository();

            louerUnVehicule = new LouerUnVehicule(clientRepository, vehiculeRepository, locationRepository);
        }

        [Test]
        public void LocationDeVehiculePossible()
        {
            Client client = new("Dabin", "Mégane", true, new DateTime(1997, 12, 3), "0123456789", "Paris");
            Vehicule vehicule = new("DJ555LR", "Peugeot", "106", 182000, DateTime.Now, VehiculeDisponibiliteEnum.DISPONIBLE, EtatEnum.EN_ETAT_D_USAGE, "Essence",
                new DateTime(2020, 3, 3), VehiculeForfaitEnum.A, VehiculeCategorieEnum.BERLINE, 6, null);

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

        [Test]
        public void LouerUnVehiculeQuiNexistePas()
        {
            Client client = new("Dabin", "Mégane", true, new DateTime(1997, 12, 3), "0123456789", "Paris");
            clientRepository.Add("13", client);

            DateTime dateDebut = new(1993, 6, 7);
            DateTime dateFin = new(1993, 6, 8);

            Assert.Throws<VehiculeNonTrouveException>(() => louerUnVehicule.Louer("2", "13", dateDebut, dateFin));
        }

        [Test]
        public void LouerUnVehiculeParUnClientQuiNexistePas()
        {
            Vehicule vehicule = new("DJ555LR", "Peugeot", "106", 182000, DateTime.Now, VehiculeDisponibiliteEnum.DISPONIBLE, EtatEnum.EN_ETAT_D_USAGE, "Essence",
                new DateTime(2020, 3, 3), VehiculeForfaitEnum.A, VehiculeCategorieEnum.BERLINE, 6, null);
            vehiculeRepository.Add("2", vehicule);

            DateTime dateDebut = new(1993, 6, 7);
            DateTime dateFin = new(1993, 6, 8);

            Assert.Throws<ClientNonTrouveException>(() => louerUnVehicule.Louer("2", "13", dateDebut, dateFin));
        }

        [Test]
        public void LouerUnVehiculeIndisponible()
        {
            Vehicule vehicule = new("DJ555LR", "Peugeot", "106", 182000, DateTime.Now, VehiculeDisponibiliteEnum.DISPONIBLE, EtatEnum.EN_ETAT_D_USAGE, "Essence",
                new DateTime(2020, 3, 3), VehiculeForfaitEnum.A, VehiculeCategorieEnum.BERLINE, 6, null);
            vehiculeRepository.Add("2", vehicule);
            Client client = new("Dabin", "Mégane", true, new DateTime(1997, 12, 3), "0123456789", "Paris");
            clientRepository.Add("13", client);

            DateTime dateDebut = new(1993, 6, 7);
            DateTime dateFin = new(1993, 6, 8);

            Location locationAutreClient = new(vehicule, client, EtatEnum.EN_ETAT_D_USAGE, EtatEnum.EN_ETAT_D_USAGE, dateDebut, dateFin, "");
            locationRepository.Save(locationAutreClient);

            Assert.Throws<VehiculeIndisponibleException>(() => louerUnVehicule.Louer("2", "13", dateDebut, dateFin));

        }

        [Test]
        public void LocationDeVehiculeDatesInvalides()
        {
            Client client = new("Dabin", "Mégane", true, new DateTime(1997, 12, 3), "0123456789", "Paris");
            Vehicule vehicule = new("DJ555LR", "Peugeot", "106", 182000, DateTime.Now, VehiculeDisponibiliteEnum.DISPONIBLE, EtatEnum.EN_ETAT_D_USAGE, "Essence",
                new DateTime(2020, 3, 3), VehiculeForfaitEnum.A, VehiculeCategorieEnum.BERLINE, 6, null);
            clientRepository.Add("13", client);
            vehiculeRepository.Add("2", vehicule);

            DateTime dateDebut = new(1994, 6, 7);
            DateTime dateFin = new(1993, 6, 8);

            Assert.Throws<DateInvalidException>(() => louerUnVehicule.Louer("2", "13", dateDebut, dateFin));
        }

        [Test]
        public void LocationDeVehiculeClientSansPermis()
        {
            Client client = new("Dabin", "Mégane", false, new DateTime(1997, 12, 3), "0123456789", "Paris");
            Vehicule vehicule = new("DJ555LR", "Peugeot", "106", 182000, DateTime.Now, VehiculeDisponibiliteEnum.DISPONIBLE, EtatEnum.EN_ETAT_D_USAGE, "Essence",
                new DateTime(2020, 3, 3), VehiculeForfaitEnum.A, VehiculeCategorieEnum.BERLINE, 6, null);

            clientRepository.Add("13", client);
            vehiculeRepository.Add("2", vehicule);

            DateTime dateDebut = new(1993, 6, 7);
            DateTime dateFin = new(1993, 6, 8);

            Assert.Throws<PermisClientInvalidException>(() => louerUnVehicule.Louer("2", "13", dateDebut, dateFin));
        }

    }
}