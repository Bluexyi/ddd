using dddApp.model;
using System.Collections.Generic;

namespace dddApp.unitTest.mockRepository
{

    public class MockVehiculeRepository : VehiculeRepository
    {
        private Dictionary<string, Vehicule> DataBase = new Dictionary<string, Vehicule>();

        public Vehicule GetById(string vehiculeId)
        {
            bool found = DataBase.TryGetValue(vehiculeId, out Vehicule result);
            return found ?result:null;
        }

        public void Add(string id, Vehicule vehicule)
        {
            DataBase.Add(id, vehicule);
        }

      
    }
}
