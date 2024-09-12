namespace TiendaElectronica.Modelos
{
    public class Venta
    {
        private DateTime _fecha;
        private Producto _productoVendido;
        private int _cantidad;
        private Cliente _cliente;
        public DateTime Fecha => _fecha;
        public Producto ProductoVendido => _productoVendido;
        public int Cantidad => _cantidad;
        public Cliente Cliente => _cliente;

        public Venta(DateTime fecha, Producto productoVendido, int cantidad, Cliente cliente)
        {
            _fecha = fecha;
            _productoVendido = productoVendido;
            _cantidad = cantidad;
            _cliente = cliente;
        }

        public double CalcularTotal()
        {
            return ProductoVendido.Precio * _cantidad;
        }

        public string MostrarVenta()
        {
            return $"Detalles de la venta:\nFecha: {Fecha}, Cantidad: {Cantidad}, Precio: {CalcularTotal():C}";
        }
    }
}
