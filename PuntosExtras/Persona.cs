using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntosExtras
{
    class Persona
    {
        private string nombre;
        private string genero;
       
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public Persona(string nombre, string genero)
        {
            this.nombre = nombre;
            this.genero = genero;
        }

        public string getDatosCosulta()
        {
            return " El Empleado " + Nombre + " Pertenece al genero " + genero +  "\r\n";
        }
    }
}
