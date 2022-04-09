using EMPLEADOSDIRECTORIO.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EMPLEADOSDIRECTORIO.DATOS
{
    class EmpleadoCAD
    {
        public static bool guardar(Empleado e)
        {
            try
            {
                CONEXION con = new CONEXION();
                string sql = "insert into TB_EMPLEADOS values('" + e.Documentos + "','" + e.Nombres + "', '" + e.Apellidos + "', '" + e.Fecha + "', '" + e.Hora + "')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int Cantidad = comando.ExecuteNonQuery();
                if (Cantidad == 1)
                {
                    return true;
                }
                else return false;
                con.desconectar();
            }
            catch (Exception em)
            {
                return false;
            }
        }

        public static DataTable listar()
        {
            try
            {
                CONEXION con = new CONEXION();
                string sql = "select * from TB_EMPLEADOS ";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.desconectar();
                return dt;
            }
            catch (Exception em)
            {
                return null;
            }
        }


        internal static bool guardar(object ex)
        {
            throw new NotImplementedException();
        }
    }
}
