using dddApp.model;
using dddApp.unitTest.mockRepository;
using dddApp.useCase;
using NUnit.Framework;

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

            louerUnVehicule = new LouerUnVehicule(clientRepository, vehiculeRepository, agenceRepository, locationRepository);
        }

        [Test]
        public void Test1()
        {
            clientRepository.Add("13", new Client { permisValide = true });
            vehiculeRepository.Add("2", new Vehicule { disponibilite = "disponible" });
            Assert.IsNotNull(louerUnVehicule.Louer("2", "13", new System.DateTime(1993,6,7), new System.DateTime(1993, 6, 8), "BON"));
        }

    }
}