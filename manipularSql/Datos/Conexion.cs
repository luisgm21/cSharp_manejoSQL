using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace manipularSql.Datos
{
    internal class Conexion
    {
        SqlConnection con;

        public Conexion()
        {
            con = new SqlConnection("Server=localhost;Database=empleado_db;integrated security=true");
        }

        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            } catch(Exception ex)
            {
                return null;
            }
        }
        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }


}
