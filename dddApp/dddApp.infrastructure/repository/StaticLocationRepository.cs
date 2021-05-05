using dddApp.model;
using System;
using System.Collections.Generic;

namespace dddApp.infrastructure.repository
{
    public class StaticLocationRepository : LocationRepository
    {
        private static readonly Dictionary<string, Location> dataBase = new();

        public IEnumerable<Location> GetAll()
        {
            return dataBase.Values;
        }

        public void Save(Location location)
        {
            string id = Guid.NewGuid().ToString();
            dataBase.Add(id, location);
        }
    }
}
