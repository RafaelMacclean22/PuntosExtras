using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntosExtras
{
    class Empleados : Persona
    {
        private int edad;
        private int horas;
        private int salario;
        private  String puesto;

        public  String Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }


        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Empleados(string nombre, string genero, int edad, int horas, int salario, string puesto)
        {
            
            this.Nombre = nombre;
            this.Genero = genero;
            this.edad = edad;
            this.horas = horas;
            this.salario = salario;
            this.puesto = puesto;
        }
        public string getDatosEmpleado()
        {
            return " El Empleado " + Nombre + " Tiene un Salario Inicial de " + Salario + "\r\n";
        }
        public string getDatospuesto()
        {
            return " El " + Puesto + " Tiene un Salario de " + Salario + "\r\n";
        }
    }
}
