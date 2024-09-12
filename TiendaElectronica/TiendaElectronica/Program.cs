using TiendaElectronica.Modelos;

public class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Juan", 1234567689, "A513");
        cliente.MostrarCliente();

        Producto producto = new Producto("Laptop", 600, "B759");
        producto.MostrarDetalles();

        Venta venta = new Venta(DateTime.Now, producto, 3, cliente);
        string ventaRealizada = venta.MostrarVenta();
        Console.WriteLine(ventaRealizada);
    }
}