using dddApp.model;
using System.Collections.Generic;

namespace dddApp.unitTest.mockRepository
{

    public class MockVehiculeRepository : VehiculeRepository
    {
        private readonly Dictionary<string, Vehicule> dataBase = new();

        public Vehicule GetById(string vehiculeId)
        {
            bool found = dataBase.TryGetValue(vehiculeId, out Vehicule result);
            return found ?result:null;
        }

        public void Add(string id, Vehicule vehicule)
        {
            dataBase.Add(id, vehicule);
        }

      
    }
}
