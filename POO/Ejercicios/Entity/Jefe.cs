using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Entity
{
    internal class Jefe: Empleado
    {
        public string Area { get; set; }
        public Jefe(int id, string nombreCompleto, int edad, string puesto, int salario, string area)
           : base(id, nombreCompleto, edad, puesto, salario)
        {
            Area = area;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Area: {Area}");
        }

        public void TomarDecisiones()
        {
            Console.WriteLine($"{NombreCompleto} está tomando decisiones importantes.");
        }

    }
}
