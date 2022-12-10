﻿namespace P620223_AdrianCruz.Formularios
{
    partial class FrmFacturacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboxFacturaTipo = new System.Windows.Forms.ComboBox();
            this.BtnClienteBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblClienteNombre = new System.Windows.Forms.Label();
            this.TxtClienteID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.MnuOpciones = new System.Windows.Forms.MenuStrip();
            this.MnuAgregarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuModificarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuQuitarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCrearFactura = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtImpuestos = new System.Windows.Forms.TextBox();
            this.TxtDescuentos = new System.Windows.Forms.TextBox();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.CIDInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPorcentajeDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescuentoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImpuestosTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.MnuOpciones.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboxFacturaTipo);
            this.groupBox1.Controls.Add(this.BtnClienteBuscar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtNotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblClienteNombre);
            this.groupBox1.Controls.Add(this.TxtClienteID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado de Factura (tabla Factura)";
            // 
            // CboxFacturaTipo
            // 
            this.CboxFacturaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxFacturaTipo.FormattingEnabled = true;
            this.CboxFacturaTipo.Location = new System.Drawing.Point(288, 57);
            this.CboxFacturaTipo.Name = "CboxFacturaTipo";
            this.CboxFacturaTipo.Size = new System.Drawing.Size(183, 21);
            this.CboxFacturaTipo.TabIndex = 8;
            // 
            // BtnClienteBuscar
            // 
            this.BtnClienteBuscar.Location = new System.Drawing.Point(204, 54);
            this.BtnClienteBuscar.Name = "BtnClienteBuscar";
            this.BtnClienteBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnClienteBuscar.TabIndex = 7;
            this.BtnClienteBuscar.Text = "Buscar";
            this.BtnClienteBuscar.UseVisualStyleBackColor = true;
            this.BtnClienteBuscar.Click += new System.EventHandler(this.BtnClienteBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Location = new System.Drawing.Point(27, 138);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(456, 35);
            this.TxtNotas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Factura: ";
            // 
            // LblClienteNombre
            // 
            this.LblClienteNombre.AutoSize = true;
            this.LblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClienteNombre.Location = new System.Drawing.Point(21, 92);
            this.LblClienteNombre.Name = "LblClienteNombre";
            this.LblClienteNombre.Size = new System.Drawing.Size(114, 16);
            this.LblClienteNombre.TabIndex = 1;
            this.LblClienteNombre.Text = "Nombre Cliente";
            // 
            // TxtClienteID
            // 
            this.TxtClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClienteID.Location = new System.Drawing.Point(24, 56);
            this.TxtClienteID.Name = "TxtClienteID";
            this.TxtClienteID.Size = new System.Drawing.Size(174, 22);
            this.TxtClienteID.TabIndex = 0;
            this.TxtClienteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvLista);
            this.groupBox2.Controls.Add(this.MnuOpciones);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Items en factura";
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDInventario,
            this.CNombreItem,
            this.CPrecioVenta,
            this.CCantidad,
            this.CTasaImpuesto,
            this.CPorcentajeDescuento,
            this.CSubTotal,
            this.CDescuentoTotal,
            this.CSubTotal2,
            this.CImpuestosTotal,
            this.CTotalLinea});
            this.DgvLista.Location = new System.Drawing.Point(6, 55);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(532, 190);
            this.DgvLista.TabIndex = 1;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellContentClick);
            // 
            // MnuOpciones
            // 
            this.MnuOpciones.AllowMerge = false;
            this.MnuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAgregarItem,
            this.MnuModificarItem,
            this.MnuQuitarItem});
            this.MnuOpciones.Location = new System.Drawing.Point(3, 16);
            this.MnuOpciones.Name = "MnuOpciones";
            this.MnuOpciones.Size = new System.Drawing.Size(555, 25);
            this.MnuOpciones.TabIndex = 0;
            this.MnuOpciones.Text = "menuStrip1";
            // 
            // MnuAgregarItem
            // 
            this.MnuAgregarItem.BackColor = System.Drawing.Color.Green;
            this.MnuAgregarItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuAgregarItem.ForeColor = System.Drawing.Color.White;
            this.MnuAgregarItem.Name = "MnuAgregarItem";
            this.MnuAgregarItem.Size = new System.Drawing.Size(129, 21);
            this.MnuAgregarItem.Text = "Agregar Producto";
            this.MnuAgregarItem.Click += new System.EventHandler(this.MnuAgregarItem_Click);
            // 
            // MnuModificarItem
            // 
            this.MnuModificarItem.BackColor = System.Drawing.Color.Peru;
            this.MnuModificarItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuModificarItem.Name = "MnuModificarItem";
            this.MnuModificarItem.Size = new System.Drawing.Size(139, 21);
            this.MnuModificarItem.Text = "Modificar Producto";
            // 
            // MnuQuitarItem
            // 
            this.MnuQuitarItem.BackColor = System.Drawing.Color.Maroon;
            this.MnuQuitarItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuQuitarItem.ForeColor = System.Drawing.Color.White;
            this.MnuQuitarItem.Name = "MnuQuitarItem";
            this.MnuQuitarItem.Size = new System.Drawing.Size(119, 21);
            this.MnuQuitarItem.Text = "Quitar Producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnCrearFactura);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TxtTotal);
            this.groupBox3.Controls.Add(this.TxtImpuestos);
            this.groupBox3.Controls.Add(this.TxtDescuentos);
            this.groupBox3.Controls.Add(this.TxtSubtotal);
            this.groupBox3.Location = new System.Drawing.Point(12, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 109);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // BtnCrearFactura
            // 
            this.BtnCrearFactura.BackColor = System.Drawing.Color.Green;
            this.BtnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearFactura.ForeColor = System.Drawing.Color.White;
            this.BtnCrearFactura.Location = new System.Drawing.Point(371, 75);
            this.BtnCrearFactura.Name = "BtnCrearFactura";
            this.BtnCrearFactura.Size = new System.Drawing.Size(142, 28);
            this.BtnCrearFactura.TabIndex = 8;
            this.BtnCrearFactura.Text = "Crear factura";
            this.BtnCrearFactura.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Impuestos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descuentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SubTotal";
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.Black;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.Gold;
            this.TxtTotal.Location = new System.Drawing.Point(371, 45);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 24);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtImpuestos
            // 
            this.TxtImpuestos.BackColor = System.Drawing.Color.Gray;
            this.TxtImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImpuestos.ForeColor = System.Drawing.Color.White;
            this.TxtImpuestos.Location = new System.Drawing.Point(244, 45);
            this.TxtImpuestos.Name = "TxtImpuestos";
            this.TxtImpuestos.Size = new System.Drawing.Size(100, 22);
            this.TxtImpuestos.TabIndex = 2;
            this.TxtImpuestos.Text = "0";
            this.TxtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDescuentos
            // 
            this.TxtDescuentos.BackColor = System.Drawing.Color.Gray;
            this.TxtDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuentos.ForeColor = System.Drawing.Color.White;
            this.TxtDescuentos.Location = new System.Drawing.Point(119, 44);
            this.TxtDescuentos.Name = "TxtDescuentos";
            this.TxtDescuentos.Size = new System.Drawing.Size(100, 22);
            this.TxtDescuentos.TabIndex = 1;
            this.TxtDescuentos.Text = "0";
            this.TxtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.BackColor = System.Drawing.Color.Gray;
            this.TxtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.ForeColor = System.Drawing.Color.White;
            this.TxtSubtotal.Location = new System.Drawing.Point(3, 45);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.TxtSubtotal.TabIndex = 0;
            this.TxtSubtotal.Text = "0";
            this.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CIDInventario
            // 
            this.CIDInventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDInventario.DataPropertyName = "IDInventario";
            this.CIDInventario.HeaderText = "COD.";
            this.CIDInventario.Name = "CIDInventario";
            this.CIDInventario.ReadOnly = true;
            // 
            // CNombreItem
            // 
            this.CNombreItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombreItem.DataPropertyName = "NombreItem";
            this.CNombreItem.HeaderText = "Item";
            this.CNombreItem.Name = "CNombreItem";
            this.CNombreItem.ReadOnly = true;
            // 
            // CPrecioVenta
            // 
            this.CPrecioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPrecioVenta.DataPropertyName = "PrecioVenta";
            this.CPrecioVenta.HeaderText = "Precio";
            this.CPrecioVenta.Name = "CPrecioVenta";
            this.CPrecioVenta.ReadOnly = true;
            this.CPrecioVenta.Width = 80;
            // 
            // CCantidad
            // 
            this.CCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCantidad.DataPropertyName = "Cantidad";
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            this.CCantidad.Width = 70;
            // 
            // CTasaImpuesto
            // 
            this.CTasaImpuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CTasaImpuesto.DataPropertyName = "TasaImpuesto";
            this.CTasaImpuesto.HeaderText = "% IVA";
            this.CTasaImpuesto.Name = "CTasaImpuesto";
            this.CTasaImpuesto.ReadOnly = true;
            this.CTasaImpuesto.Width = 50;
            // 
            // CPorcentajeDescuento
            // 
            this.CPorcentajeDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPorcentajeDescuento.DataPropertyName = "PorcentajeDescuento";
            this.CPorcentajeDescuento.HeaderText = "% Descuento";
            this.CPorcentajeDescuento.Name = "CPorcentajeDescuento";
            this.CPorcentajeDescuento.ReadOnly = true;
            this.CPorcentajeDescuento.Width = 50;
            // 
            // CSubTotal
            // 
            this.CSubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CSubTotal.DataPropertyName = "SubTotal";
            this.CSubTotal.HeaderText = "SubTotal";
            this.CSubTotal.Name = "CSubTotal";
            this.CSubTotal.ReadOnly = true;
            this.CSubTotal.Visible = false;
            // 
            // CDescuentoTotal
            // 
            this.CDescuentoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CDescuentoTotal.DataPropertyName = "DescuentoTotal";
            this.CDescuentoTotal.HeaderText = "Desc Total";
            this.CDescuentoTotal.Name = "CDescuentoTotal";
            this.CDescuentoTotal.ReadOnly = true;
            this.CDescuentoTotal.Visible = false;
            // 
            // CSubTotal2
            // 
            this.CSubTotal2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CSubTotal2.DataPropertyName = "SubTotal2";
            this.CSubTotal2.HeaderText = "Sub Total 2";
            this.CSubTotal2.Name = "CSubTotal2";
            this.CSubTotal2.ReadOnly = true;
            this.CSubTotal2.Visible = false;
            // 
            // CImpuestosTotal
            // 
            this.CImpuestosTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CImpuestosTotal.DataPropertyName = "ImpuestosTotal";
            this.CImpuestosTotal.HeaderText = "Total IVA";
            this.CImpuestosTotal.Name = "CImpuestosTotal";
            this.CImpuestosTotal.ReadOnly = true;
            this.CImpuestosTotal.Visible = false;
            // 
            // CTotalLinea
            // 
            this.CTotalLinea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CTotalLinea.DataPropertyName = "TotalLinea";
            this.CTotalLinea.HeaderText = "TOTAL";
            this.CTotalLinea.Name = "CTotalLinea";
            this.CTotalLinea.ReadOnly = true;
            this.CTotalLinea.Visible = false;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MnuOpciones;
            this.MaximizeBox = false;
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.MnuOpciones.ResumeLayout(false);
            this.MnuOpciones.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboxFacturaTipo;
        private System.Windows.Forms.Button BtnClienteBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblClienteNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip MnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem MnuAgregarItem;
        private System.Windows.Forms.ToolStripMenuItem MnuModificarItem;
        private System.Windows.Forms.ToolStripMenuItem MnuQuitarItem;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtImpuestos;
        private System.Windows.Forms.TextBox TxtDescuentos;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.Button BtnCrearFactura;
        public System.Windows.Forms.TextBox TxtClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPorcentajeDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescuentoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImpuestosTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalLinea;
    }
}