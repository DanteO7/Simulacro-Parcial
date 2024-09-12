using EmpresaTaxi.Modelos;
using EmpresaTaxi.Enums;

public class Program
{
    static void Main()
    {

        Conductor conductor = new Conductor("Carlos Gómez", "XYZ1234");

        Pasajero pasajero = new Pasajero("Laura Sánchez", "Calle 123", true, conductor);

        Viaje viaje = new Viaje(pasajero, TipoVehiculo.Estandar, 15);

        pasajero.SolicitarViaje(viaje);

        viaje.TerminarViaje();
    }
}
