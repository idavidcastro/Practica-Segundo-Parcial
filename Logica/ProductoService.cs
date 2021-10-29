using Datos;
using Entidad;
using System;

namespace Logica
{
    public class ProductoService
    {
        ProductoRepository ProductoRepository;
        public ProductoService()
        {
            ProductoRepository = new ProductoRepository();
        }

        public string Guardar(Producto producto)
        {
            try
            {
                ProductoRepository.Guardar(producto);
                return "Se guardaron los datos correctamente";
            }
            catch (Exception e)
            {
                return "ERROR!" + e.Message;
            }

        }
        //error
        public ProductoService Consultar(dd)
        {
            try
            {
                return new ProductoService(ProductoRepository.Consultar());
            }
            catch (Exception e)
            {
                return new ProductoService("ERROR!" + e.Message);
            }
        }
        */
        
        public ProductoConsultaResponse ConsultarPorEstado(string estado)
        {
            try
            {
                return new ProductoConsultaResponse(ProductoRepository.ConsultarPorEstado(estado));
            }
            catch (Exception e)
            {
                return new ProductoConsultaResponse("ERROR!" + e.Message);
            }
        }


        */
    }
}
