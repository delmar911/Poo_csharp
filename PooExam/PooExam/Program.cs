using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExam
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Persona empleado1 = new Empleado("Maria Del Mar", 18, "Calle 19", 100000);

            // Llama al método asincrónico para mostrar la información y espera su resultado
            await empleado1.MostrarInformacion();
        }
    }
}
