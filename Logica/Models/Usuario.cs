using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string nombreUsuario { get; set; }
        public string Contrasennia { get; set; }
        public string CodigoRecuperacion { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        //Atributos compuestos
        public Empresa MiEmpresa { get; set; }
        public UsuarioRol MiRol { get; set; }

        public Usuario() { 
            MiEmpresa = new Empresa();
            MiRol = new UsuarioRol();
            Activo = true;
        }
        public bool Agregar()
        {
            bool R = false;

            //TODO: Ejecutar un SP que contenga la instrucción Insert correspondiente
            // y retornar true si todo sale bien

            return R;

        }
        public bool Modificar()
        {
            bool R = false;
            //TODO: Ejecutar un SP que contenga la instrucción Update correspondiente
            // y retornar true si todo sale bien


            return R;


        }

        public bool Eliminar()
        {
            //En las eliminaciones lógicas, lo que haremos será cambiar el valor
            //campo activo a 0 (false)

            bool R = false;

            //TODO: Ejecutar un SP que contenga la instrucción DELETE correspondiente
            // y retornar true si todo sale bien


            return R;


        }

        public Usuario ConsultarPorID()
        {

            Usuario R = new Usuario();

           


            return R;


        }

        public bool ConsultarPorcedula()
        {
            //En las eliminaciones lógicas, lo que haremos será cambiar el valor
            //campo activo a 0 (false)

            bool R = false;

            //TODO: Ejecutar un SP que contenga la instrucción Select correspondiente
            // y retornar true si todo sale bien


            return R;


        }

        public bool ConsultarPorNombreUsuario()
        {
            //En las eliminaciones lógicas, lo que haremos será cambiar el valor
            //campo activo a 0 (false)

            bool R = false;

            //TODO: Ejecutar un SP que contenga la instrucción Select correspondiente
            // y retornar true si todo sale bien


            return R;


        }

        public bool ConsultarPorEmail()
        {
            //En las eliminaciones lógicas, lo que haremos será cambiar el valor
            //campo activo a 0 (false)

            bool R = false;

            //TODO: Ejecutar un SP que contenga la instrucción Select correspondiente
            // y retornar true si todo sale bien


            return R;


        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            //TODO: Usar SP con parámetro para ver proveedores eliminados o activos


            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            //TODO: Usar SP con parámetro para ver proveedores eliminados o activos


            return R;
        }

        public bool ValidarLogin(string NombreUsuario, string Contrasennia)
        {
            bool R = false;
            return R;
        }
        public bool EnviarCodigoRecuperacion(string Email)
        {
            bool R = false;
            return R;
        }
        public bool ResetearContrasennia()
        {
            bool R = false;
            return R;
             }

    }
}
