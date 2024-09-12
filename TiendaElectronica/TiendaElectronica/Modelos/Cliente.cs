namespace TiendaElectronica.Modelos
{
    public class Cliente
    {
        private string _nombre;
        private double _telefono;
        private string _codigo;
        public string Nombre => _nombre;
        public double Telefono => _telefono;
        public string Codigo => _codigo;

        public Cliente (string nombre, double telefono, string codigo)
        {
            _nombre = nombre;
            _telefono = telefono;
            _codigo = codigo;
        }

        public void MostrarCliente()
        {
            Console.WriteLine("Detalles del cliente:");
            Console.WriteLine($"Nombre: {Nombre}, Telefono: {Telefono}, Codigo: {Codigo}\n");
        }
    }
}
