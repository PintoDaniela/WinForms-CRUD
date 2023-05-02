using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // para poder mover la ventana

using Negocio;
using Dominio;

namespace PresentacionForms
{
    public partial class InicioForm : Form
    {
       
        // para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        //para el indice de imagen
        int indiceImagen;

        public InicioForm()
        {
            //Load();
            InitializeComponent();
        }
        //private void Load()
        //{

        //}

        private void PicBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicBoxMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PicBoxMaximizar.Visible = false;
            picBoxRestaurar.Visible = true;
        }

        private void picBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBoxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PicBoxMaximizar.Visible = true;
            picBoxRestaurar.Visible = false;
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

   
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaItemsForm ventana = new AltaItemsForm();
            //ventana.ShowDialog();
            ventana.FormClosed += new FormClosedEventHandler(Ventana_FormClosed);
            ventana.Show();
        }


        //Se carga el listado que se muestra en el dgv:
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                DgvListaPrincipal.DataSource = negocio.listar();
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                int idArticulo = Convert.ToInt32(DgvListaPrincipal.CurrentRow.Cells["Id"].Value.ToString());
                picImagen.ImageLocation = imagenNegocio.listar(idArticulo)[0].ToString();
                indiceImagen = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Ventana_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar();
        }

  

        private void InicioForm_Load(object sender, EventArgs e)
        {
            cargar();

            //Se agregan las opciones del desplegable al cargar el form:
            cbxCampo.Items.Add("Precio");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripcion");
            cbxCampo.Items.Add("Codigo");
        }

        private void DgvListaPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            int idArticulo = Convert.ToInt32(DgvListaPrincipal.CurrentRow.Cells["Id"].Value.ToString());
            List<Imagen> imagenesRelacionadas = imagenNegocio.listar(idArticulo);
            if (imagenesRelacionadas.Count > 0)
            {
                picImagen.ImageLocation = imagenesRelacionadas[0].ImagenUrl;
                indiceImagen = 0;
            }
            else
            {
                // Si no hay imágenes relacionadas con el idArticulo en la tabla, podrías mostrar una imagen predeterminada o borrar la imagen actual              
                picImagen.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQY2wAld_bToqR1Ox1hEhlMwrcwOGWeiDBcYbVDTiY&s";
            }

        }

        private void btnAtrasImagen_Click(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            int idArticulo = Convert.ToInt32(DgvListaPrincipal.CurrentRow.Cells["Id"].Value.ToString());
            if (indiceImagen != 0)
            {
                indiceImagen--;
                picImagen.ImageLocation = imagenNegocio.listar(idArticulo)[indiceImagen].ToString();
            }
        }

        private void btnAdelanteImagen_Click(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            int idArticulo = Convert.ToInt32(DgvListaPrincipal.CurrentRow.Cells["Id"].Value.ToString());
            int indiceMaximo = imagenNegocio.listar(idArticulo).Count - 1;
           
            if(indiceImagen != indiceMaximo)
            {
                indiceImagen++;
                picImagen.ImageLocation = imagenNegocio.listar(idArticulo)[indiceImagen].ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {   
            
            //Envio el objeto articulo desde la fila seleccionada en la DGV
            Articulo art=(Articulo)DgvListaPrincipal.CurrentRow.DataBoundItem;
            AltaItemsForm ventana = new AltaItemsForm(art);
            ventana.ShowDialog();
        }

        //Sólo baja física porque la tabla de articulos de la DB no tiene campo bool para estado activo o no activo.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar(bool logico = false)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio negocioImg = new ImagenNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)DgvListaPrincipal.CurrentRow.DataBoundItem;
                    int idArticulo = seleccionado.Id;
                    negocio.Eliminar(idArticulo);
                    

                    //Vuelvo a cargar el dgv para actualizar los datos.
                    cargar();

                    //Al eliminar el artículo, se borran las imágenes del mismo de la tabla de imágenes.
                    negocioImg.eliminarPorArticulo(idArticulo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //Mostrar u ocultar el submenú del fintro con el botón Filtrar
        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            Action toggleSubMenuFiltro = () => submenuFiltro.Visible = !submenuFiltro.Visible;
            toggleSubMenuFiltro();

            int alturaFiltro = submenuFiltro.Height;
            if (submenuFiltro.Visible)
            {
                panelAgregarCategoria.Location = new Point(panelAgregarCategoria.Location.X, panelAgregarCategoria.Location.Y + alturaFiltro);
            }
            else
            {
                panelAgregarCategoria.Location = new Point(panelAgregarCategoria.Location.X, panelAgregarCategoria.Location.Y - alturaFiltro);
            }
        }

        //Setear las opciones que aparecen en el despregable de criterio según la opción elegida.
        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }

       
    }
}
