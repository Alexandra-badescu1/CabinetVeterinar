using Laborator1.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Laborator1.Repository
{
    internal class RepositoryCabinet : IRepository<Cabinet>
    {
        private SqlConnection connection;
        public RepositoryCabinet(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
        }

        public void Add(Cabinet o)
        {
            SqlCommand command = new SqlCommand("INSERT INTO cabinet" +
                "(id_cabinet,tip_cabinet) Values"+
                "(@id_cabinet,@tip_cabinet)",connection);
            command.Parameters.AddWithValue("@id_cabinet",o.Id);
            command.Parameters.AddWithValue("tip_cabinet",o.Tip_cabinet);
            command.ExecuteNonQuery();

        }
        public void Delete(int id)
        {
            SqlCommand removeCmd = new SqlCommand("DELETE FROM cabinet " +
                "WHERE id_cabinet = @id", connection);
            removeCmd.Parameters.AddWithValue("@id", id);
            removeCmd.ExecuteNonQuery();
        }

        public Cabinet FindById(int id)
        {
            SqlCommand findByIDCommand = new SqlCommand("SELECT * FROM cabinet " +
                "WHERE id_cabinet = @id", connection);
            findByIDCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = findByIDCommand.ExecuteReader();
            if (reader.Read())
            {
                string tip_cabinet = reader.GetString(1);
                Cabinet cabinet=new Cabinet(id,tip_cabinet);
                return cabinet;
            }
            reader.Close();
            return null;

        }

        public IEnumerable<Cabinet> GetAll()
        {
            SqlCommand getAll = new SqlCommand("Select * from Cabinet", connection);
            SqlDataReader reader = getAll.ExecuteReader();
            HashSet<Cabinet> cabinet = new HashSet<Cabinet>();
            while (reader.Read())
            {
                int id_cabinet = reader.GetInt32(0);
                String tip_cabinet = reader.GetString(1);
                Cabinet cabinet1 = new Cabinet(id_cabinet, tip_cabinet);
                cabinet.Add(cabinet1);
            }
            reader.Close();
            return cabinet;
        }

        public void Update( Cabinet o2)
        {
            SqlCommand updateCmd = new SqlCommand("UPDATE id_cabinet tip_cabinet " +
                "SET id_cabinet = @id  tip_cabinet = @tip " +
                "FROM SECTIE WHERE id_cabinet = @id ");
            updateCmd.Parameters.AddWithValue("@id", o2.Id);
            updateCmd.Parameters.AddWithValue("@tip", o2.Tip_cabinet);
            updateCmd.ExecuteNonQuery();
        }
    }
}
