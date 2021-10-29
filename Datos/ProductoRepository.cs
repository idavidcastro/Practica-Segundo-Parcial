using Entidad;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datos
{
    public class ProductoRepository
    {
        public string ruta = "Producto.txt";

        public void Guardar(Producto producto)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{producto.ReferenciaProducto};{producto.NombreProducto};{producto.ExistenciaProducto};{producto.PrecioUnitarioProducto};{producto.Estado};{producto.Cantidad};");

            writer.Close();
            file.Close();
        }
        /*
        //filtrado 
        public List<Producto> Consultar()
        {
            List<Producto> productos = new List<Persona>();
            using (StreamReader reader = new(ruta))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] dato = linea.Split(';');
                    Persona persona = new()
                    {
                        Nombre = dato[0],
                        Identificacion = dato[1],
                        Sexo = dato[2],
                        Edad = int.Parse(dato[3]),
                        Pulsacion = decimal.Parse(dato[4])
                    };
                    personas.Add(persona);
                }
            }
            return personas;
        }
        
        public void Modificar(string id, Persona personaNew)
        {
            List<Persona> personas = Consultar();
            File.Delete(ruta);

            foreach (var item in personas)
            {
                if (!item.Identificacion.Equals(id))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(personaNew);
                }
            }
        }
        public void Eliminar(string id)
        {
            List<Persona> personas = Consultar();
            File.Delete(ruta);

            foreach (var item in personas)
            {
                if (!item.Identificacion.Equals(id))
                {
                    Guardar(item);
                }
            }
        }

        public Persona Buscar(string identificacion)
        {
            List<Persona> personas = Consultar();
            foreach (var item in personas)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }

            }
            return null;
        }
        */
    }

}
