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
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id,  A.Codigo, A.Nombre, A.Descripcion, C.Descripcion as Categoria, M.Descripcion as Marca, I.ImagenUrl as Imagen FROM ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I WHERE A.IdCategoria = C.Id AND A.IdMarca = M.Id AND A.Id = I.IdArticulo";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.Id = lector.GetInt32(0);
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    Categoria categoria = new Categoria();
                    aux.Categoria.Nombre = (string)lector["Categoria"];
                    Marca marca = new Marca();
                    aux.Marca.Nombre = (string)lector["Marca"];                   
                    Imagen img = new Imagen();
                    aux.Imagen.UrlImagen = (string)lector["Imagen"];


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


    }
}
