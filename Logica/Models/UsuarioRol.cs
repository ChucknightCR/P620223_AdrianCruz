﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {
        public int IdUsuarioRol { get; set; }
        public string Rol { get; set; }


        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //paso 2.1 y 2.2 de seq usuario rol listar

            Conexion MiCnn = new Conexion();

            //paso 2.3 y 2.4
            //No es necesario explicarlos pasos dentro de EjecutarSelect,
            //Ya que como se va a usar tantas veces no se vería bien explicarlo.
            R = MiCnn.EjecutarSelect("SPUsuarioRolListar");


            return R;
        }
    }
}
