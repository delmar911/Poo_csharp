using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entity
{
    public class CarroParticular : Vehiculo
    {
        private string tipoVaul;
        /*TipoPlaca es estática porque el atributo puede ser usado
        y compartido por todas las instancias de la clase*/
        public static string TipoPlaca;
        private bool techoDesplegable;

        // Constructor sobrecargado
        public CarroParticular(string nombre, string marca, int sillas,
                                int puertas, int ruedas, string color,
                                string tipoVaul, bool techoDesplegable, string placa)
                            : base(nombre, marca, sillas, puertas, ruedas, color, placa) // Llamada al constructor de la clase base
        {
            this.techoDesplegable = techoDesplegable;
            this.tipoVaul = tipoVaul;
        }
    }
}

