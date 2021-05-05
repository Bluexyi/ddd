using dddApp.model;
using System.Collections.Generic;

namespace dddApp.infrastructure.repository
{

    public class StaticAgenceRepository : AgenceRepository
    {
        private static readonly Dictionary<string, Agence> dataBase = new();

        public Agence GetById(string agenceId)
        {
            bool found = dataBase.TryGetValue(agenceId, out Agence result);
            return found ?result:null;
        }

      
    }
}
