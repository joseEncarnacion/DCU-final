

using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System;

namespace DCU_FINAL_v5_MVC5.Models
{
    public class DBEstudiante
    {
       private SqlConnection _connection;

        public void Connexion()
        {
           

            string con = "Server=.;Database=DCUfinal;Trusted_Connection=True;MultipleActiveResultSets=true";
            _connection = new SqlConnection(con);
        }

        public bool AgregarEstudiante(EntityEstuditiante est)
        {
            Connexion();

            SqlCommand cmd = new SqlCommand("sp_crearEst", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", est.nombre);
            cmd.Parameters.AddWithValue("@corr", est.correo);
            cmd.Parameters.AddWithValue("@tell", est.telefono);
            cmd.Parameters.AddWithValue("@imag", est.Foto);
           
            _connection.Open();
            int i = cmd.ExecuteNonQuery();
            _connection.Close();

            if(i > 0) 
                return true;
            else
                return false;

        }

        //ver contacto

        /// <summary>
        /// Listat los estudiantes
        /// </summary>
        /// <returns></returns>

        public IEnumerable<EntityEstuditiante> ListarEst()
        {
            Connexion();

            List<EntityEstuditiante>ListaEstudiante= new List<EntityEstuditiante>();
            try
            {
                  SqlCommand cmd = new SqlCommand("sp_listarEst", _connection);
                  cmd.CommandType = CommandType.StoredProcedure;
                  _connection.Open();
                  SqlDataReader reader = cmd.ExecuteReader();

                  while(reader.Read())
                  {
                    
                      EntityEstuditiante estudianteModel = new EntityEstuditiante()
                      {
                          idEstudiante = int.Parse(reader[0].ToString()),
                          nombre = reader[1].ToString(),
                          correo = reader[2].ToString(),
                          telefono = reader[3].ToString(),
                          Foto = reader[4].ToString()

                      };
                   
                    ListaEstudiante.Add(estudianteModel);
                  }

            }
            catch(Exception ex)
            {
                
               Console.WriteLine(ex.Message);   
            }
            finally
            {
                _connection.Close();
            }

            return ListaEstudiante;

        }





        /// <summary>
        /// visualizar un registro
        /// </summary>
        /// <returns>models</returns>
        public IEnumerable<EntityEstuditiante> ListarEstUnRegistro(int id)
        {
            Connexion();

            List<EntityEstuditiante> ListaEstudiante = new List<EntityEstuditiante>();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_listarEstJustOne", _connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    EntityEstuditiante estudianteModel = new EntityEstuditiante()
                    {
                        idEstudiante = int.Parse(reader[0]+""),
                        nombre = reader[1].ToString(),
                        correo = reader[2].ToString(),
                        telefono = reader[3].ToString(),
                        Foto = reader[4].ToString()

                    };

                    ListaEstudiante.Add(estudianteModel);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return ListaEstudiante;

        }


        public DataTable buscarloTO(int id)
        {
            Connexion();
            string sql = "select idEstudiante, nombreEst, correoEst, telefono, imagen from estudiante where nombreEst like %{0}%";
            SqlDataAdapter da = new SqlDataAdapter(sql, _connection);
           
            DataTable dt= new DataTable();
            da.Fill(dt);

            return dt;
        }

    }
}
