using dddApp.model;
using System;
using System.Collections.Generic;

namespace dddApp.infrastructure.repository
{
    public class StaticLocationRepository : LocationRepository
    {
        private static Dictionary<string, Location> dataBase = new Dictionary<string, Location>();
        public void Save(Location location)
        {
            string id = Guid.NewGuid().ToString();
            dataBase.Add(id, location);
        }
    }
}
