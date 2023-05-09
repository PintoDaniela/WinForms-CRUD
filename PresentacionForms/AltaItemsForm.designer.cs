namespace PresentacionForms
{
    partial class AltaItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaItemsForm));
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.panelSup = new System.Windows.Forms.Panel();
            this.picBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.PicBoxCerrar = new System.Windows.Forms.PictureBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lbMarca = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbImagenURL = new System.Windows.Forms.Label();
            this.txbImagenURL = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.lbxURL = new System.Windows.Forms.ListBox();
            this.btAddImg = new System.Windows.Forms.Button();
            this.btCarpeta = new System.Windows.Forms.Button();
            this.btDeleteImg = new System.Windows.Forms.Button();
            this.errorProvNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erorProvPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUrl = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erorProvPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(47, 165);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(87, 25);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDescripcion.Location = new System.Drawing.Point(47, 459);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(120, 25);
            this.lbDescripcion.TabIndex = 1;
            this.lbDescripcion.Text = "Descripcion:";
            this.lbDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPrecio.Location = new System.Drawing.Point(47, 232);
            this.lbPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(73, 25);
            this.lbPrecio.TabIndex = 2;
            this.lbPrecio.Text = "Precio:";
            this.lbPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbNombre.Location = new System.Drawing.Point(204, 165);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNombre.MaxLength = 20;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(241, 30);
            this.txbNombre.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbDescripcion.Location = new System.Drawing.Point(204, 456);
            this.txbDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbDescripcion.MaxLength = 30;
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(241, 75);
            this.txbDescripcion.TabIndex = 5;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbPrecio.Location = new System.Drawing.Point(204, 230);
            this.txbPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPrecio.MaxLength = 20;
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(241, 30);
            this.txbPrecio.TabIndex = 2;
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.panelSup.Controls.Add(this.picBoxMinimizar);
            this.panelSup.Controls.Add(this.PicBoxCerrar);
            this.panelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSup.Location = new System.Drawing.Point(0, 0);
            this.panelSup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSup.Name = "panelSup";
            this.panelSup.Size = new System.Drawing.Size(868, 32);
            this.panelSup.TabIndex = 4;
            // 
            // picBoxMinimizar
            // 
            this.picBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizar.Image")));
            this.picBoxMinimizar.Location = new System.Drawing.Point(799, 5);
            this.picBoxMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxMinimizar.Name = "picBoxMinimizar";
            this.picBoxMinimizar.Size = new System.Drawing.Size(26, 25);
            this.picBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMinimizar.TabIndex = 2;
            this.picBoxMinimizar.TabStop = false;
            this.picBoxMinimizar.Click += new System.EventHandler(this.picBoxMinimizar_Click);
            // 
            // PicBoxCerrar
            // 
            this.PicBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxCerrar.Image")));
            this.PicBoxCerrar.Location = new System.Drawing.Point(830, 5);
            this.PicBoxCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicBoxCerrar.Name = "PicBoxCerrar";
            this.PicBoxCerrar.Size = new System.Drawing.Size(26, 25);
            this.PicBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxCerrar.TabIndex = 4;
            this.PicBoxCerrar.TabStop = false;
            this.PicBoxCerrar.Click += new System.EventHandler(this.PicBoxCerrar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Location = new System.Drawing.Point(58, 678);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(172, 58);
            this.btAgregar.TabIndex = 7;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMarca.Location = new System.Drawing.Point(47, 302);
            this.lbMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(78, 25);
            this.lbMarca.TabIndex = 6;
            this.lbMarca.Text = "Marca :";
            this.lbMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.IntegralHeight = false;
            this.cbxMarca.Location = new System.Drawing.Point(204, 301);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(241, 33);
            this.cbxMarca.TabIndex = 3;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.IntegralHeight = false;
            this.cbxCategoria.Location = new System.Drawing.Point(204, 378);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(241, 33);
            this.cbxCategoria.TabIndex = 4;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCategoria.Location = new System.Drawing.Point(47, 380);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(103, 25);
            this.lbCategoria.TabIndex = 8;
            this.lbCategoria.Text = "Categoria:";
            this.lbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Location = new System.Drawing.Point(273, 678);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(172, 58);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitulo.Location = new System.Drawing.Point(346, 68);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(221, 45);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "ALTA DE ITEM";
            // 
            // lbImagenURL
            // 
            this.lbImagenURL.AutoSize = true;
            this.lbImagenURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbImagenURL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbImagenURL.Location = new System.Drawing.Point(592, 468);
            this.lbImagenURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbImagenURL.Name = "lbImagenURL";
            this.lbImagenURL.Size = new System.Drawing.Size(140, 25);
            this.lbImagenURL.TabIndex = 11;
            this.lbImagenURL.Text = "Imagen (URL):";
            this.lbImagenURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbImagenURL
            // 
            this.txbImagenURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbImagenURL.Location = new System.Drawing.Point(514, 495);
            this.txbImagenURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbImagenURL.MaxLength = 2000;
            this.txbImagenURL.Name = "txbImagenURL";
            this.txbImagenURL.Size = new System.Drawing.Size(306, 30);
            this.txbImagenURL.TabIndex = 6;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(514, 165);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(306, 301);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 12;
            this.pbImagen.TabStop = false;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCodigo.Location = new System.Drawing.Point(53, 565);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(81, 25);
            this.lbCodigo.TabIndex = 13;
            this.lbCodigo.Text = "Codigo:";
            this.lbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbCodigo.Location = new System.Drawing.Point(204, 560);
            this.txbCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCodigo.MaxLength = 20;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(241, 30);
            this.txbCodigo.TabIndex = 14;
            // 
            // lbxURL
            // 
            this.lbxURL.FormattingEnabled = true;
            this.lbxURL.ItemHeight = 20;
            this.lbxURL.Location = new System.Drawing.Point(514, 591);
            this.lbxURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxURL.Name = "lbxURL";
            this.lbxURL.Size = new System.Drawing.Size(306, 144);
            this.lbxURL.TabIndex = 15;
            this.lbxURL.SelectedIndexChanged += new System.EventHandler(this.lbxURL_SelectedIndexChanged);
            this.lbxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxURL_KeyDown);
            // 
            // btAddImg
            // 
            this.btAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddImg.Image = ((System.Drawing.Image)(resources.GetObject("btAddImg.Image")));
            this.btAddImg.Location = new System.Drawing.Point(767, 532);
            this.btAddImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddImg.Name = "btAddImg";
            this.btAddImg.Size = new System.Drawing.Size(53, 49);
            this.btAddImg.TabIndex = 16;
            this.btAddImg.UseVisualStyleBackColor = true;
            this.btAddImg.Click += new System.EventHandler(this.btAddImg_Click);
            // 
            // btCarpeta
            // 
            this.btCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCarpeta.Image = ((System.Drawing.Image)(resources.GetObject("btCarpeta.Image")));
            this.btCarpeta.Location = new System.Drawing.Point(639, 532);
            this.btCarpeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCarpeta.Name = "btCarpeta";
            this.btCarpeta.Size = new System.Drawing.Size(53, 49);
            this.btCarpeta.TabIndex = 17;
            this.btCarpeta.UseVisualStyleBackColor = true;
            this.btCarpeta.Click += new System.EventHandler(this.btCarpeta_Click);
            // 
            // btDeleteImg
            // 
            this.btDeleteImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteImg.Image = ((System.Drawing.Image)(resources.GetObject("btDeleteImg.Image")));
            this.btDeleteImg.Location = new System.Drawing.Point(514, 532);
            this.btDeleteImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDeleteImg.Name = "btDeleteImg";
            this.btDeleteImg.Size = new System.Drawing.Size(53, 49);
            this.btDeleteImg.TabIndex = 18;
            this.btDeleteImg.UseVisualStyleBackColor = true;
            this.btDeleteImg.Click += new System.EventHandler(this.btDeleteImg_Click);
            // 
            // errorProvNombre
            // 
            this.errorProvNombre.ContainerControl = this;
            // 
            // errorProvCodigo
            // 
            this.errorProvCodigo.ContainerControl = this;
            // 
            // erorProvPrecio
            // 
            this.erorProvPrecio.ContainerControl = this;
            // 
            // errorProvDescripcion
            // 
            this.errorProvDescripcion.ContainerControl = this;
            // 
            // errorProviderUrl
            // 
            this.errorProviderUrl.ContainerControl = this;
            // 
            // AltaItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(113)))));
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(868, 820);
            this.Controls.Add(this.btDeleteImg);
            this.Controls.Add(this.btCarpeta);
            this.Controls.Add(this.btAddImg);
            this.Controls.Add(this.lbxURL);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.txbImagenURL);
            this.Controls.Add(this.lbImagenURL);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.panelSup);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(25, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AltaItemsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Item";
            this.TopMost = true;
            this.panelSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erorProvPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.PictureBox picBoxMinimizar;
        private System.Windows.Forms.PictureBox PicBoxCerrar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbImagenURL;
        private System.Windows.Forms.TextBox txbImagenURL;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.ListBox lbxURL;
        private System.Windows.Forms.Button btAddImg;
        private System.Windows.Forms.Button btCarpeta;
        private System.Windows.Forms.Button btDeleteImg;
        private System.Windows.Forms.ErrorProvider errorProvNombre;
        private System.Windows.Forms.ErrorProvider errorProvCodigo;
        private System.Windows.Forms.ErrorProvider erorProvPrecio;
        private System.Windows.Forms.ErrorProvider errorProvDescripcion;
        private System.Windows.Forms.ErrorProvider errorProviderUrl;
    }
}