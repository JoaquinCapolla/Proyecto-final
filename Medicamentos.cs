using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_final
{
    public class Enfermedades
    {
        string enfermedad;

        public string Enfermedad { get => enfermedad; set => enfermedad = value; }
    }
    public class Medicamentos
    {
        string codigo_medicamento;
        string ingrediente_generico;
        string laboratorio;

        List<Enfermedades> enfermedades = new List<Enfermedades>();

        public string Codigo_medicamento { get => codigo_medicamento; set => codigo_medicamento = value; }
        public string Ingrediente_generico { get => ingrediente_generico; set => ingrediente_generico = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
        public List<Enfermedades> Enfermedades { get => enfermedades; set => enfermedades = value; }

        public Medicamentos()
        {
            Enfermedades = new List<Enfermedades>();
        }
    }
}