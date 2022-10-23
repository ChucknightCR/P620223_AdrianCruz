using System;
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

            //TODO: Darle funcionalidad


            return R;
        }
    }
}
