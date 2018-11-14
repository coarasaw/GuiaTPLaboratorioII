using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ejercicio_61
{
    public static class PersonaDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        //private static string cadenaDeConexion;


        //PersonalDAO.cadenaDeConexion = "Data Source=HNPMW12-144\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #region Constructs
        static PersonaDAO()
        {
            PersonaDAO.conexion = new SqlConnection(Properties.Settings.Default.cadenaDeConexion);
            PersonaDAO.comando = new SqlCommand();

            PersonaDAO.comando.CommandType = System.Data.CommandType.Text;
            PersonaDAO.comando.Connection = PersonaDAO.conexion;
        }
        #endregion

        public static bool Guardar(Persona p)
        {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("INSERT INTO Persona (id,nombre,apellido) VALUES('{0}','{1}','{2}');", p.id, p.nombre, p.apellido);
            return EjecutarNonQuery(sb.ToString());   
        }

        /// <summary>
        /// Funcion que ejecuta el non query
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                PersonaDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                PersonaDAO.conexion.Open();

                // EJECUTO EL COMMAND
                PersonaDAO.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    PersonaDAO.conexion.Close();
            }
            return todoOk;
        }

    }
}
