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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaItemsForm ventana = new AltaItemsForm();
            ventana.ShowDialog();
        }
    }
}
