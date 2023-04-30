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
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLLOCAL; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id,  A.Codigo, A.Nombre, A.Precio, A.Descripcion, C.Descripcion as Categoria, M.Descripcion as Marca FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdCategoria = C.Id AND A.IdMarca = M.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.Id = lector.GetInt32(0);
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];                    
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];                   

                    lista.Add(aux);                    
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex) 
            { 
                throw ex;
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
