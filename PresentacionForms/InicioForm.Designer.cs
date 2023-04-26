namespace PresentacionForms
{
    partial class InicioForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.PicBoxCerrar = new System.Windows.Forms.PictureBox();
            this.picBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.picBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.PicBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.DgvListaPrincipal = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSuperior.SuspendLayout();
            this.panelDerecho.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.PanelSuperior.Controls.Add(this.PicBoxMaximizar);
            this.PanelSuperior.Controls.Add(this.picBoxRestaurar);
            this.PanelSuperior.Controls.Add(this.picBoxMinimizar);
            this.PanelSuperior.Controls.Add(this.PicBoxCerrar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1300, 35);
            this.PanelSuperior.TabIndex = 0;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panelDerecho.Controls.Add(this.pictureBox1);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDerecho.Location = new System.Drawing.Point(1080, 35);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(220, 615);
            this.panelDerecho.TabIndex = 1;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(113)))));
            this.panelPrincipal.Controls.Add(this.DgvListaPrincipal);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 35);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1080, 615);
            this.panelPrincipal.TabIndex = 2;
            // 
            // PicBoxCerrar
            // 
            this.PicBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxCerrar.Image")));
            this.PicBoxCerrar.Location = new System.Drawing.Point(1263, 7);
            this.PicBoxCerrar.Name = "PicBoxCerrar";
            this.PicBoxCerrar.Size = new System.Drawing.Size(25, 25);
            this.PicBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxCerrar.TabIndex = 0;
            this.PicBoxCerrar.TabStop = false;
            this.PicBoxCerrar.Click += new System.EventHandler(this.PicBoxCerrar_Click);
            // 
            // picBoxMinimizar
            // 
            this.picBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizar.Image")));
            this.picBoxMinimizar.Location = new System.Drawing.Point(1201, 7);
            this.picBoxMinimizar.Name = "picBoxMinimizar";
            this.picBoxMinimizar.Size = new System.Drawing.Size(25, 25);
            this.picBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMinimizar.TabIndex = 1;
            this.picBoxMinimizar.TabStop = false;
            this.picBoxMinimizar.Click += new System.EventHandler(this.picBoxMinimizar_Click);
            // 
            // picBoxRestaurar
            // 
            this.picBoxRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRestaurar.Image")));
            this.picBoxRestaurar.Location = new System.Drawing.Point(1232, 7);
            this.picBoxRestaurar.Name = "picBoxRestaurar";
            this.picBoxRestaurar.Size = new System.Drawing.Size(25, 25);
            this.picBoxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRestaurar.TabIndex = 2;
            this.picBoxRestaurar.TabStop = false;
            this.picBoxRestaurar.Click += new System.EventHandler(this.picBoxRestaurar_Click);
            // 
            // PicBoxMaximizar
            // 
            this.PicBoxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxMaximizar.Image")));
            this.PicBoxMaximizar.Location = new System.Drawing.Point(1232, 7);
            this.PicBoxMaximizar.Name = "PicBoxMaximizar";
            this.PicBoxMaximizar.Size = new System.Drawing.Size(25, 25);
            this.PicBoxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxMaximizar.TabIndex = 3;
            this.PicBoxMaximizar.TabStop = false;
            this.PicBoxMaximizar.Click += new System.EventHandler(this.PicBoxMaximizar_Click);
            // 
            // DgvListaPrincipal
            // 
            this.DgvListaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaPrincipal.Location = new System.Drawing.Point(54, 41);
            this.DgvListaPrincipal.Margin = new System.Windows.Forms.Padding(30);
            this.DgvListaPrincipal.Name = "DgvListaPrincipal";
            this.DgvListaPrincipal.RowHeadersWidth = 62;
            this.DgvListaPrincipal.RowTemplate.Height = 28;
            this.DgvListaPrincipal.Size = new System.Drawing.Size(943, 513);
            this.DgvListaPrincipal.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioForm";
            this.Text = "Form1";
            this.PanelSuperior.ResumeLayout(false);
            this.panelDerecho.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox PicBoxCerrar;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox PicBoxMaximizar;
        private System.Windows.Forms.PictureBox picBoxRestaurar;
        private System.Windows.Forms.PictureBox picBoxMinimizar;
        private System.Windows.Forms.DataGridView DgvListaPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

