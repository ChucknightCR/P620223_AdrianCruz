using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaInventario
    {
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal SubTotal { get; set; } //Suma de cantidad * precio de venta
        public decimal DescuentoTotal { get; set; }
        public decimal SubTotal2 { get; set; }//Subtotal - DescuentoTotal

        public decimal ImpuestosTotal { get; set; }
        public decimal TotalLinea { get; set; }//Subtotal 2 + ImpuestoTotal

        //Atributos compuestos

        public Inventario MiInventario { get; set; }
        public FacturaInventario()
        {
            MiInventario = new Inventario();
        }
        

        //Crear funciones para la amte de totalizaciones para no tener
        //que usar en la clase principal

        public decimal TotalizarLinea()
        {
           

            //Totalizar Subtotal
            SubTotal = Cantidad * PrecioVenta;

            //Monto del descuento
            DescuentoTotal = (SubTotal * PorcentajeDescuento) / 100;

            //Subtotal 2
            SubTotal2 = SubTotal - DescuentoTotal;

            ImpuestosTotal = (SubTotal * PorcentajeImpuesto) / 100;
            //Total Final

            TotalLinea = SubTotal2 + ImpuestosTotal;


            return TotalLinea;
        }
    }
}
