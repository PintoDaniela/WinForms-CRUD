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
                cbxMarca.SelectedIndex = articulo.Marca.Id;
                cbxCategoria.SelectedIndex = articulo.Categoria.Id;
                txbDescripcion.Text = articulo.Descripcion;
                txbCodigo.Text = articulo.Codigo;


                //Agregar codigo para visualizar la primer foto del articulo en la pbox (si es que tiene)
                ImagenNegocio imagenes = new ImagenNegocio();
                Imagen img = new Imagen();
                if (imagenes.listar(articulo.Id).Count() > 0)
                {
                    img=imagenes.listar(articulo.Id)[0];
                    pbImagen.ImageLocation = img.ImagenUrl;
                }
                else
                {   //placeholder en Modificar
                    pbImagen.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/1200px-Placeholder_view_vector.svg.png";

                }
                //Cargo las Imagenes que contenga el Articulo a Modificar en la list box.
                List<Imagen> imglist = new List<Imagen>(); 
                imglist=imagenes.listar(articulo.Id);
                foreach (Imagen imagen in imglist)
                {
                    lbxURL.Items.Add(imagen.ImagenUrl);
                }
                
            }
            else
            {
                //Agrego placeholder en Agregar
                pbImagen.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/1200px-Placeholder_view_vector.svg.png";
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
                    negocio.Modificar(articulo);
                    //vacio los registros de imagenes para este articulo
                    imagenes.Vaciar(articulo.Id);
                    //Luego cargo a la db las url que esten en la listbox
                    List<string> listaurls = lbxURL.Items.Cast<string>().ToList();
                    imagenes.Agregar(listaurls, articulo.Id);                    
                
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
                this.Close();
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
            if (lbxURL.SelectedItem != null)
            {
                pbImagen.ImageLocation = lbxURL.SelectedItem.ToString();
            }
            else
            {                              
                //Si el artículo no tiene imagen o esttá rota la url, se muestra un placeholder
                pbImagen.ImageLocation = "https://c.pxhere.com/images/47/83/d6e362ca869395f9db5b5a3d0659-1675158.png!d";
            }
        }

        //Cierro el form de alta con el botón cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
