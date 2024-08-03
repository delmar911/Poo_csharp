using Ejercicios.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Entity
{
    internal class Empleado : IEmpleado
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad {  get; set; }
        public string Puesto { get; set; }
        public int Salario { get; set; }

        public Empleado(int id, string nombrecompleto, int edad, string puesto, int salario)
        {
            Id = id;
            NombreCompleto = nombrecompleto;
            Edad = edad;
            Puesto = puesto;
            Salario = salario;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {NombreCompleto}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Puesto: {Puesto}");
            Console.WriteLine($"Salario: {Salario:C}");
        }


    }
}
