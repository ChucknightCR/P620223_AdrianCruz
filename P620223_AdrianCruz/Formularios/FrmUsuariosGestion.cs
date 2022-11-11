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

            ActivarAgregar();
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
                            LimpiarTodo();

                            LlenarListaUsuarios();


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
        private bool ValidarCamposRequeridos(bool OmitirContrasennia = false)
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txt_Nombre.Text.Trim()) &&
                !string.IsNullOrEmpty(txt_Cedula.Text.Trim()) &&
                !string.IsNullOrEmpty(txt_NombreUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(txt_Correo.Text.Trim()) &&                
                cbox_Empresa.SelectedIndex > -1 &&
                cbox_RolUsuario.SelectedIndex > -1)

            {

                if (OmitirContrasennia)
                {
                    R = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(txt_contrasenia.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txt_contrasenia.Text.Trim()))
                        {
                            MessageBox.Show("Debe digitar la contraseña", "Error de validación", MessageBoxButtons.OK);
                            txt_contrasenia.Focus();
                            return false;
                        }
                    }
                }

            


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
            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            LimpiarFormulario();

            Dvg_Lista.ClearSelection();
            MiUsuarioLocal = new Logica.Models.Usuario();
            ActivarAgregar();

        }

        private void ActivarAgregar()
        {
            btn_agregar.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;

        }
        private void ActivarModificarEliminar()
        {
            btn_agregar.Enabled = false;
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
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

        private void Dvg_Lista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Dvg_Lista.ClearSelection();
        }

        private void Dvg_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando se selecciona un item de la lista se deben mostrar los datos
            //en los campos del formulario. En este etado se puede cambiar la info y
            //actualizar o eliminar un usuario

            if(Dvg_Lista.SelectedRows.Count ==1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = Dvg_Lista.SelectedRows[0];

                int IdUsuario = Convert.ToInt32(MiFila.Cells["CIDUsuario"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.IdUsuario = IdUsuario;

                //Una vez tenemos el valor del id del usuario, se llama la funcion
                //de consultar por id, que entrega como retorno un objeto de 
                //tipo usuario
                //En este caso voy a reutilizar el objeto de usuario local para
                //cargar datos por medio de la funcion

                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID();

                if(MiUsuarioLocal != null && MiUsuarioLocal.IdUsuario >0)
                {
                    //Una vez me aseguro que el objeto tiene datos
                    //Entonces se representan en pantalla

                    txt_Codigo.Text = MiUsuarioLocal.IdUsuario.ToString();
                    txt_Nombre.Text = MiUsuarioLocal.Nombre;
                    txt_Cedula.Text = MiUsuarioLocal.Cedula;
                    txt_NombreUsuario.Text = MiUsuarioLocal.nombreUsuario;
                    txt_Correo.Text = MiUsuarioLocal.Email;

                    cbox_RolUsuario.SelectedValue = MiUsuarioLocal.MiRol.IdUsuarioRol;
                    cbox_Empresa.SelectedValue = MiUsuarioLocal.MiEmpresa.IDEmpresa;

                    cb_Activo.Checked = MiUsuarioLocal.Activo;

                    //TODO: Inhabilitar el botón de agregar ya que no tiene sentido que
                    //funcione

                    ActivarModificarEliminar();
                }

            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            //Se deben validar los datos mínimos

            if(ValidarCamposRequeridos(true))
            {

                MiUsuarioLocal.Nombre = txt_Nombre.Text.Trim();
                MiUsuarioLocal.Cedula = txt_Cedula.Text.Trim();
                MiUsuarioLocal.nombreUsuario = txt_NombreUsuario.Text.Trim();
                MiUsuarioLocal.Email = txt_Correo.Text.Trim();
                MiUsuarioLocal.Contrasennia = txt_contrasenia.Text.Trim();

                MiUsuarioLocal.MiRol.IdUsuarioRol = Convert.ToInt32(cbox_RolUsuario.SelectedValue);
                MiUsuarioLocal.MiEmpresa.IDEmpresa = Convert.ToInt32(cbox_Empresa.SelectedValue);

                if(MiUsuarioLocal.ConsultarPorID(MiUsuarioLocal.IdUsuario))
                {
                    DialogResult Respuesta = MessageBox.Show("¿Seguro de modificar el usuario?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(Respuesta == DialogResult.Yes)
                    {
                        if(MiUsuarioLocal.Modificar())
                        {
                            MessageBox.Show("Usuario Modificado!", ":)",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarTodo();

                            LlenarListaUsuarios();
                        }
                    }
                }

            }
        }

        private void Dvg_Lista_Click(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
        
            if(cb_VerActivos.Checked)
            {
                DialogResult Respuesta = MessageBox.Show("¿Seguro de eliminar al usuario?", "???",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    if (MiUsuarioLocal.Eliminar())
                    {
                        MessageBox.Show("Usuario eliminado correctamenet!", ":)",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTodo();
                        LlenarListaUsuarios();
                    }
                }
            }
            else
            {

                DialogResult Respuesta = MessageBox.Show("¿Seguro de activar al usuario?", "???",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    if (MiUsuarioLocal.Activar())
                    {
                        MessageBox.Show("Usuario activado correctamenet!", ":)",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTodo();
                        LlenarListaUsuarios();
                    }
                }
            }

                
               
            }
        



        private void cb_VerActivos_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaUsuarios();

            if(cb_VerActivos.Checked)
            {
                btn_Eliminar.Text = "Eliminar";
                
            }
            else
            {
                btn_Eliminar.Text = "Activar";
            }
        }







    }
    }


