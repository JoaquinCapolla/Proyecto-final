using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_final
{
    public class Pacientes
    {
        string Nit_Paciente;
        string nombre;
        string apellido;
        string direccion;
        DateTime fecha_nacimiento;
        string telefono;

        public string Nit_Paciente1 { get => Nit_Paciente; set => Nit_Paciente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fecha_nacimiento1 { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}