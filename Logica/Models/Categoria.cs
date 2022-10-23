using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{

    public class Categoria
    {
            //primero, escribimos las propiedades simples
        public int IDCategoria { get; set; }

        public string NombreCategoria { get; set;  }


        //Escribimos las funciones y métodos (operaciones)

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //Todo: Hay que programar la llamda al SP que retorna datos

            return R;
        }
    }
}
