using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios.Entity

// Clase base
public class Vehiculo
{//se aplica giet and set
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public int Sillas { get; set; }
    public int Puertas { get; set; }
    public int Ruedas { get; set; }
    public string Color { get; set; }
    public string Placa { get; set; }

    // Constructor de la clase base
    public Vehiculo(string nombre, string marca, int sillas, int puertas, int ruedas, string color, string placa)
    {
        Nombre = nombre;
        Marca = marca;
        Sillas = sillas;
        Puertas = puertas;
        Ruedas = ruedas;
        Color = color;
        Placa = placa;
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Nombre: {Nombre}, Marca: {Marca}, Sillas: {Sillas}, Puertas: {Puertas}, Ruedas: {Ruedas}, Color: {Color}, Placa: {Placa}");
    }

}