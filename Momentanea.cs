using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_final
{
    public class Momentanea
    {
        int posi = 0;
        int posihis = 0;
        int editsintomas = 0;
        int editmedicamentos = 0;
        int existhistorial = 0;
        int existpaciente = 0;
        int cont = 0;
        DateTime Fechaconsulta;
        string horadeconsulta;

        public int Posi { get => posi; set => posi = value; }
        public int Posihis { get => posihis; set => posihis = value; }
        public int Editsintomas { get => editsintomas; set => editsintomas = value; }
        public int Editmedicamentos { get => editmedicamentos; set => editmedicamentos = value; }
        public int Existhistorial { get => existhistorial; set => existhistorial = value; }
        public int Existpaciente { get => existpaciente; set => existpaciente = value; }
        public DateTime Fechaconsulta1 { get => Fechaconsulta; set => Fechaconsulta = value; }
        public string Horadeconsulta { get => horadeconsulta; set => horadeconsulta = value; }
        public int Cont { get => cont; set => cont = value; }
    }
}