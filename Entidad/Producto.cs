using System;

namespace Entidad
{
    public class Producto
    {
        public Producto(string referenciaProducto, string nombreProducto, string existenciaProducto, decimal precioUnitarioProducto, string estado, int cantidad)
        {
            ReferenciaProducto = referenciaProducto;
            NombreProducto = nombreProducto;
            ExistenciaProducto = existenciaProducto;
            PrecioUnitarioProducto = precioUnitarioProducto;
            Estado = estado;
            Cantidad = cantidad;
        }

        public string ReferenciaProducto { get; set; }
        public string NombreProducto { get; set; }
        public string ExistenciaProducto { get; set; }
        public decimal PrecioUnitarioProducto { get; set; }
        public string Estado { get; set; }
        public int Cantidad { get; set; }

    }
}
