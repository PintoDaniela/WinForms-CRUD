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

        private void btnAgregar_Click(object sender, EventArgs e)
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
    }
}
