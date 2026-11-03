using System;
using Microsoft.Data.Sqlite;

namespace OficinaSAEP.Database;
internal class ConexaoSqLite
{
    private readonly string _connectionString = "Data Source=Database/Oficina.db";

    public SqliteConnection ObterConexao()
    {
        return new SqliteConnection(_connectionString);
    }

}
