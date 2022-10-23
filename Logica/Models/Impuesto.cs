using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Impuesto
    { 
        //Primero atributos simples
        public int IDImpuesto { get; set; }
        public string CodigoImpuesto { get; set; }
        public string NombreImpuesto { get; set; }
        public decimal TasaImpuesto { get; set; }

        //Funciones y métodos
        public DataTable Listar()
        { 
            DataTable R = new DataTable();

            //TODO: Darle funcionalidad


        return R;
        }
    }
}
