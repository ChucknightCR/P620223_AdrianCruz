using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P620223_AdrianCruz.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        public Logica.Models.Usuario MiUsuarioLocal { get; set; }

        public DataTable ListaUsuarios { get; set; }
        public FrmUsuariosGestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();

            ListaUsuarios = new DataTable();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //Establecer como padre el formulario principal, de forma que se anide dentro del mismo.
            MdiParent = Globales.MiFormPrincipal;

            CargarRolesDeUsuario();
            CargarEmpresas();
            LlenarListaUsuarios();
        }

        private void LlenarListaUsuarios()
        {
            ListaUsuarios = new DataTable();
            ListaUsuarios = MiUsuarioLocal.Listar(cb_VerActivos.Checked,
                                                  txt_buscar.Text.Trim());
            Dvg_Lista.DataSource = ListaUsuarios;
        }

        private void CargarRolesDeUsuario()
        {
            //Paso 1 y 1.1 de seq usuario rol listar
            Logica.Models.UsuarioRol MiRolUsuario = new Logica.Models.UsuarioRol();

            //Paso 2 y 2.5
            DataTable dt = new DataTable();
            dt = MiRolUsuario.Listar();

            //Paso 3
            if (dt != null && dt.Rows.Count > 0)
            {
                cbox_RolUsuario.ValueMember = "IDUSuarioRol";
                cbox_RolUsuario.DisplayMember = "Rol";
                cbox_RolUsuario.DataSource = dt;
                cbox_RolUsuario.SelectedIndex = -1;
            }
        }



        private void CargarEmpresas()
        {

            Logica.Models.Empresa MiEmpresa = new Logica.Models.Empresa();


            DataTable dt = new DataTable();
            dt = MiEmpresa.Listar();

            //Paso 3
            if (dt != null && dt.Rows.Count > 0)
            {
                cbox_Empresa.ValueMember = "ID";
                cbox_Empresa.DisplayMember = "D";
                cbox_Empresa.DataSource = dt;
                cbox_Empresa.SelectedIndex = -1;
            }
        }























        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_Correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_NombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Cedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_TipoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Lo primero que debemos hacer es validar los datos minimos necesarios 
            //están completos

            //Luego, se procede a realizar las 3 validaciones que se indican por medio de
            //los include(uses) en el diagrama de uso expandido
            //Si las 3 validaciones son negativas se tiene permiso para agregar el usuario
            if (ValidarCamposRequeridos())
            {
                //Los campos están completos
                bool CPorCedula;
                bool CPorNombreUsuario;
                bool CPorEmail;

                //Se crea una nueva instancia del usuario local y se agregan los valores
                //de los atributos
                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.Nombre = txt_Nombre.Text.Trim();
                MiUsuarioLocal.Cedula = txt_Cedula.Text.Trim();
                MiUsuarioLocal.nombreUsuario = txt_NombreUsuario.Text.Trim();
                MiUsuarioLocal.Email = txt_Correo.Text.Trim();
                MiUsuarioLocal.Contrasennia = txt_contrasenia.Text.Trim();

                MiUsuarioLocal.MiEmpresa.IDEmpresa = Convert.ToInt32(cbox_Empresa.SelectedValue);
                MiUsuarioLocal.MiRol.IdUsuarioRol = Convert.ToInt32(cbox_RolUsuario.SelectedValue);

                CPorCedula = MiUsuarioLocal.ConsultarPorcedula();
                CPorEmail = MiUsuarioLocal.ConsultarPorEmail();
                CPorNombreUsuario = MiUsuarioLocal.ConsultarPorEmail();

                if (!CPorCedula && !CPorNombreUsuario && !CPorEmail)
                {
                    string Msg = string.Format("¿Está seguro de agregar al usuario: {0}?", MiUsuarioLocal.Nombre);
                    DialogResult respuesta = MessageBox.Show(Msg, ":O", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        //Si las 3 validaciones son negativas agregamos el usuario
                        bool Ok = MiUsuarioLocal.Agregar();

                        if (Ok)
                        {
                            MessageBox.Show("Usuario agregado correctamente!", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                        }
                        else
                        {
                            MessageBox.Show("No se agregó el usuario", ":(", MessageBoxButtons.OK);
                        }
                    }

                }
                else
                {
                    if (CPorCedula)
                    {
                        MessageBox.Show("Ya existe un usuario con la cedula digitada", "error de validación", MessageBoxButtons.OK);
                        return;
                    }

                    if (CPorNombreUsuario)
                    {
                        MessageBox.Show("Ya existe un usuario con el nombre de usuario digitado", "error de validación", MessageBoxButtons.OK);
                        return;
                    }

                    if (CPorEmail)
                    {
                        MessageBox.Show("Ya existe un usuario con el email digitado", "error de validación", MessageBoxButtons.OK);
                        return;
                    }

                }

            }

        }
        private bool ValidarCamposRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txt_Nombre.Text.Trim()) &&
                !string.IsNullOrEmpty(txt_Cedula.Text.Trim()) &&
                !string.IsNullOrEmpty(txt_NombreUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(txt_Correo.Text.Trim()) &&
                !string.IsNullOrEmpty(txt_contrasenia.Text.Trim()) &&
                cbox_Empresa.SelectedIndex > -1 &&
                cbox_RolUsuario.SelectedIndex > -1)

            {
                R = true;
            }
            else
            {
                //Se le informa al usuario que validación está fallando
                //estas validaciones en negativo deben ser puntuales para poder
                //explicar al usuario que está mal
                if (string.IsNullOrEmpty(txt_Nombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de validación", MessageBoxButtons.OK);
                    txt_Nombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txt_Cedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la cedula", "Error de validación", MessageBoxButtons.OK);
                    txt_Cedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txt_NombreUsuario.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre de usuario", "Error de validación", MessageBoxButtons.OK);
                    txt_NombreUsuario.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txt_Correo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el correo", "Error de validación", MessageBoxButtons.OK);
                    txt_Correo.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txt_contrasenia.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la contraseña", "Error de validación", MessageBoxButtons.OK);
                    txt_contrasenia.Focus();
                    return false;
                }

                //Validaciones de ComboBox
                if (cbox_Empresa.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una empresa", "Error de validación", MessageBoxButtons.OK);
                    cbox_Empresa.Focus();
                    return false;

                }

                if (cbox_RolUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol de usuario", "Error de validación", MessageBoxButtons.OK);
                    cbox_RolUsuario.Focus();
                    return false;

                }

            }


            return R;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            txt_Codigo.Clear();
            txt_Nombre.Clear();
            txt_Cedula.Clear();
            txt_NombreUsuario.Clear();
            txt_Correo.Clear();
            txt_contrasenia.Clear();

            cbox_RolUsuario.SelectedIndex = -1;
            cbox_Empresa.SelectedIndex = -1;
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }
       
       

        private void txt_Cedula_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void txt_NombreUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_buscar.Text.Trim()) && 
                 txt_buscar.Text.Count() >2)
            {
                LlenarListaUsuarios();
            }
            else if (!string.IsNullOrEmpty(txt_buscar.Text.Trim()))
                {
                LlenarListaUsuarios();
            }
        }
    }
}
