using dddApp.model;
using System.Collections.Generic;

namespace dddApp.infrastructure.repository
{
    public class StaticTechnicienRepository : TechnicienRepository
    {
        private static Dictionary<string, Technicien> dataBase = new Dictionary<string, Technicien>();
    }
}
