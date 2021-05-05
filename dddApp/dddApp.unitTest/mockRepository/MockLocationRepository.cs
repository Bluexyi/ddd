using dddApp.model;
using System;
using System.Collections.Generic;

namespace dddApp.unitTest.mockRepository
{
    public class MockLocationRepository : LocationRepository
    {
        public static Dictionary<string, Location> dataBase = new Dictionary<string, Location>();
        public void Save(Location location)
        {
            string id = Guid.NewGuid().ToString();
            dataBase.Add(id, location);
        }
    }
}
