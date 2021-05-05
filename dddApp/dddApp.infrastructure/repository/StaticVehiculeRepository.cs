using dddApp.model;
using System.Collections.Generic;

namespace dddApp.infrastructure.repository
{

    public class StaticVehiculeRepository : VehiculeRepository
    {
        private static Dictionary<string, Vehicule> dataBase = new Dictionary<string, Vehicule>();

        public Vehicule GetById(string vehiculeId)
        {
            bool found = dataBase.TryGetValue(vehiculeId, out Vehicule result);
            return found ?result:null;
        }

      
    }
}
