using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExam
{
    public class Empleado : Persona, ICalculable
    {
        public int Salario {  get; set; }

        public Empleado(string nombre, int edad, string direccion, int salario )
            : base(nombre, edad, direccion)
        {
            this.Salario = salario; 
        }
        public void CalcularSalario()
        {
            int salarioTotal = Salario * 30;
            Console.WriteLine($"Salario es: {salarioTotal}");
        }
        public override async Task MostrarInformacion()
        {
            //metodo asyncronomo de persona
            await base.MostrarInformacion();
            Console.WriteLine("Calculando Salario...");
            await Task.Delay(2000);
            CalcularSalario();
            
        }
       




    }
}
