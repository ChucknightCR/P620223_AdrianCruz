namespace P620223_AdrianCruz.Formularios
{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_IngresoDirecto = new System.Windows.Forms.Button();
            this.btn_VerPassword = new System.Windows.Forms.Button();
            this.Lbl_RecuperarContrasenia = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.Txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_IngresoDirecto);
            this.panel1.Controls.Add(this.btn_VerPassword);
            this.panel1.Controls.Add(this.Lbl_RecuperarContrasenia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_Contrasenia);
            this.panel1.Controls.Add(this.Txt_NombreUsuario);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Ingresar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 448);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Btn_IngresoDirecto
            // 
            this.Btn_IngresoDirecto.Location = new System.Drawing.Point(53, 305);
            this.Btn_IngresoDirecto.Name = "Btn_IngresoDirecto";
            this.Btn_IngresoDirecto.Size = new System.Drawing.Size(98, 23);
            this.Btn_IngresoDirecto.TabIndex = 8;
            this.Btn_IngresoDirecto.Text = "Ingreso Directo";
            this.Btn_IngresoDirecto.UseVisualStyleBackColor = true;
            this.Btn_IngresoDirecto.Visible = false;
            this.Btn_IngresoDirecto.Click += new System.EventHandler(this.Btn_IngresoDirecto_Click);
            // 
            // btn_VerPassword
            // 
            this.btn_VerPassword.Location = new System.Drawing.Point(220, 271);
            this.btn_VerPassword.Name = "btn_VerPassword";
            this.btn_VerPassword.Size = new System.Drawing.Size(109, 23);
            this.btn_VerPassword.TabIndex = 7;
            this.btn_VerPassword.Text = "Ver contraseña";
            this.btn_VerPassword.UseVisualStyleBackColor = true;
            this.btn_VerPassword.Click += new System.EventHandler(this.button3_Click);
            this.btn_VerPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_VerPassword_MouseDown);
            this.btn_VerPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_VerPassword_MouseUp);
            // 
            // Lbl_RecuperarContrasenia
            // 
            this.Lbl_RecuperarContrasenia.AutoSize = true;
            this.Lbl_RecuperarContrasenia.LinkColor = System.Drawing.Color.Gold;
            this.Lbl_RecuperarContrasenia.Location = new System.Drawing.Point(50, 276);
            this.Lbl_RecuperarContrasenia.Name = "Lbl_RecuperarContrasenia";
            this.Lbl_RecuperarContrasenia.Size = new System.Drawing.Size(106, 13);
            this.Lbl_RecuperarContrasenia.TabIndex = 6;
            this.Lbl_RecuperarContrasenia.TabStop = true;
            this.Lbl_RecuperarContrasenia.Text = "Olvidé mi contraseña";
            this.Lbl_RecuperarContrasenia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Contrasenia
            // 
            this.Txt_Contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contrasenia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Txt_Contrasenia.Location = new System.Drawing.Point(53, 236);
            this.Txt_Contrasenia.Name = "Txt_Contrasenia";
            this.Txt_Contrasenia.Size = new System.Drawing.Size(276, 29);
            this.Txt_Contrasenia.TabIndex = 3;
            this.Txt_Contrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Contrasenia.UseSystemPasswordChar = true;
            this.Txt_Contrasenia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Txt_NombreUsuario
            // 
            this.Txt_NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreUsuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.Txt_NombreUsuario.Location = new System.Drawing.Point(53, 87);
            this.Txt_NombreUsuario.Name = "Txt_NombreUsuario";
            this.Txt_NombreUsuario.Size = new System.Drawing.Size(276, 29);
            this.Txt_NombreUsuario.TabIndex = 2;
            this.Txt_NombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(220, 371);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(109, 33);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.Green;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.Location = new System.Drawing.Point(53, 371);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(103, 33);
            this.btn_Ingresar.TabIndex = 0;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::P620223_AdrianCruz.Properties.Resources.Clogo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(407, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 264);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btn_Ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(666, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_Contrasenia;
        private System.Windows.Forms.TextBox Txt_NombreUsuario;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.LinkLabel Lbl_RecuperarContrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_VerPassword;
        private System.Windows.Forms.Button Btn_IngresoDirecto;
    }
}