using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Notas { get; set; }
        public bool Activo { get; set; }

        //Funciones y métodos
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

        public bool ConsultarPorID()
        {
            //En las eliminaciones lógicas, lo que haremos será cambiar el valor
            //campo activo a 0 (false)

            bool R = false;

            //TODO: Ejecutar un SP que contenga la instrucción Select correspondiente
            // y retornar true si todo sale bien


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
