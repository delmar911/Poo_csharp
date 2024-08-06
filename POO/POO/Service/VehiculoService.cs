using POO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Service
{
    public class VehiculoService
    {
        public async Task<string> ObtenerInformacionVehiculo(Vehiculo vehiculo)
        {
            Console.WriteLine("Obteniendo información del vehículo...");
            await Task.Delay(2000); //2 segundos
            return $"Vehículo: {vehiculo.Marca} {vehiculo.Nombre}, Placa: {vehiculo.Placa}";
        }
    }
}
