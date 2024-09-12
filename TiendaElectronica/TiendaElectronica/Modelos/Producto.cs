namespace TiendaElectronica.Modelos
{
    public class Producto
    {
        private string _nombre;
        private double _precio;
        private string _codigo;
        public string Nombre => _nombre;
        public double Precio => _precio;
        public string Codigo => _codigo;

        public Producto(string nombre, double precio, string codigo)
        {
            _nombre = nombre;
            _precio = precio;
            _codigo = codigo;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine("Detalles del Producto:");
            Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio:C}, Codigo: {Codigo}\n");
        }
    }
}
