using POO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entity
{//se aplica herencia e interface
    public class Taxi : CarroParticular, IRecogerPersonas, IPagarPasaje
    {
        public int Pasajeros { get; set; }

        public Taxi(string nombre, string marca, int sillas, int puertas, int ruedas, string color, string tipoVaul, bool techoDesplegable, string placa, int pasajeros)
            : base(nombre, marca, sillas, puertas, ruedas, color, tipoVaul, techoDesplegable, placa)
        {
            this.Pasajeros = pasajeros;
        }
        public void RecogerPersonas(int numero)
        {
            Console.WriteLine("Recogiendo personas...");

    
        }
        public void PagarPasaje()
        {
            Console.WriteLine("Pagando pasaje...");
        }
    }
   
    
}
