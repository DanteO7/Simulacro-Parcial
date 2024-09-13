﻿namespace EmpresaTaxi.Modelos
{
    public class Pasajero
    {
        private string _nombre;
        private string _direccion;
        private bool _isMiembro;
        private Conductor? _conductor;
        public string Nombre => _nombre;
        public string Direccion => _direccion;
        public bool IsMiembro => _isMiembro;
        public Conductor? Conductor => _conductor;
        public Pasajero(string nombre, string direccion, bool isMiembro)
        {
            _nombre = nombre;
            _direccion = direccion;
            _isMiembro = isMiembro;
        }
        
        public void SolicitarViaje(Viaje viaje, Conductor conductor)
        {
            if (!conductor.IsDisponible)
            {
                throw new Exception("El conductor debe estar disponible");
            }
            _conductor = conductor;
            _conductor.CambiarEstado();
            viaje.MostrarDetalles();
        }
    }
}
