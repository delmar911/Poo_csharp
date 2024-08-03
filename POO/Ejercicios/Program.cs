using Ejercicios.Entity;
using Ejercicios.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmpleado empleado = new Empleado(1, "Maria Del Mar", 18, "Desarrolladora de Software", 3000);

            // Mostrar la información del empleado
            empleado.MostrarInformacion();
        }
    }
}
