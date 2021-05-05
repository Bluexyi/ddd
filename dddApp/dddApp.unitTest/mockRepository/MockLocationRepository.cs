using dddApp.model;
using System;
using System.Collections.Generic;

namespace dddApp.unitTest.mockRepository
{
    public class MockLocationRepository : LocationRepository
    {
        private static Dictionary<string, Location> dataBase = new();

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
