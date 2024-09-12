namespace EmpresaTaxi.Modelos
{
    public class Conductor
    {
        private string _nombre;
        private string _licencia;
        private bool _isDisponible;
        public string Nombre => _nombre;
        public string Licencia => _licencia;
        public bool IsDisponible => _isDisponible = true;

        public Conductor(string nombre, string licencia)
        {
            _nombre = nombre;
            _licencia = licencia;
        }

        public void CambiarEstado()
        {
            _isDisponible = !_isDisponible;
        }
    }
}
