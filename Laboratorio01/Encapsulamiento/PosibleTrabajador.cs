using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Encapsulamiento
{
    public class PosibleTrabajador : Persona
    {
        private string Experiencia;

        public string experiencia
        {
            get { return Experiencia; }
            set { Experiencia = value; }
        }

    }
}
