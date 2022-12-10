﻿namespace P620223_AdrianCruz.Formularios
{
    partial class FrmInventarioBuscar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.CIDInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadEnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 20);
            this.textBox1.TabIndex = 0;
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.AllowUserToOrderColumns = true;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDInventario,
            this.CNombreItem,
            this.CCodigoBarras,
            this.CCosto,
            this.CPrecioVenta,
            this.CCantidadEnStock,
            this.CTasaImpuesto,
            this.CNombreCategoria});
            this.DgvLista.Location = new System.Drawing.Point(12, 77);
            this.DgvLista.MultiSelect = false;
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(724, 206);
            this.DgvLista.TabIndex = 1;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellClick);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.Green;
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.Location = new System.Drawing.Point(630, 439);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(106, 32);
            this.BtnSeleccionar.TabIndex = 3;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(506, 439);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(95, 32);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtPrecioUnitario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtIVA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NudCantidad);
            this.panel1.Controls.Add(this.TxtDescuento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 144);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CANTIDAD";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.ForeColor = System.Drawing.Color.ForestGreen;
            this.TxtDescuento.Location = new System.Drawing.Point(436, 67);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(122, 26);
            this.TxtDescuento.TabIndex = 1;
            this.TxtDescuento.Text = "0";
            this.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDescuento.TextChanged += new System.EventHandler(this.TxtDescuento_TextChanged);
            this.TxtDescuento.Leave += new System.EventHandler(this.TxtDescuento_Leave);
            // 
            // NudCantidad
            // 
            this.NudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudCantidad.Location = new System.Drawing.Point(10, 68);
            this.NudCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.Size = new System.Drawing.Size(93, 26);
            this.NudCantidad.TabIndex = 2;
            this.NudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCantidad.Leave += new System.EventHandler(this.NudCantidad_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "% Descuento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(302, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "% IVA";
            // 
            // TxtIVA
            // 
            this.TxtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIVA.ForeColor = System.Drawing.Color.ForestGreen;
            this.TxtIVA.Location = new System.Drawing.Point(278, 68);
            this.TxtIVA.Name = "TxtIVA";
            this.TxtIVA.ReadOnly = true;
            this.TxtIVA.Size = new System.Drawing.Size(122, 26);
            this.TxtIVA.TabIndex = 4;
            this.TxtIVA.Text = "0";
            this.TxtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(131, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRECIO UNIT";
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioUnitario.ForeColor = System.Drawing.Color.ForestGreen;
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(131, 68);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.ReadOnly = true;
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(122, 26);
            this.TxtPrecioUnitario.TabIndex = 6;
            this.TxtPrecioUnitario.Text = "0";
            this.TxtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(611, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "TOTAL";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.TxtTotal.Location = new System.Drawing.Point(593, 68);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(122, 26);
            this.TxtTotal.TabIndex = 8;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CIDInventario
            // 
            this.CIDInventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDInventario.DataPropertyName = "IDInventario";
            this.CIDInventario.HeaderText = "Cód.";
            this.CIDInventario.Name = "CIDInventario";
            this.CIDInventario.ReadOnly = true;
            this.CIDInventario.Width = 80;
            // 
            // CNombreItem
            // 
            this.CNombreItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombreItem.DataPropertyName = "NombreItem";
            this.CNombreItem.HeaderText = "Producto";
            this.CNombreItem.Name = "CNombreItem";
            this.CNombreItem.ReadOnly = true;
            // 
            // CCodigoBarras
            // 
            this.CCodigoBarras.DataPropertyName = "CodigoBarras";
            this.CCodigoBarras.HeaderText = "Cód. Barras";
            this.CCodigoBarras.Name = "CCodigoBarras";
            this.CCodigoBarras.ReadOnly = true;
            // 
            // CCosto
            // 
            this.CCosto.DataPropertyName = "Costo";
            this.CCosto.HeaderText = "Costo";
            this.CCosto.Name = "CCosto";
            this.CCosto.ReadOnly = true;
            this.CCosto.Visible = false;
            // 
            // CPrecioVenta
            // 
            this.CPrecioVenta.DataPropertyName = "PrecioVenta";
            this.CPrecioVenta.HeaderText = "Precio Unit.";
            this.CPrecioVenta.Name = "CPrecioVenta";
            this.CPrecioVenta.ReadOnly = true;
            // 
            // CCantidadEnStock
            // 
            this.CCantidadEnStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCantidadEnStock.DataPropertyName = "CantidadEnStock";
            this.CCantidadEnStock.HeaderText = "Stock";
            this.CCantidadEnStock.Name = "CCantidadEnStock";
            this.CCantidadEnStock.ReadOnly = true;
            this.CCantidadEnStock.Width = 80;
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
            // CNombreCategoria
            // 
            this.CNombreCategoria.DataPropertyName = "NombreCategoria";
            this.CNombreCategoria.HeaderText = "Categoria";
            this.CNombreCategoria.Name = "CNombreCategoria";
            this.CNombreCategoria.ReadOnly = true;
            // 
            // FrmInventarioBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInventarioBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Producto";
            this.Load += new System.EventHandler(this.FrmInventarioBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIVA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudCantidad;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadEnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreCategoria;
    }
}