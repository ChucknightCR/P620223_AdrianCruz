using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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

            Conexion MiCnn = new Conexion();

            //Lista de parámetros para el insert
            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.nombreUsuario));

            //TODO: Se debe encriptar la contraseña que se va a almacenar en la tabla usuario
            MiCnn.ListaParametros.Add(new SqlParameter("@Contrasennia", this.Contrasennia));
            MiCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));

            //Parametros para los FKs, normalmente son de objetos compuestos de la clase
            MiCnn.ListaParametros.Add(new SqlParameter("@IDRol", this.MiRol.IdUsuarioRol));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDEmpresa", this.MiEmpresa.IDEmpresa));

            int Resultad = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioAgregar");
            if (Resultad > 0)
            {
                R = true;
            }



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

            Conexion MiCnn = new Conexion();
            //Como en este caso debemos evaluar por la cédula, hay que pasar 1 parámetro al SP
            //de consulta
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioConsultarPorCedula");

            if(Consulta !=null && Consulta.Rows.Count > 0)
            {
                R = true;
            }
           

            return R;


        }

        public bool ConsultarPorNombreUsuario()
        {
        
            bool R = false;

            Conexion MiCnn = new Conexion();
            
            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.nombreUsuario));

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioConsultarPorNombreUsuario");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;
            }


            return R;


        }

        public bool ConsultarPorEmail()
        {
            //En las eliminaciones lógicas, lo que haremos será cambiar el valor
            //campo activo a 0 (false)

            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioConsultarPorEmail");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;


        }

        public DataTable Listar(bool VerActivos = true, string FiltroBusqueda = "" )
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSelect("SPUsuarioListar");

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
