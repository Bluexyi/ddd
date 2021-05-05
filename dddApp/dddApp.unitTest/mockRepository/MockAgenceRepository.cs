using dddApp.model;
using System.Collections.Generic;

namespace dddApp.unitTest.mockRepository
{

    public class MockAgenceRepository : AgenceRepository
    {
        public static Dictionary<string, Agence> dataBase = new();

        public Agence GetById(string agenceId)
        {
            bool found = dataBase.TryGetValue(agenceId, out Agence result);
            return found ?result:null;
        }

      
    }
}
