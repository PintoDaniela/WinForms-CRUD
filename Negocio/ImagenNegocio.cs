using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listar(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, UrlImagen from Imagenes where idArticulo = "+idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdArticulo = idArticulo;
                    aux.ImagenUrl = (string)datos.Lector["UrlImagen"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void agregar(Imagen nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.IdArticulo + "', '" + nuevo.ImagenUrl + "')";
                datos.setearConsulta("insert into Imagenes (IdArticulo, UrlImagen)" + valores);
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(Imagen nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Imagenes set IdArticulo = @IdArticulo, UrlImagen = @UrlImagen where Id = @Id");
                datos.setearParametro("@IdArticulo", nuevo.IdArticulo);
                datos.setearParametro("@UrlImagen", nuevo.ImagenUrl);
                datos.setearParametro("@Id", nuevo.Id);
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from Imagenes where Id = " + id);
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
