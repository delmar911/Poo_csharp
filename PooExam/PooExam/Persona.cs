using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExam
{//1
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        public Persona(string nombre, int edad, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }
        //2
        public Persona()
        {
            Nombre = "Mar";
            Edad = 18;
            Direccion = "Cra 9 #27 - 17 cambulos";
        } //3
        //Permite que el método sea sobrescrito por otra clase
        public virtual async Task MostrarInformacion()
        {
            Console.WriteLine("Cargando información de la persona...");
            await Task.Delay(2000);
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
        }
    }
    
}
