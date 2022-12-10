using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Notas { get; set; }

        //atributos compuestos

        public Usuario MiUsuario { get; set; }
        public Cliente MiCliente { get; set; }
        public List<FacturaInventario> Detalle { get; set; }
        public FacturaTipo MiFacturaTipo { get; set; }

        public Factura()
        {
            MiUsuario = new Usuario();
            MiCliente = new Cliente();
            Detalle = new List <FacturaInventario>();
            MiFacturaTipo = new FacturaTipo();
            Fecha = DateTime.Now;
        }
        //fns

        public int Agregar()
        {
            int R = 0;

            //TODO: Ejecutar un SP que contenga la instrucción Insert correspondiente
            // y retornar true si todo sale bien

            return R;

        }

        public bool Imprimir()
        {
            bool R = false;

            return R;
        }
        public DataTable ListarPorFechas(DateTime FechaInicial, DateTime FechaFinal )
        {
            DataTable R = new DataTable();
            return R;
        }

        public DataTable CargarEsquemaListaDetalle()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPFacturaDetalleEsquema", true);

            R.PrimaryKey = null;

            return R;

        }


    }
}
