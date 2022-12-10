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
    public partial class FrmPrincipalMDI : Form
    {
        public FrmPrincipalMDI()
        {
            InitializeComponent();
        }

        private void FrmPrincipalMDI_Load(object sender, EventArgs e)
        {

            string InfoUsuario = string.Format("{0}({1})",
                Globales.MiUsuarioGlobal.Nombre,
                Globales.MiUsuarioGlobal.MiRol.Rol);

            LblUsuarioLogueado.Text = Globales.MiUsuarioGlobal.Nombre;

            switch(Globales.MiUsuarioGlobal.MiRol.IdUsuarioRol)
            {
                case 1:
                    //admin

                    break;
                case 2:
                    //Bodeguero
                    MnuProcesos.Visible = false;

                    MnuUsuariosGestion.Visible = false;
                    MnuImpuestosGestion.Visible = false;
                    MnuClientesGestion.Visible = false;

                    MnuListadoClientes.Visible = false;
                    MnuReimpresionFacturas.Visible = false;
                    MnuVentasCliente.Visible = false;
                    MnuVentasRangoFechas.Visible = false;
                    MnuVentasUsuario.Visible = false;
                    break;
                case 3:
                    //Facturador

                    MnuUsuariosGestion.Visible = false;
                    MnuImpuestosGestion.Visible = false;
                    MnuClientesGestion.Visible = false;
                    MnuCategoriasGestion.Visible = false;
                    MnuProveedoresGestion.Visible = false;

                    MnuListadoProveedores.Visible = false;

                    break;
            }
            TmrFechaHora.Enabled = true;
        }

        private void FrmPrincipalMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Al cerrar el formulario principal se debería teminar la aplicación

            //En el caso que lo que querramos es volver a mostrar el form del login
            //deberíamos agregar un objeto global para dicho formulario
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // en el caso del form en gestión de usuario es necesario establecer en globales
            
            //Si queremos que un formulario se muestre solo una vez, deberíamos verificar 
            // que esté visible o no y en caso de que lo esté se reinstancia y muestra de nuevo

            //El simbolo ! niega una condición lógica
            if(!Globales.MiFormMantenimientoUsuarios.Visible)
            {
                Globales.MiFormMantenimientoUsuarios = new FrmUsuariosGestion();
                Globales.MiFormMantenimientoUsuarios.Show();
            }

            Globales.MiFormMantenimientoUsuarios.Show();




        }

        private void TmrFechaHora_Tick(object sender, EventArgs e)
        {
            //Asignar al label de fecha y hora el valor en formato extendido de la fecha
            //y además la hora

            string fecha = DateTime.Now.Date.ToLongDateString();
            string hora = DateTime.Now.ToLongTimeString();

            LblFechaYHora.Text = fecha + "/" + hora;
        }

        private void MnuFacturacionGestion_Click(object sender, EventArgs e)
        {
            if(!Globales.MiFormFacturacion.Visible)
            {
                Globales.MiFormFacturacion = new FrmFacturacion();
                Globales.MiFormFacturacion.Show();
            }
        }
    }
}
