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
    public partial class FormCategoriaMarca : Form
    {
        public FormCategoriaMarca()
        {
            InitializeComponent();
            Cargar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Cargar()
        {
            if (Text == "Categoria")
            {
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                cbListaBorrar.DataSource = catNegocio.Listar();
                cbListaBorrar.SelectedIndex = -1;

            }
            else
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                cbListaBorrar.DataSource = marcaNegocio.Listar();
                cbListaBorrar.SelectedIndex = -1;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIngresoCateogoria.Text.Length < 4)
            {
                MessageBox.Show("El nombre de la categoría debe tener al menos 4 caracteres.");
                return;
            }
            if (Text == "Categoria")
            {
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                try
                {
                    catNegocio.Agregar(txtIngresoCateogoria.Text);
                    MessageBox.Show("Alta exitosa");
                    this.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                try
                {
                    marcaNegocio.Agregar(txtIngresoCateogoria.Text);
                    MessageBox.Show("Alta exitosa");
                    this.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public FormCategoriaMarca(string seleccion)
        {

            InitializeComponent();
            Text = seleccion;
            lbCategoria.Text = "Agregar " + Text;
            lbTitulo.Text = "Editar " + seleccion;
            Cargar();

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (cbListaBorrar.SelectedItem != null)
            {
                if (Text == "Categoria")
                {
                    CategoriaNegocio catNegocio = new CategoriaNegocio();
                    int idCategoria = ((Categoria)cbListaBorrar.SelectedItem).Id;
                    if (!catNegocio.anexadoArticulo(idCategoria))
                    {
                        try
                        {
                            catNegocio.Eliminar(cbListaBorrar.SelectedItem.ToString());
                            MessageBox.Show("Baja exitosa");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La categoria se encuentra relacianada con un articulo, no puede borrarse");
                    }
                }
                else
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    int idMarca = ((Marca)cbListaBorrar.SelectedItem).Id;
                    if (!marcaNegocio.anexadoArticulo(idMarca))
                    {
                        try
                        {

                            marcaNegocio.Eliminar(cbListaBorrar.SelectedItem.ToString());
                            MessageBox.Show("Baja exitosa");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La marca se encuentra relacionada con un articulo, No puede borrarse");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista");
            }
        }
    }

}
