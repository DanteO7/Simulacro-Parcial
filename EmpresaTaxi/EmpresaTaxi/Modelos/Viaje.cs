using EmpresaTaxi.Enums;
using System.Collections.Concurrent;

namespace EmpresaTaxi.Modelos
{
    public class Viaje
    {
        private Pasajero _pasajero;
        private TipoVehiculo _tipoVehiculo;
        private double _distancia;
        private double _precio;
        public Pasajero Pasajero => _pasajero;
        public TipoVehiculo TipoVehiculo => _tipoVehiculo;
        public double Distancia => _distancia;
        public double Precio
        {
            get
            {
                double precioDistancia = 2 * _distancia;
                double precioBase = 10 + precioDistancia;
                if (_pasajero.IsMiembro)
                {
                    return precioBase - precioBase * 0.10;
                }
                return precioBase;
            }
        }
        public Viaje(Pasajero pasajero, TipoVehiculo tipoVehiculo, double distancia)
        {
            _pasajero = pasajero;
            _tipoVehiculo = tipoVehiculo;
            _distancia = distancia;
        }
        
        public void MostrarDetalles()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Detalles del viaje:");
            Console.WriteLine($"Pasajero: {Pasajero.Nombre}");
            Console.WriteLine($"Conductor: {Pasajero.Conductor.Nombre}");
            Console.WriteLine($"Tipo de Vehiculo: {TipoVehiculo.ToString()}");
            Console.WriteLine($"Distancia: {Distancia}Km");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine("-------------------------------");
        }

        public void TerminarViaje()
        {
            Pasajero.Conductor.CambiarEstado();
        }
    }
}
