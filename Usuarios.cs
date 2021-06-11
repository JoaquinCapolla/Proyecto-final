using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_final
{
    public class Usuarios
    {
        string usuario;
        string contraseña;
        int nivel;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Nivel { get => nivel; set => nivel = value; }
    }
}