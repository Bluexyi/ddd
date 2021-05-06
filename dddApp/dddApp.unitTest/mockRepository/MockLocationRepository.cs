using dddApp.model;
using System;
using System.Collections.Generic;

namespace dddApp.unitTest.mockRepository
{
    public class MockLocationRepository : LocationRepository
    {
        private readonly Dictionary<string, Location> dataBase = new();

        public IEnumerable<Location> GetAll()
        {
            return dataBase.Values;
        }

        public Location GetById(string locationId)
        {
            bool found = dataBase.TryGetValue(locationId, out Location result);
            return found ? result : null;
        }

        public void Save(Location location)
        {
            string id = Guid.NewGuid().ToString();
            dataBase.Add(id, location);
        }

        public void Update(string locationId, Location location)
        {
            if (dataBase.ContainsKey(locationId))
            {
                dataBase[locationId] = location;
            }
        }
    }
}
