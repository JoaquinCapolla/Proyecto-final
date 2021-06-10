using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_final
{
    public class Agenda
    {
        string nit_paciente;
        DateTime fecha;
        string hora_inicio;
        string hora_fin;

        public string Nit_paciente { get => nit_paciente; set => nit_paciente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Hora_inicio { get => hora_inicio; set => hora_inicio = value; }
        public string Hora_fin { get => hora_fin; set => hora_fin = value; }
    }
}