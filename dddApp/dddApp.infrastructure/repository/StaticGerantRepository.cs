using dddApp.model;
using System.Collections.Generic;

namespace dddApp.infrastructure.repository
{

    public class StaticGerantRepository : GerantRepository
    {
        private static Dictionary<string, Gerant> dataBase = new Dictionary<string, Gerant>();
    }
}
