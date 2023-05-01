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
        
        public AltaItemsForm(Articulo art)
        {
            articulo = art;
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

            if(articulo != null) {
                lbTitulo.Text = "MODIFICAR";
                btAgregar.Text = "Modificar";
                //Muestro en los controles, los valores que tiene actualmente el objeto
                txbNombre.Text = articulo.Nombre;
                txbPrecio.Text = articulo.Precio.ToString();
                //Se corrije el Id (EL CBX LISTA DESDE 0, Y EL ID EN LA DB, DESDE 1)
                cbxMarca.SelectedIndex = articulo.Marca.Id+1;
                cbxCategoria.SelectedIndex = articulo.Categoria.Id+1;
                txbDescripcion.Text = articulo.Descripcion;
                txbCodigo.Text = articulo.Codigo;
                //Agregar codigo para visualizar la primer foto del articulo en la pbox (si es que tiene)
                
            }
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

                articulo.Codigo = (string)txbCodigo.Text;
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
                    //Agrego Imagenes a Articulo (si tiene)
                    int ultimo = negocio.listar().Count()-1;
                    Articulo articuloaux = negocio.listar()[ultimo];
                    List<string> listaurls =lbxURL.Items.Cast<string>().ToList();
                    imagenes.Agregar(listaurls, articuloaux.Id);

                   
                    MessageBox.Show("Alta exitosa");
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btAddImg_Click(object sender, EventArgs e)
        {
            lbxURL.Items.Add(txbImagenURL.Text);
            pbImagen.ImageLocation = lbxURL.Items[lbxURL.Items.Count - 1].ToString();
            txbImagenURL.Text = "";
            
        }

        private void eliminarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbxURL.Items.Remove(lbxURL.SelectedItem);
        }

        private void lbxURL_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete) {
                lbxURL.Items.Remove(lbxURL.SelectedItem);
            }
        }

        private void lbxURL_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbImagen.ImageLocation = lbxURL.SelectedItem.ToString();
            foreach(var item in lbxURL.Items)
            {
                string a = item.ToString();

            }
        }
    }


}
