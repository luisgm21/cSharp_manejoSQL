using System;
using System.Collections.Generic;
using System.Text;

namespace manipularSql.Modelo
{
    internal class Empleado
    {
        private string documento;
        private string nombres;
        private string apellidos;
        private int edad;
        private string direccion;
        private string fecha_nacimiento;

        public Empleado()
        {
            this.documento = "";
            this.nombres = "";
            this.apellidos = "";
            this.edad = 0;
            this.direccion = "";
            this.fecha_nacimiento = "";
        }

        public Empleado(string documento, string nombres, string apellidos, int edad, string direccion, string fecha_nacimiento)
        {
            this.documento = documento;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
            this.direccion = direccion;
            this.fecha_nacimiento = fecha_nacimiento;
        }

        public string Documento { get => documento; set => documento = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
    }
}
