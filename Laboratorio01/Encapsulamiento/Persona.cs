using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Encapsulamiento
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private int ID;

        public string Nombre
        {
            get { return nombre; } //devuelve lo almacenado en nombre
            set { nombre = value; } //cuando se asigna un valor se almacena en nombre 
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }


    }
}
