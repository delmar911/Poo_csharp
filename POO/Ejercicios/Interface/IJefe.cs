using System;

namespace Ejercicios.Entity
{
    public interface IJefe : IEmpleado
    {
        string Area { get; set; }
        void TomarDecisiones();
    }
}