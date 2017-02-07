namespace ConnectionCamaleonDataStudio
{
    public interface IConnection
    {
        void Connect(string connectionString);

        void Disconnect();

        ExecuteResult GetResult(string command);
    }
}
