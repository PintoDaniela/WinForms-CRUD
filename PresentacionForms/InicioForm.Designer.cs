﻿namespace PresentacionForms
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PicBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.picBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.picBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.PicBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.panelAgregarCategoria = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.submenuFiltro = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAdelanteImagen = new System.Windows.Forms.Button();
            this.btnAtrasImagen = new System.Windows.Forms.Button();
            this.txtMostrarDescripcion = new System.Windows.Forms.TextBox();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.DgvListaPrincipal = new System.Windows.Forms.DataGridView();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCerrar)).BeginInit();
            this.panelDerecho.SuspendLayout();
            this.panelAgregarCategoria.SuspendLayout();
            this.submenuFiltro.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.PanelSuperior.Controls.Add(this.lblTitulo);
            this.PanelSuperior.Controls.Add(this.PicBoxMaximizar);
            this.PanelSuperior.Controls.Add(this.picBoxRestaurar);
            this.PanelSuperior.Controls.Add(this.picBoxMinimizar);
            this.PanelSuperior.Controls.Add(this.PicBoxCerrar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(867, 23);
            this.PanelSuperior.TabIndex = 0;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(2, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(362, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Trabajo Práctico 2 - Programación 3 (grupo 3)";
            this.lblTitulo.UseCompatibleTextRendering = true;
            // 
            // PicBoxMaximizar
            // 
            this.PicBoxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxMaximizar.Image")));
            this.PicBoxMaximizar.Location = new System.Drawing.Point(821, 5);
            this.PicBoxMaximizar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PicBoxMaximizar.Name = "PicBoxMaximizar";
            this.PicBoxMaximizar.Size = new System.Drawing.Size(17, 16);
            this.PicBoxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxMaximizar.TabIndex = 3;
            this.PicBoxMaximizar.TabStop = false;
            this.PicBoxMaximizar.Click += new System.EventHandler(this.PicBoxMaximizar_Click);
            // 
            // picBoxRestaurar
            // 
            this.picBoxRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRestaurar.Image")));
            this.picBoxRestaurar.Location = new System.Drawing.Point(821, 5);
            this.picBoxRestaurar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.picBoxRestaurar.Name = "picBoxRestaurar";
            this.picBoxRestaurar.Size = new System.Drawing.Size(17, 16);
            this.picBoxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRestaurar.TabIndex = 2;
            this.picBoxRestaurar.TabStop = false;
            this.picBoxRestaurar.Click += new System.EventHandler(this.picBoxRestaurar_Click);
            // 
            // picBoxMinimizar
            // 
            this.picBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizar.Image")));
            this.picBoxMinimizar.Location = new System.Drawing.Point(801, 5);
            this.picBoxMinimizar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.picBoxMinimizar.Name = "picBoxMinimizar";
            this.picBoxMinimizar.Size = new System.Drawing.Size(17, 16);
            this.picBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMinimizar.TabIndex = 1;
            this.picBoxMinimizar.TabStop = false;
            this.picBoxMinimizar.Click += new System.EventHandler(this.picBoxMinimizar_Click);
            // 
            // PicBoxCerrar
            // 
            this.PicBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxCerrar.Image")));
            this.PicBoxCerrar.Location = new System.Drawing.Point(842, 5);
            this.PicBoxCerrar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PicBoxCerrar.Name = "PicBoxCerrar";
            this.PicBoxCerrar.Size = new System.Drawing.Size(17, 16);
            this.PicBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxCerrar.TabIndex = 0;
            this.PicBoxCerrar.TabStop = false;
            this.PicBoxCerrar.Click += new System.EventHandler(this.PicBoxCerrar_Click);
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panelDerecho.Controls.Add(this.panelAgregarCategoria);
            this.panelDerecho.Controls.Add(this.submenuFiltro);
            this.panelDerecho.Controls.Add(this.panel4);
            this.panelDerecho.Controls.Add(this.btnFiltrar);
            this.panelDerecho.Controls.Add(this.panel3);
            this.panelDerecho.Controls.Add(this.btnEliminar);
            this.panelDerecho.Controls.Add(this.panel2);
            this.panelDerecho.Controls.Add(this.btnModificar);
            this.panelDerecho.Controls.Add(this.panel1);
            this.panelDerecho.Controls.Add(this.btnAgregar);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDerecho.Location = new System.Drawing.Point(720, 23);
            this.panelDerecho.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(147, 399);
            this.panelDerecho.TabIndex = 1;
            // 
            // panelAgregarCategoria
            // 
            this.panelAgregarCategoria.Controls.Add(this.panel7);
            this.panelAgregarCategoria.Controls.Add(this.btnAgregarMarca);
            this.panelAgregarCategoria.Controls.Add(this.panel6);
            this.panelAgregarCategoria.Controls.Add(this.btnAgregarCategoria);
            this.panelAgregarCategoria.Location = new System.Drawing.Point(0, 173);
            this.panelAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelAgregarCategoria.Name = "panelAgregarCategoria";
            this.panelAgregarCategoria.Size = new System.Drawing.Size(152, 77);
            this.panelAgregarCategoria.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.panel7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(0, 38);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(7, 32);
            this.panel7.TabIndex = 9;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarMarca.FlatAppearance.BorderSize = 0;
            this.btnAgregarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarMarca.Image")));
            this.btnAgregarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMarca.Location = new System.Drawing.Point(4, 38);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnAgregarMarca.Size = new System.Drawing.Size(143, 32);
            this.btnAgregarMarca.TabIndex = 8;
            this.btnAgregarMarca.Text = "  Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.panel6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 1);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(7, 32);
            this.panel6.TabIndex = 7;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCategoria.Image")));
            this.btnAgregarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(4, 1);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnAgregarCategoria.Size = new System.Drawing.Size(143, 32);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = "  Agregar Categoría";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // submenuFiltro
            // 
            this.submenuFiltro.Controls.Add(this.panel5);
            this.submenuFiltro.Controls.Add(this.btnBuscar);
            this.submenuFiltro.Controls.Add(this.cbxCriterio);
            this.submenuFiltro.Controls.Add(this.cbxCampo);
            this.submenuFiltro.Controls.Add(this.txtFiltro);
            this.submenuFiltro.Controls.Add(this.label3);
            this.submenuFiltro.Controls.Add(this.label2);
            this.submenuFiltro.Controls.Add(this.label1);
            this.submenuFiltro.Location = new System.Drawing.Point(11, 173);
            this.submenuFiltro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.submenuFiltro.Name = "submenuFiltro";
            this.submenuFiltro.Size = new System.Drawing.Size(123, 151);
            this.submenuFiltro.TabIndex = 0;
            this.submenuFiltro.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.panel5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(15, 126);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 26);
            this.panel5.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(19, 126);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnBuscar.Size = new System.Drawing.Size(105, 26);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "  Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(15, 59);
            this.cbxCriterio.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(103, 21);
            this.cbxCriterio.TabIndex = 6;
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(15, 22);
            this.cbxCampo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(103, 21);
            this.cbxCampo.TabIndex = 5;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(15, 95);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(103, 20);
            this.txtFiltro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filtro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Campo:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.panel4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 138);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 32);
            this.panel4.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(4, 138);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnFiltrar.Size = new System.Drawing.Size(143, 32);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.panel3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 103);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 32);
            this.panel3.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(4, 103);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(143, 32);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.panel2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 32);
            this.panel2.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(4, 66);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnModificar.Size = new System.Drawing.Size(143, 32);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.panel1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 32);
            this.panel1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(4, 31);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(143, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(113)))));
            this.panelPrincipal.Controls.Add(this.panel8);
            this.panelPrincipal.Controls.Add(this.txtMostrarDescripcion);
            this.panelPrincipal.Controls.Add(this.picImagen);
            this.panelPrincipal.Controls.Add(this.DgvListaPrincipal);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 23);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(720, 399);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.btnAdelanteImagen);
            this.panel8.Controls.Add(this.btnAtrasImagen);
            this.panel8.Location = new System.Drawing.Point(517, 194);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(190, 55);
            this.panel8.TabIndex = 5;
            // 
            // btnAdelanteImagen
            // 
            this.btnAdelanteImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdelanteImagen.FlatAppearance.BorderSize = 0;
            this.btnAdelanteImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btnAdelanteImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdelanteImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnAdelanteImagen.Image")));
            this.btnAdelanteImagen.Location = new System.Drawing.Point(105, 10);
            this.btnAdelanteImagen.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAdelanteImagen.Name = "btnAdelanteImagen";
            this.btnAdelanteImagen.Size = new System.Drawing.Size(32, 32);
            this.btnAdelanteImagen.TabIndex = 4;
            this.btnAdelanteImagen.UseVisualStyleBackColor = true;
            this.btnAdelanteImagen.Click += new System.EventHandler(this.btnAdelanteImagen_Click);
            // 
            // btnAtrasImagen
            // 
            this.btnAtrasImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtrasImagen.FlatAppearance.BorderSize = 0;
            this.btnAtrasImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btnAtrasImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnAtrasImagen.Image")));
            this.btnAtrasImagen.Location = new System.Drawing.Point(51, 10);
            this.btnAtrasImagen.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAtrasImagen.Name = "btnAtrasImagen";
            this.btnAtrasImagen.Size = new System.Drawing.Size(32, 32);
            this.btnAtrasImagen.TabIndex = 3;
            this.btnAtrasImagen.UseVisualStyleBackColor = true;
            this.btnAtrasImagen.Click += new System.EventHandler(this.btnAtrasImagen_Click);
            // 
            // txtMostrarDescripcion
            // 
            this.txtMostrarDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMostrarDescripcion.Location = new System.Drawing.Point(516, 252);
            this.txtMostrarDescripcion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMostrarDescripcion.Multiline = true;
            this.txtMostrarDescripcion.Name = "txtMostrarDescripcion";
            this.txtMostrarDescripcion.ReadOnly = true;
            this.txtMostrarDescripcion.Size = new System.Drawing.Size(192, 108);
            this.txtMostrarDescripcion.TabIndex = 2;
            // 
            // picImagen
            // 
            this.picImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImagen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picImagen.ErrorImage")));
            this.picImagen.Location = new System.Drawing.Point(537, 21);
            this.picImagen.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.picImagen.MaximumSize = new System.Drawing.Size(267, 312);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(152, 170);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 1;
            this.picImagen.TabStop = false;
            // 
            // DgvListaPrincipal
            // 
            this.DgvListaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvListaPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.DgvListaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvListaPrincipal.Location = new System.Drawing.Point(14, 21);
            this.DgvListaPrincipal.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.DgvListaPrincipal.MaximumSize = new System.Drawing.Size(800, 352);
            this.DgvListaPrincipal.MultiSelect = false;
            this.DgvListaPrincipal.Name = "DgvListaPrincipal";
            this.DgvListaPrincipal.RowHeadersVisible = false;
            this.DgvListaPrincipal.RowHeadersWidth = 62;
            this.DgvListaPrincipal.RowTemplate.Height = 28;
            this.DgvListaPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaPrincipal.Size = new System.Drawing.Size(492, 352);
            this.DgvListaPrincipal.TabIndex = 0;
            this.DgvListaPrincipal.SelectionChanged += new System.EventHandler(this.DgvListaPrincipal_SelectionChanged);
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 422);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "InicioForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InicioForm_Load);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCerrar)).EndInit();
            this.panelDerecho.ResumeLayout(false);
            this.panelAgregarCategoria.ResumeLayout(false);
            this.submenuFiltro.ResumeLayout(false);
            this.submenuFiltro.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaPrincipal)).EndInit();
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel submenuFiltro;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelAgregarCategoria;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.TextBox txtMostrarDescripcion;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Button btnAdelanteImagen;
        private System.Windows.Forms.Button btnAtrasImagen;
        private System.Windows.Forms.Panel panel8;
    }
}

