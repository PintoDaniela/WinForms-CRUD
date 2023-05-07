using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentacionForms
{
    public partial class AltaItemsForm : Form
    {
        private Articulo articulo = null;
        // para pedirle al usuario q abra un archivo local ---> 'Agregar Imagen manualmente'
        private OpenFileDialog archivo = null;
        string imagenDefault = "https://c.pxhere.com/images/47/83/d6e362ca869395f9db5b5a3d0659-1675158.png!d";
        public AltaItemsForm()
        {
            InitializeComponent();
            CargarDatos();
        }

        public AltaItemsForm(Articulo art)
        {
            articulo = art;
            InitializeComponent();
            CargarDatos();
        }

        //CARGA EL DROPDOWN LIST DE CATEGORIAS CON LAS OPCIONES DISPONIBLES
        private void CargarDatos()
        {
            this.MaximumSize = this.MinimumSize = this.Size;
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbxCategoria.DataSource = categoriaNegocio.Listar();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cbxMarca.DataSource = marcaNegocio.Listar();

            if (articulo != null)
            {
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
                    img = imagenes.listar(articulo.Id)[0];
                    CargarImagen(img.ImagenUrl);
                }
                else
                {
                    CargarImagen(imagenDefault);

                }
                //Cargo las Imagenes que contenga el Articulo a Modificar en la list box.
                List<Imagen> imglist = new List<Imagen>();
                imglist = imagenes.listar(articulo.Id);
                foreach (Imagen imagen in imglist)
                {
                    lbxURL.Items.Add(imagen.ImagenUrl);
                }

            }
            else
            {
                //Agrego placeholder en Agregar
                pbImagen.ImageLocation = imagenDefault;

            }
        }
        private void CargarImagen(string ruta)
        {
            pbImagen.LoadCompleted += (sender, e) =>
            {
                if (e.Error != null)
                {
                    pbImagen.ImageLocation = imagenDefault;
                }
            };

            pbImagen.ImageLocation = ruta;
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

                //Valido los datos antes de asignar los valores de los campos al artículo
                if (Validar())
                {
                    articulo.Codigo = (string)txbCodigo.Text;
                    articulo.Nombre = (string)txbNombre.Text;
                    articulo.Descripcion = (string)txbDescripcion.Text;
                    articulo.Precio = decimal.Parse(txbPrecio.Text);
                    articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                    articulo.Marca = (Marca)cbxMarca.SelectedItem;

                    if (articulo.Id != 0)
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
                        int ultimo = negocio.listar().Count() - 1;
                        Articulo articuloaux = negocio.listar()[ultimo];
                        List<string> listaurls = lbxURL.Items.Cast<string>().ToList();
                        imagenes.Agregar(listaurls, articuloaux.Id);

                        MessageBox.Show("Alta exitosa");

                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btAddImg_Click(object sender, EventArgs e)
        {
            if (txbImagenURL.Text.Count() > 5)
            {
                lbxURL.Items.Add(txbImagenURL.Text);
                pbImagen.ImageLocation = lbxURL.Items[lbxURL.Items.Count - 1].ToString();
                txbImagenURL.Text = "";
                lbxURL.SelectedIndex = lbxURL.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("El campo debe tener un mínimo de 5 carácteres");
            }
          
        }

        private void eliminarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbxURL.Items.Remove(lbxURL.SelectedItem);
        }

        private void lbxURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                lbxURL.Items.Remove(lbxURL.SelectedItem);
            }
        }

        private void lbxURL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxURL.SelectedItem != null)
            {
                CargarImagen(lbxURL.SelectedItem.ToString());
            }
            else
            {
                CargarImagen(imagenDefault);
            }
        }

        //Cierro el form de alta con el botón cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //validacion de codigo
        private bool Validar()
        {
            errorProvNombre.Clear();
            erorProvPrecio.Clear();
            errorProvDescripcion.Clear();
            errorProvCodigo.Clear();
            errorProviderUrl.Clear();
            Regex regexCodigo = new Regex(@"^[A-Z]\d{2}$"); // Expresión regular para validar letra mayúscula seguida de dos números


            if (txbNombre.Text.Length < 3)
            {
                errorProvNombre.SetError(txbNombre, "Minimo 3 carácteres");
                return false;
            }
            if (!(soloNumeros(txbPrecio.Text)))
            {
                erorProvPrecio.SetError(txbPrecio, "Debe ingresar sólo valores numéricos.");
                return false;
            }
            if (!(separaPorComa(txbPrecio.Text)))           
            {
                erorProvPrecio.SetError(txbPrecio, "Use la coma ',' para separar los decimales.");
                return false;
            }
            
            if (txbDescripcion.Text.Length < 10)
            {
                errorProvDescripcion.SetError(txbDescripcion, "Minimo 10 carácteres");
                return false;
            }
            if (!regexCodigo.IsMatch(txbCodigo.Text))
            {
                errorProvCodigo.SetError(txbCodigo, "Debe contener una Mayúscula seguida de dos números");
                return false;
            }
            if (txbImagenURL.Text.Length < 10 && txbImagenURL.Text.Length != 0)
            {
                errorProviderUrl.SetError(txbImagenURL, "Minimo 10 carácteres");
                return false;
            }
            return true;
        }

        private bool soloNumeros(string cadena)
        {            
            try
            {
                decimal.Parse(cadena);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool separaPorComa(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (caracter == '.')
                    return false;
            }
            return true;
        }
       

    private void btCarpeta_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo de selección de archivo para imágenes
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.jpg, *.png)|*.jpg;*.png";

            // Mostrar el cuadro de diálogo de selección de archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nombreCarpeta = "Imagenes";
                string rutaCarpeta = Path.Combine(Application.StartupPath, nombreCarpeta);

                // Crear la carpeta "Imagenes" si no existe
                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }

                // Obtener el nombre del archivo seleccionado y la ruta completa
                string nombreArchivo = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string extensionArchivo = Path.GetExtension(openFileDialog.FileName);
                string rutaCompletaArchivo = Path.Combine(rutaCarpeta, $"{nombreArchivo}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}{extensionArchivo}");

                // Guardar el archivo en la carpeta "Imagenes"
                File.Copy(openFileDialog.FileName, rutaCompletaArchivo, true);

                // Agregar la ruta completa del archivo al ListBox
                lbxURL.Items.Add(rutaCompletaArchivo);
                lbxURL.SelectedIndex = lbxURL.Items.Count - 1;
            }
        }
        private void btDeleteImg_Click(object sender, EventArgs e)
        {
            lbxURL.Items.Remove(lbxURL.SelectedItem);
        }
    }
}
