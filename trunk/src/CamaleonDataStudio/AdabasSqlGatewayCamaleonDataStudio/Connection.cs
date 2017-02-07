using ConnectionCamaleonDataStudio;
using System;

namespace AdabasSqlGatewayCamaleonDataStudio
{
    public class Connection : IConnection
    {
        public void Connect(string connectionString)
        {
            //TODO: Conectar a base de datos
        }

        public void Disconnect()
        {
            //TODO: Desconectar de base de datos
        }

        public ExecuteResult GetResult(string command)
        {
            //TODO: Ejecutar comando en base de datos
            return new ExecuteResult();
        }
    }
}
