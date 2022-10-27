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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //Cierra completamente la aplicación
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_VerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            Txt_Contrasenia.UseSystemPasswordChar = false;
        }

        private void btn_VerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            Txt_Contrasenia.UseSystemPasswordChar = true;
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            //TODO: Se debe validar el ingreso del usuario

            //Si la validación es correcta permite el ingreso al sistema y muestra
            //el formulario principal
            Globales.MiFormPrincipal.Show();
            this.Hide();
        }
    }
}
