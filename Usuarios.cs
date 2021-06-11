using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_final
{
    public class Usuarios
    {
        string usuario;
        string contrasena;
        int nivel;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int Nivel { get => nivel; set => nivel = value; }
    }
}