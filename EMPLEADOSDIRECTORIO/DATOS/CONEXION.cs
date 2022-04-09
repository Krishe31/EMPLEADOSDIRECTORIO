using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace EMPLEADOSDIRECTORIO.DATOS
{
    class CONEXION
    {
                SqlConnection con;
        public CONEXION()
        {
            con = new SqlConnection("server=krishe\\sqlexpress;database=empleados;intergrated security=true");
        }
        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception e)
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
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

