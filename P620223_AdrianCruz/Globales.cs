using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P620223_AdrianCruz
{
    public static class Globales
    {
        //Los objetos que definamos en esta clase
        //serán accesibles desde la totalidad del programa.
        //Además esta clase al ser static se auto instancia

        //El siguiente formulario principal, se puede
        //invocar desde cualqueir lugar (login en nuestro caso)

        public static Form MiFormPrincipal = new Formularios.FrmPrincipalMDI();

        public static Formularios.FrmUsuariosGestion MiFormMantenimientoUsuarios = new Formularios.FrmUsuariosGestion();

        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        public static Formularios.FrmFacturacion MiFormFacturacion = new Formularios.FrmFacturacion();
    }
}
