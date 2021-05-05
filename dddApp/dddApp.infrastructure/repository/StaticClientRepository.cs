using dddApp.model;
using System.Collections.Generic;

namespace dddApp.infrastructure.repository
{

    public class StaticClientRepository : ClientRepository
    {
        private static Dictionary<string, Client> dataBase = new Dictionary<string, Client>();

        public Client GetById(string clientId)
        {
            bool found = dataBase.TryGetValue(clientId, out Client result);
            return found ? result : null;
        }
    }
}
