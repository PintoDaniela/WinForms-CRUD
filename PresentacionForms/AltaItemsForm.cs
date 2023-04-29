using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionForms
{
    public partial class AltaItemsForm : Form
    {
        private Articulo articulo = null;
        // para pedirle al usuario q abra un archivo local ---> 'Agregar Imagen manualmente'
        private OpenFileDialog archivo = null;
        public AltaItemsForm()
        {
            InitializeComponent();
            Load();
        }

        //CARGA EL DROPDOWN LIST DE CATEGORIAS CON LAS OPCIONES DISPONIBLES
        private void Load()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbxCategoria.DataSource = categoriaNegocio.Listar();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cbxMarca.DataSource = marcaNegocio.Listar();
        }

        private void picBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imagenes = new ImagenNegocio();
            
            try 
            {
                if (articulo == null)
                    articulo = new Articulo();

                //articulo.Codigo = (string)txbCodigo.Text;
                articulo.Nombre = (string)txbNombre.Text;
                articulo.Descripcion = (string)txbDescripcion.Text;
                articulo.Precio = decimal.Parse(txbPrecio.Text);
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                
                if(articulo.Id != 0)
                {   
                    //Agregar funcion Modoficar en ArticuloNegocio
                    //negocio.Modificar(articulo);
                    MessageBox.Show("Modificacion Exitosa");
                }
                else
                {
                    negocio.Agregar(articulo);

                    //Agregar Imagen desde cbox a base de datos 
                    Imagen imgaux = new Imagen();
                    imgaux.UrlImagen = (string)tbxImagenURL.Text;
                    imgaux.IdArticulo = articulo.Id;
                    imagenes.agregar(imgaux);
                   
                    MessageBox.Show("Alta exitosa");
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
