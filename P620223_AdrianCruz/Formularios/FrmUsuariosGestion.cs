using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P620223_AdrianCruz.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        public Logica.Models.Usuario MiUsuarioLocal { get; set; }
        public FrmUsuariosGestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //Establecer como padre el formulario principal, de forma que se anide dentro del mismo.
            MdiParent = Globales.MiFormPrincipal;

            CargarRolesDeUsuario();
            CargarEmpresas();
        }

        private void CargarRolesDeUsuario()
        {
            //Paso 1 y 1.1 de seq usuario rol listar
            Logica.Models.UsuarioRol MiRolUsuario = new Logica.Models.UsuarioRol();

            //Paso 2 y 2.5
            DataTable dt = new DataTable();
            dt = MiRolUsuario.Listar();

            //Paso 3
            if(dt != null && dt.Rows.Count > 0)
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
    }
}
