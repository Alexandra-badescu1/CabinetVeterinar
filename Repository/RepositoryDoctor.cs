using Laborator1.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1.Repository
{
    internal class RepositoryDoctor : IRepository<Doctor>
    {
        private SqlConnection connection;
        public RepositoryDoctor(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
        }

        public void Add(Doctor o)
        {
            SqlCommand add = new SqlCommand("INSERT INTO doctor "+
                "(id_doctor,nume,specializare,id_cabinet) Values"+
                "(@id_doctor,@nume,@specializare,@id_cabinet)", connection);
            add.Parameters.AddWithValue("@id_doctor",o.Id);
            add.Parameters.AddWithValue("@nume",o.Nume);
            add.Parameters.AddWithValue("@specializare",o.Specializare);
            add.Parameters.AddWithValue("@id_cabinet",o.Id_cabinet);
            add.ExecuteNonQuery();

        }

        public void Delete(int id)
        {
            SqlCommand deletecommand = new SqlCommand("DELETE FROM doctor "+
                "WHERE id_doctor = @id_doctor",connection);
            deletecommand.Parameters.AddWithValue("@id_doctor",id);
            deletecommand.ExecuteNonQuery();
        }

        public IEnumerable<Doctor> GetAll()
        {
            SqlCommand selectCommand = new SqlCommand("Select * from doctor ", connection);
            SqlDataReader reader = selectCommand.ExecuteReader();
            HashSet<Doctor> doctors = new HashSet<Doctor>();
            while (reader.Read())
            {
                int id_doctor = reader.GetInt32(0);
                String name = reader.GetString(1);
                String specialitate = reader.GetString(2);
                int id_cabinet = reader.GetInt32(3);
                Doctor doc = new Doctor(id_doctor, name, specialitate, id_cabinet);
                doctors.Add(doc);
                
            }
            reader.Close();
            return doctors;
        }

        public void Update(Doctor o2)
        {
            SqlCommand updatecomand = new SqlCommand("UPDATE doctor "+
                "SET nume = @nume, specializare = @specializare, id_cabinet = @id_cabinet "
                +"From doctor WHERE id_doctor = @id ",connection);
            updatecomand.Parameters.AddWithValue("@id", o2.Id);
            updatecomand.Parameters.AddWithValue("@nume", o2.Nume);
            updatecomand.Parameters.AddWithValue("@specializare", o2.Specializare);
            updatecomand.Parameters.AddWithValue("@id_cabinet", o2.Id_cabinet);
            updatecomand.ExecuteNonQuery();
        }

        public Doctor FindById(int id)
        {
            SqlCommand findByIDCommand = new SqlCommand("SELECT * FROM doctor " +
                "WHERE id_doctor = @id", connection);
            findByIDCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = findByIDCommand.ExecuteReader();
            if (reader.Read())
            {
                string nume = reader.GetString(1);
                string specializare = reader.GetString(2);
                int id_cabinet = reader.GetInt32(3);
                Doctor doc = new Doctor(id,nume,specializare,id_cabinet);
                return doc;
            }
            reader.Close();
            return null;
        }
    }
}
