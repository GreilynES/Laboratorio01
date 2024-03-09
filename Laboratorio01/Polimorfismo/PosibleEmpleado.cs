using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Polimorfismo
{
    public class PosibleEmpleado : Persona, IPosibleTrabajadorPoli
    {
        public string Experiencia { get; set; }

        public void AgregarTrabajador()
        {
            Console.WriteLine("Agregar candidato: ");
        }
    }
}
