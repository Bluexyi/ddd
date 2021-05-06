using dddApp.model;
using System.Collections.Generic;

namespace dddApp.unitTest.mockRepository
{

    public class MockClientRepository : ClientRepository
    {
        private readonly Dictionary<string, Client> dataBase = new();

        public Client GetById(string clientId)
        {
            bool found = dataBase.TryGetValue(clientId, out Client result);
            return found ? result : null;
        }

        public void Add(string id, Client client)
        {
            dataBase.Add(id, client);
        }

    }
}
