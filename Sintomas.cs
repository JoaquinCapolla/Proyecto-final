using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_final
{
    public class Sintoma
    {
        string codigo_sintoma;
        string descripcion_sintoma;

        public string Codigo_sintoma { get => codigo_sintoma; set => codigo_sintoma = value; }
        public string Descripcion_sintoma { get => descripcion_sintoma; set => descripcion_sintoma = value; }
    }
}