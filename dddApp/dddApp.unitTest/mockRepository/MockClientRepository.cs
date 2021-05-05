using dddApp.model;
using System.Collections.Generic;

namespace dddApp.unitTest.mockRepository
{

    public class MockClientRepository : ClientRepository
    {
        public static Dictionary<string, Client> DataBase { get; set; } = new Dictionary<string, Client>();

        public Client GetById(string clientId)
        {
            bool found = DataBase.TryGetValue(clientId, out Client result);
            return found ? result : null;
        }

        public void Add(string id, Client client)
        {
            DataBase.Add(id, client);
        }

    }
}
