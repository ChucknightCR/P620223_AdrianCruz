namespace P620223_AdrianCruz.Formularios
{
    partial class FrmUsuariosGestion
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_VerActivos = new System.Windows.Forms.CheckBox();
            this.Dvg_Lista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cb_Activo = new System.Windows.Forms.CheckBox();
            this.cbox_Empresa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbox_RolUsuario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_vercontrasenia = new System.Windows.Forms.Button();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Lista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.41414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.80135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.61616F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 594);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Dvg_Lista, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.76836F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.23164F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(775, 238);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.18383F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.81617F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(767, 69);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_buscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 61);
            this.panel2.TabIndex = 0;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(115, 18);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(441, 22);
            this.txt_buscar.TabIndex = 1;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cb_VerActivos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(595, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 61);
            this.panel4.TabIndex = 1;
            // 
            // cb_VerActivos
            // 
            this.cb_VerActivos.AutoSize = true;
            this.cb_VerActivos.Checked = true;
            this.cb_VerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_VerActivos.Location = new System.Drawing.Point(12, 18);
            this.cb_VerActivos.Margin = new System.Windows.Forms.Padding(4);
            this.cb_VerActivos.Name = "cb_VerActivos";
            this.cb_VerActivos.Size = new System.Drawing.Size(147, 20);
            this.cb_VerActivos.TabIndex = 2;
            this.cb_VerActivos.Text = "Ver usuarios activos";
            this.cb_VerActivos.UseVisualStyleBackColor = true;
            this.cb_VerActivos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Dvg_Lista
            // 
            this.Dvg_Lista.AllowUserToAddRows = false;
            this.Dvg_Lista.AllowUserToDeleteRows = false;
            this.Dvg_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDUsuario,
            this.CNombre,
            this.CCedula,
            this.CEmail,
            this.CNombreEmpresa,
            this.CRol});
            this.Dvg_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dvg_Lista.Location = new System.Drawing.Point(4, 81);
            this.Dvg_Lista.Margin = new System.Windows.Forms.Padding(4);
            this.Dvg_Lista.MultiSelect = false;
            this.Dvg_Lista.Name = "Dvg_Lista";
            this.Dvg_Lista.ReadOnly = true;
            this.Dvg_Lista.RowHeadersVisible = false;
            this.Dvg_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dvg_Lista.Size = new System.Drawing.Size(767, 153);
            this.Dvg_Lista.TabIndex = 3;
            this.Dvg_Lista.VirtualMode = true;
            this.Dvg_Lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.txt_Correo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_NombreUsuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Cedula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Codigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 272);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del usuario";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cb_Activo);
            this.panel5.Controls.Add(this.cbox_Empresa);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.cbox_RolUsuario);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.btn_vercontrasenia);
            this.panel5.Controls.Add(this.txt_contrasenia);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(468, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 266);
            this.panel5.TabIndex = 10;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // cb_Activo
            // 
            this.cb_Activo.AutoSize = true;
            this.cb_Activo.Location = new System.Drawing.Point(192, 227);
            this.cb_Activo.Name = "cb_Activo";
            this.cb_Activo.Size = new System.Drawing.Size(63, 20);
            this.cb_Activo.TabIndex = 11;
            this.cb_Activo.Text = "Activo";
            this.cb_Activo.UseVisualStyleBackColor = true;
            // 
            // cbox_Empresa
            // 
            this.cbox_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Empresa.FormattingEnabled = true;
            this.cbox_Empresa.Location = new System.Drawing.Point(83, 174);
            this.cbox_Empresa.Name = "cbox_Empresa";
            this.cbox_Empresa.Size = new System.Drawing.Size(181, 28);
            this.cbox_Empresa.TabIndex = 10;
            this.cbox_Empresa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Empresa";
            // 
            // cbox_RolUsuario
            // 
            this.cbox_RolUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_RolUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_RolUsuario.FormattingEnabled = true;
            this.cbox_RolUsuario.Location = new System.Drawing.Point(83, 106);
            this.cbox_RolUsuario.Name = "cbox_RolUsuario";
            this.cbox_RolUsuario.Size = new System.Drawing.Size(181, 28);
            this.cbox_RolUsuario.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo usuario";
            // 
            // btn_vercontrasenia
            // 
            this.btn_vercontrasenia.Location = new System.Drawing.Point(255, 16);
            this.btn_vercontrasenia.Name = "btn_vercontrasenia";
            this.btn_vercontrasenia.Size = new System.Drawing.Size(42, 26);
            this.btn_vercontrasenia.TabIndex = 6;
            this.btn_vercontrasenia.Text = "Ver";
            this.btn_vercontrasenia.UseVisualStyleBackColor = true;
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasenia.Location = new System.Drawing.Point(83, 16);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(172, 26);
            this.txt_contrasenia.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Contraseña";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo.Location = new System.Drawing.Point(124, 222);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(227, 26);
            this.txt_Correo.TabIndex = 9;
            this.txt_Correo.TextChanged += new System.EventHandler(this.txt_Correo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Correo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreUsuario.Location = new System.Drawing.Point(124, 177);
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(227, 26);
            this.txt_NombreUsuario.TabIndex = 7;
            this.txt_NombreUsuario.TextChanged += new System.EventHandler(this.txt_NombreUsuario_TextChanged);
            this.txt_NombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreUsuario_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre Usuario";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.Location = new System.Drawing.Point(124, 130);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(227, 26);
            this.txt_Cedula.TabIndex = 5;
            this.txt_Cedula.TextChanged += new System.EventHandler(this.txt_Cedula_TextChanged);
            this.txt_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cedula_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cédula";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(124, 80);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(227, 26);
            this.txt_Nombre.TabIndex = 3;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(124, 37);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.ReadOnly = true;
            this.txt_Codigo.Size = new System.Drawing.Size(114, 26);
            this.txt_Codigo.TabIndex = 1;
            this.txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Codigo.TextChanged += new System.EventHandler(this.txt_Codigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 527);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 64);
            this.panel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btn_agregar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Modificar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Eliminar, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Limpiar, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Cancelar, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(777, 64);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Green;
            this.btn_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(3, 3);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(149, 58);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Tag = "";
            this.btn_agregar.Text = "&Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_Modificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Location = new System.Drawing.Point(158, 3);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(149, 58);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Mo&dificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Gold;
            this.btn_Eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(313, 3);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(149, 58);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "&Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Limpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Location = new System.Drawing.Point(468, 3);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(149, 58);
            this.btn_Limpiar.TabIndex = 3;
            this.btn_Limpiar.Text = "&Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(623, 3);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(151, 58);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(31, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 594);
            this.panel1.TabIndex = 1;
            // 
            // CIDUsuario
            // 
            this.CIDUsuario.DataPropertyName = "IDUsuario";
            this.CIDUsuario.HeaderText = "Código Usuario";
            this.CIDUsuario.Name = "CIDUsuario";
            this.CIDUsuario.ReadOnly = true;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CCedula
            // 
            this.CCedula.DataPropertyName = "Cedula";
            this.CCedula.HeaderText = "Cedula";
            this.CCedula.Name = "CCedula";
            this.CCedula.ReadOnly = true;
            // 
            // CEmail
            // 
            this.CEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CEmail.DataPropertyName = "Email";
            this.CEmail.HeaderText = "Correo";
            this.CEmail.Name = "CEmail";
            this.CEmail.ReadOnly = true;
            this.CEmail.Width = 150;
            // 
            // CNombreEmpresa
            // 
            this.CNombreEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNombreEmpresa.DataPropertyName = "NombreEmpresa";
            this.CNombreEmpresa.HeaderText = "Empresa";
            this.CNombreEmpresa.Name = "CNombreEmpresa";
            this.CNombreEmpresa.ReadOnly = true;
            this.CNombreEmpresa.Width = 150;
            // 
            // CRol
            // 
            this.CRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CRol.DataPropertyName = "Rol";
            this.CRol.HeaderText = "Rol Usuario";
            this.CRol.Name = "CRol";
            this.CRol.ReadOnly = true;
            this.CRol.Width = 150;
            // 
            // FrmUsuariosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1243, 735);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuariosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuariosGestion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Lista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dvg_Lista;
        private System.Windows.Forms.CheckBox cb_VerActivos;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_vercontrasenia;
        private System.Windows.Forms.ComboBox cbox_RolUsuario;
        private System.Windows.Forms.ComboBox cbox_Empresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cb_Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRol;
    }
}