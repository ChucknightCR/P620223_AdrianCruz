﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDCliente));

            DataTable DataCliente = new DataTable();
            DataCliente = MyCnn.EjecutarSelect("SPClienteConsultarPorId");

            //Una vez tenemos un datatable con la data procedemos a llenar
            //las propiedades del objeto de retorno.

            if (DataCliente != null && DataCliente.Rows.Count >0)
            {
                DataRow Fila = DataCliente.Rows[0];

                R.IDCliente = Convert.ToInt32(Fila["IDCliente"]);
                R.Cedula = Convert.ToString(Fila["Cedula"]);
                R.Nombre = Convert.ToString(Fila["Nombre"]);               
                R.CorreoElectronico = Convert.ToString(Fila["CorreoElectronico"]);
                R.Telefono = Convert.ToString(Fila["Telefono"]);
                R.Direccion = Convert.ToString(Fila["Direccion"]);
                R.Activo = Convert.ToBoolean(Fila["Activo"]);
            }


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
