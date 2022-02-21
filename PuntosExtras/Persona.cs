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
        public Persona()
        {
            Nombre = string.Empty;
            Genero = string.Empty;
           

        }
    }
}
