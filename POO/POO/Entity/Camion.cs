using POO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entity
{
    public class Camion : Vehiculo, IRecibirFlete, IRecogerCarga
    {
        public int CapacidadCarga { get; set; }
        public int Ejes { get; set; }

        public Camion(string nombre, string marca, int sillas, int puertas, int ruedas, string color, int capacidadCarga, int ejes, string placa)
            : base(nombre, marca, sillas, puertas, ruedas, color, placa)
        {
            CapacidadCarga = capacidadCarga;
            Ejes = ejes;
        }
        public void RecogerCarga() 
        {
            Console.WriteLine("Recogiendo la carga...");
        }
        public void RecibirFlete(int precio)
        {
            Console.WriteLine($"Pagando flete de {precio} unidades monetarias.");
        }
    }
}
