using dddApp.model;
using System.Collections.Generic;

namespace dddApp.unitTest.mockRepository
{
    public class MockTechnicienRepository : TechnicienRepository
    {
        private Dictionary<string, Technicien> dataBase = new Dictionary<string, Technicien>();
    }
}
