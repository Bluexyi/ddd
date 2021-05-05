using dddApp.model;
using System.Collections.Generic;

namespace dddApp.infrastructure.repository
{

    public class StaticVehiculeRepository : VehiculeRepository
    {
        private static readonly Dictionary<string, Vehicule> dataBase = new();

        public Vehicule GetById(string vehiculeId)
        {
            bool found = dataBase.TryGetValue(vehiculeId, out Vehicule result);
            return found ?result:null;
        }

      
    }
}
