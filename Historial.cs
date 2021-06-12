using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_final
{
    public class Sintomas
    {
        string codigosintoma;
        string sintoma;
        public string Codigosintoma { get => codigosintoma; set => codigosintoma = value; }
        public string Sintoma { get => sintoma; set => sintoma = value; }
    }
    public class Tratamiento
    {
        string receta;
        string Instrucciones;

        public string Receta { get => receta; set => receta = value; }
        public string Instrucciones1 { get => Instrucciones; set => Instrucciones = value; }
    }
    public class Histo
    {
        string diagnostico;
        string proxima_visita;
        string costo_consulta;
        DateTime fecha_consulta;
        string hora_consulta;
        string temperatura;
        string presion;
        List<Tratamiento> tratamiento = new List<Tratamiento>();
        List<Sintomas> sintomas = new List<Sintomas>();

        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Proxima_visita { get => proxima_visita; set => proxima_visita = value; }
        public string Costo_consulta { get => costo_consulta; set => costo_consulta = value; }
        public DateTime Fecha_consulta { get => fecha_consulta; set => fecha_consulta = value; }
        public string Hora_consulta { get => hora_consulta; set => hora_consulta = value; }
        public string Temperatura { get => temperatura; set => temperatura = value; }
        public string Presion { get => presion; set => presion = value; }
        public List<Tratamiento> Tratamiento { get => tratamiento; set => tratamiento = value; }
        public List<Sintomas> Sintomas { get => sintomas; set => sintomas = value; }
        public Histo()
        {
            Tratamiento = new List<Tratamiento>();
            Sintomas = new List<Sintomas>();
        }
    }
    public class Cantidad
    {
        List<Histo> histo = new List<Histo>();

        public List<Histo> Histo { get => histo; set => histo = value; }
        
        public Cantidad()
        {
            Histo = new List<Histo>();
        }
    }
    public class Historial
    {
        string nit_paciente;
        

        List<Cantidad> cantidad = new List<Cantidad>();

        public string Nit_paciente { get => nit_paciente; set => nit_paciente = value; }
        public List<Cantidad> Cantidad { get => cantidad; set => cantidad = value; }

        public Historial()
        {
            Cantidad = new List<Cantidad>();
        }
    }
}