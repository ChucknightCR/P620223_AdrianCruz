using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {
        //Atributos simples
        public  int IDCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string  CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        //En este caso hay un atributo compuesto que une la clase Cliente con 
        //la clase Empresa. Esto debido a la lectura de la relación que existe
        //desde el diagrama entidad-relación

        //Atributos Complejos
        public Empresa MiEmpresa { get; set; }

        //Cuando tratamos atributos complejos, estos normalmente se definen 
        //como cualquier propiedad, pero esa propiedad no está instanciada
        //por lo tanto, se debe instanciar en el constructor de la clase

        public Cliente()
        {
            //Este es el constructor de la clase
            MiEmpresa = new Empresa();

             
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

        public Cliente ConsultarPorID()
        {
           

            Cliente R = new Cliente();

            //TODO: En este caso el retorno es del mismo tipio de la clase.
            //por lo tanto hay que llenar los atributos con los datos
            // que entregue un SP SELECT


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

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            //TODO: Usar SP con parámetro para ver proveedores eliminados o activos


            return R;
        }




    }
}
