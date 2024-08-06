using POO.Entity;
using POO.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //se crea la instancia del service y se llama el metodo
            var VehiculoService = new VehiculoService();

            Vehiculo carro1 = new CarroParticular("nombre", "marca", 4, 4, 4, "color", "tipoVaul", true, "placa");
            Camion camion = new Camion("nombre", "marca", 4, 4, 4, "color", 0, 2, "placa"); // Proporcione valores iniciales
            Taxi taxi = new Taxi("nombre", "marca", 4, 4, 4, "color", "tipoVaul", true, "placa", 0); // Proporcione valores iniciales

            CarroParticular carro4 = new CarroParticular("nombre", "marca", 4, 4, 4, "color", "tipoVaul", true, "placa"); // Proporcione valores iniciales
            string placa = CarroParticular.TipoPlaca;

            Console.WriteLine("Bienvenido");

            Console.WriteLine("Seleccione una opcion de acuerdo a su tipo de vehiculo");
            Console.WriteLine("1. Publico");
            Console.WriteLine("2. Particular");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("- Ingrese su cedula");
                        int cedula = int.Parse(Console.ReadLine());
                        Console.WriteLine("- Ingrese la placa de su vehiculo");
                        carro1.Placa = Console.ReadLine();

                        Console.WriteLine("Seleccione una opcion de acuerdo a su tipo de vehiculo");
                        Console.WriteLine("1. Si su vehiculo es de transporte publico \n"
                                          + "2. Si su vehiculo es de carga");

                        int respuesta = int.Parse(Console.ReadLine());
                        if (respuesta == 1)
                        {
                            Console.WriteLine("- Ingrese el numero de pasajeros");
                            taxi.Pasajeros = int.Parse(Console.ReadLine());

                            Console.WriteLine("- Ingrese el color de su vehiculo");
                            carro1.Color = Console.ReadLine();
                            //se llama el metodo async con el await, simula el tiempo de espera
                            string infoTaxi = await VehiculoService.ObtenerInformacionVehiculo(taxi);
                            Console.WriteLine(infoTaxi);

                            Console.WriteLine($"- El numero de pasajeros es = {taxi.Pasajeros}");

                            Console.WriteLine($"Su placa es {carro1.Placa}\n El color de su vehiculo es {carro1.Color}");
                        }
                        else
                        {
                            Console.WriteLine("- Ingrese la capacidad de carga en toneladas");
                            camion.CapacidadCarga = int.Parse(Console.ReadLine());

                            Console.WriteLine("- Ingrese el color de su vehiculo");
                            carro1.Color = Console.ReadLine();

                            string infoCamion = await VehiculoService.ObtenerInformacionVehiculo(camion);
                            Console.WriteLine(infoCamion);

                            Console.WriteLine($"Su placa es {carro1.Placa}\n El color de su vehiculo es {carro1.Color}");
                            Console.WriteLine($"La capacidad de carga del vehiculo es de {camion.CapacidadCarga} Toneladas");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("- Ingrese su cedula");
                        int cedula = int.Parse(Console.ReadLine());
                        Console.WriteLine("- Ingrese la placa de su vehiculo");
                        carro1.Placa = Console.ReadLine();
                        Console.WriteLine("- Ingrese el color de su vehiculo");
                        carro1.Color = Console.ReadLine();
                        Console.WriteLine("- Cuantas sillas de pasajero posee su vehiculo?");
                        carro1.Sillas = int.Parse(Console.ReadLine());

                        string infoCarro = await VehiculoService.ObtenerInformacionVehiculo(carro1);
                        Console.WriteLine(infoCarro);

                        Console.WriteLine($"Su placa es {carro1.Placa}\n El color de su vehiculo es {carro1.Color}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opcion incorrecta");
                        break;
                    }
            }
        }
    }
}
