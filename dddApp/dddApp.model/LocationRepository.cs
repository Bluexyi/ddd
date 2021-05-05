using System.Collections.Generic;

namespace dddApp.model
{
    public interface LocationRepository
    {
        void Save(Location location);
        IEnumerable<Location> GetAll();
    }
}
