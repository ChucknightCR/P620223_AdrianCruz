using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Empresa
    {
        public int IDEmpresa { get; set; }
        public string cedulaEmpresa { get; set; }
        public string nombreEmpresa { get; set; }
        public string direccionEmpresa { get; set; }
        public string emailEmpresa { get; set; }
        public string telefonoEmpresa { get; set; }
        public bool activo { get; set; }


        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //TODO: Darle funcionalidad


            return R;
        }

    }
}
