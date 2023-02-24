using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DataAccessLibrary
{
    public sealed class SqlDataAccess
    {
        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();
            return rows;
        }

        public void SaveData<U>(string sqlStatement, U parameters, string connectionString)
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            connection.Execute(sqlStatement, parameters);
        }

        public T SaveDataWithReurnId<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            T returnId = connection.QuerySingleOrDefault<T>(sqlStatement, parameters);
            return returnId;
        }
    }
}
