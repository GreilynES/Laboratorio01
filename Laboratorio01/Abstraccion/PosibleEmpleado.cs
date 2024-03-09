using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Abstraccion
{
    public class PosibleEmpleado : IPosibleEmpleado
    {
        public string Experiencia { get; set; }

        public void AgregarPosibleEmpleado()
        {
            Console.WriteLine("Agregar candidato: ");
        }

        public void EliminarPosibleEmpleado()
        {

        }

        public void ActualizarPosibleEmpleado()
        {

        }

    }
}
