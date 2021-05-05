namespace dddApp.model
{
    public interface ClientRepository
    {

        Client? GetById(string clientId);
    }
}
