namespace P620223_AdrianCruz.Formularios
{
    partial class FrmPrincipalMDI
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuariosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuClientesGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuImpuestosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuInventarioGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCategoriasGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuProveedoresGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFacturacionGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVentasRangoFechas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVentasCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVentasUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuListadoClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListadoProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuInventarioActual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuReimpresionFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuarioLogueado = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblFechaYHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.TmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.MnuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.BackColor = System.Drawing.Color.DimGray;
            this.MnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMantenimientos,
            this.MnuProcesos,
            this.MnuReportes,
            this.acercaDeToolStripMenuItem});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MnuPrincipal.Size = new System.Drawing.Size(846, 29);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuMantenimientos
            // 
            this.MnuMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuUsuariosGestion,
            this.toolStripSeparator1,
            this.MnuClientesGestion,
            this.toolStripSeparator2,
            this.MnuImpuestosGestion,
            this.MnuInventarioGestion,
            this.MnuCategoriasGestion,
            this.toolStripSeparator3,
            this.MnuProveedoresGestion});
            this.MnuMantenimientos.ForeColor = System.Drawing.Color.White;
            this.MnuMantenimientos.Name = "MnuMantenimientos";
            this.MnuMantenimientos.Size = new System.Drawing.Size(135, 25);
            this.MnuMantenimientos.Text = "Mantenimientos";
            // 
            // MnuUsuariosGestion
            // 
            this.MnuUsuariosGestion.Name = "MnuUsuariosGestion";
            this.MnuUsuariosGestion.Size = new System.Drawing.Size(249, 26);
            this.MnuUsuariosGestion.Text = "Usuarios";
            this.MnuUsuariosGestion.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // MnuClientesGestion
            // 
            this.MnuClientesGestion.Name = "MnuClientesGestion";
            this.MnuClientesGestion.Size = new System.Drawing.Size(249, 26);
            this.MnuClientesGestion.Text = "Clientes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(246, 6);
            // 
            // MnuImpuestosGestion
            // 
            this.MnuImpuestosGestion.Name = "MnuImpuestosGestion";
            this.MnuImpuestosGestion.Size = new System.Drawing.Size(249, 26);
            this.MnuImpuestosGestion.Text = "Impuestos";
            // 
            // MnuInventarioGestion
            // 
            this.MnuInventarioGestion.Name = "MnuInventarioGestion";
            this.MnuInventarioGestion.Size = new System.Drawing.Size(249, 26);
            this.MnuInventarioGestion.Text = "Inventario";
            // 
            // MnuCategoriasGestion
            // 
            this.MnuCategoriasGestion.Name = "MnuCategoriasGestion";
            this.MnuCategoriasGestion.Size = new System.Drawing.Size(249, 26);
            this.MnuCategoriasGestion.Text = "Categorías de inventario";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(246, 6);
            // 
            // MnuProveedoresGestion
            // 
            this.MnuProveedoresGestion.Name = "MnuProveedoresGestion";
            this.MnuProveedoresGestion.Size = new System.Drawing.Size(249, 26);
            this.MnuProveedoresGestion.Text = "Proveedores";
            // 
            // MnuProcesos
            // 
            this.MnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFacturacionGestion});
            this.MnuProcesos.ForeColor = System.Drawing.Color.White;
            this.MnuProcesos.Name = "MnuProcesos";
            this.MnuProcesos.Size = new System.Drawing.Size(84, 25);
            this.MnuProcesos.Text = "Procesos";
            // 
            // MnuFacturacionGestion
            // 
            this.MnuFacturacionGestion.Name = "MnuFacturacionGestion";
            this.MnuFacturacionGestion.Size = new System.Drawing.Size(159, 26);
            this.MnuFacturacionGestion.Text = "Facturación";
            // 
            // MnuReportes
            // 
            this.MnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuVentasRangoFechas,
            this.MnuVentasCliente,
            this.MnuVentasUsuario,
            this.toolStripSeparator4,
            this.MnuListadoClientes,
            this.MnuListadoProveedores,
            this.MnuInventarioActual,
            this.toolStripSeparator5,
            this.MnuReimpresionFacturas});
            this.MnuReportes.ForeColor = System.Drawing.Color.White;
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(154, 25);
            this.MnuReportes.Text = "Galeria de reportes";
            // 
            // MnuVentasRangoFechas
            // 
            this.MnuVentasRangoFechas.Name = "MnuVentasRangoFechas";
            this.MnuVentasRangoFechas.Size = new System.Drawing.Size(268, 26);
            this.MnuVentasRangoFechas.Text = "Ventas por rango de fechas";
            // 
            // MnuVentasCliente
            // 
            this.MnuVentasCliente.Name = "MnuVentasCliente";
            this.MnuVentasCliente.Size = new System.Drawing.Size(268, 26);
            this.MnuVentasCliente.Text = "Ventas por cliente";
            // 
            // MnuVentasUsuario
            // 
            this.MnuVentasUsuario.Name = "MnuVentasUsuario";
            this.MnuVentasUsuario.Size = new System.Drawing.Size(268, 26);
            this.MnuVentasUsuario.Text = "Ventas por usuario";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(265, 6);
            // 
            // MnuListadoClientes
            // 
            this.MnuListadoClientes.Name = "MnuListadoClientes";
            this.MnuListadoClientes.Size = new System.Drawing.Size(268, 26);
            this.MnuListadoClientes.Text = "Listado de clientes";
            // 
            // MnuListadoProveedores
            // 
            this.MnuListadoProveedores.Name = "MnuListadoProveedores";
            this.MnuListadoProveedores.Size = new System.Drawing.Size(268, 26);
            this.MnuListadoProveedores.Text = "Listado de Proveedores";
            // 
            // MnuInventarioActual
            // 
            this.MnuInventarioActual.Name = "MnuInventarioActual";
            this.MnuInventarioActual.Size = new System.Drawing.Size(268, 26);
            this.MnuInventarioActual.Text = "Lista de inventario actual";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(265, 6);
            // 
            // MnuReimpresionFacturas
            // 
            this.MnuReimpresionFacturas.Name = "MnuReimpresionFacturas";
            this.MnuReimpresionFacturas.Size = new System.Drawing.Size(268, 26);
            this.MnuReimpresionFacturas.Text = "Reimpresión de factura";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuarioLogueado,
            this.LblFechaYHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "USUARIO:";
            // 
            // LblUsuarioLogueado
            // 
            this.LblUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioLogueado.Name = "LblUsuarioLogueado";
            this.LblUsuarioLogueado.Size = new System.Drawing.Size(49, 17);
            this.LblUsuarioLogueado.Text = "Usuario";
            // 
            // LblFechaYHora
            // 
            this.LblFechaYHora.Name = "LblFechaYHora";
            this.LblFechaYHora.Size = new System.Drawing.Size(723, 17);
            this.LblFechaYHora.Spring = true;
            this.LblFechaYHora.Text = "FechaHora";
            this.LblFechaYHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TmrFechaHora
            // 
            this.TmrFechaHora.Interval = 1000;
            this.TmrFechaHora.Tick += new System.EventHandler(this.TmrFechaHora_Tick);
            // 
            // FrmPrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 548);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmPrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P5 Facturación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipalMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipalMDI_Load);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem MnuUsuariosGestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuClientesGestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MnuImpuestosGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuInventarioGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuCategoriasGestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MnuProveedoresGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem MnuFacturacionGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem MnuVentasRangoFechas;
        private System.Windows.Forms.ToolStripMenuItem MnuVentasCliente;
        private System.Windows.Forms.ToolStripMenuItem MnuVentasUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MnuListadoClientes;
        private System.Windows.Forms.ToolStripMenuItem MnuListadoProveedores;
        private System.Windows.Forms.ToolStripMenuItem MnuInventarioActual;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem MnuReimpresionFacturas;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuarioLogueado;
        private System.Windows.Forms.ToolStripStatusLabel LblFechaYHora;
        private System.Windows.Forms.Timer TmrFechaHora;
    }
}