using dddApp.model;
using System.Collections.Generic;

namespace dddApp.unitTest.mockRepository
{

    public class MockGerantRepository : GerantRepository
    {
        public static Dictionary<string, Gerant> dataBase = new Dictionary<string, Gerant>();
    }
}
