﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            Conexion MiCnn = new Conexion();

            //parámetros para el encabezado 
            MiCnn.ListaParametros.Add(new SqlParameter("@IDCliente", this.MiCliente.IDCliente));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuario", this.MiUsuario.IdUsuario));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDTipoFactura", this.MiFacturaTipo.IDFacturaTipo));
            MiCnn.ListaParametros.Add(new SqlParameter("@Notas", this.Notas));

            object retorno = MiCnn.EjecutarConRetornoEscalar("SPFacturaAgregar");

            if (retorno != null)
            {
                this.IdFactura = Convert.ToInt32(retorno.ToString());

                //ahora tenemos lo necesario para agregar los detalles 
                int Acumulador = 0;

                foreach (FacturaInventario item in this.Detalle)
                {

                    Conexion MiCnnDetalle = new Conexion();

                    //2 Foreign Keys
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@IDFactura", this.IdFactura));
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@IDInventario", item.MiInventario.IdInventario));

                    //resto de calumnas
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@Costo", item.Costo));
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@PrecioVenta", item.PrecioVenta));
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@Cantidad", item.Cantidad));
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@PorcentajeImpuesto", item.PorcentajeImpuesto));
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@PorcentajeDescuento", item.PorcentajeDescuento));
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@SubTotal", item.SubTotal));
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@DescuentoTotal", item.DescuentoTotal));
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@SubTotal2", item.SubTotal2));
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@ImpuestosTotal", item.ImpuestosTotal));
                    MiCnnDetalle.ListaParametros.Add(new SqlParameter("@TotalLinea", item.TotalLinea));

                    MiCnnDetalle.EjecutarUpdateDeleteInsert("SPFacturaAgregarDetalle");

                    Acumulador += 1;
                }

                R = Acumulador;

            }

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
