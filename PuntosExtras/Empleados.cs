using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntosExtras
{
    class Empleados 
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

      

        public Empleados(string puesto, int edad, int salario, int horas)
        {
            this.puesto = puesto;
            this.edad = edad;
            this.salario = salario;
            this.horas = horas;
        }

        public string getDatosEmpleado()
        {
            return " El Empleado Tiene un Total de horas: " + horas+ " y gana un salario de  " + Salario + "\r\n";
        }
        public string getDatospuesto()
        {
            return " El " + Puesto + " Tiene un Salario de " + Salario + "\r\n";
        }
    }
}
