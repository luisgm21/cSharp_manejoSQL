using manipularSql.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace manipularSql.Datos
{
    internal class EmpleadoCAD
    {
        public static bool guardar(Empleado empleado)
        {
            try
            {
                var conexion = new Conexion();
                string sql = $"INSERT INTO\ttb_empleado VALUES('{empleado.Documento}','{empleado.Nombres}','{empleado.Apellidos}',{empleado.Edad},'{empleado.Direccion}','{empleado.Fecha_nacimiento}');";
                return true;
            } catch(Exception ex)
            {
                return false;
            }
        }
    }
}
