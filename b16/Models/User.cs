using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b16.Models
{
    internal class User
    {
        internal static DataTable All()
        {
            DataTable dt = new DataTable();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=vinacantik28;Database=girls_need;Port=5432");
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM users", conn);
            da.Fill(dt);
            conn.Close();

            return dt;
        }
    }
}
