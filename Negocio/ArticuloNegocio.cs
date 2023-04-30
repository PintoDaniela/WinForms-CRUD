using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Xml.Linq;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {               
                datos.setearConsulta("SELECT A.Id,  A.Codigo, A.Nombre, A.Precio, A.Descripcion, C.Descripcion as Categoria, M.Descripcion as Marca FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdCategoria = C.Id AND A.IdMarca = M.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];                    
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];                   

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


        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();    
             
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria)values(" + nuevo.Codigo + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', '" + nuevo.Precio+ "', '" +nuevo.Marca.Id+ "', '"+nuevo.Categoria.Id+"')");
                datos.ejecutarLectura();
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



        //public void AgregarImagen

        //public void Modificar(Articulo nuevo) { }
        

        //public void Elminar(Articulo nuevo) { }
    }
}
