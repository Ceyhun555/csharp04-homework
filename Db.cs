using System.Configuration;
using System.Data.SqlClient;

namespace OrderManagement.Utils
{
    class Db
    {
        public static string Conn = "Server=(localdb)\\mssqllocaldb;Database=OrderDb;Trusted_Connection=True;";
    }
}