using System.Collections.Generic;

namespace dddApp.model
{
    public interface LocationRepository
    {
        void Save(Location location);
        IEnumerable<Location> GetAll();

        void Update(string locationId, Location location);
        Location GetById(string locationId);
    }
}
