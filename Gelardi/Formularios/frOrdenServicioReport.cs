using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gelardi.Formularios
{
    public partial class frOrdenServicioReport : DevExpress.XtraEditors.XtraForm
    {
        private string Documento;
        private string Dominio;
        private string Unidad;
        private string tipoServicio;

        public frOrdenServicioReport()
        {
            InitializeComponent();
        }

        public frOrdenServicioReport(string Documento, string Dominio, string Unidad, string tipoServicio)
        {
            InitializeComponent();
            this.Documento = Documento;
            this.Dominio = Dominio;
            this.Unidad = Unidad;
            this.tipoServicio = tipoServicio;
        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }

        private void frOrdenServicioReport_Load(object sender, EventArgs e)
        {
            //ordenServicioReporteTableAdapter.Fill(this.gelardiDataSet.OrdenServicioReporte, "4171003", "JNV327", "103478", "1000");
            //ordenServicioDetallesReporteTableAdapter.Fill(this.gelardiDataSet.OrdenServicioDetallesReporte, "103478", "1000");

            ordenServicioReporteTableAdapter.Fill(this.gelardiDataSet.OrdenServicioReporte, Documento, Dominio, Unidad, tipoServicio);
            ordenServicioDetallesReporteTableAdapter.Fill(this.gelardiDataSet.OrdenServicioDetallesReporte, Unidad, tipoServicio);

            Reportes.OrdenServicio orden = new Reportes.OrdenServicio();
            orden.SetDataSource(this.gelardiDataSet);
            crystalReportViewer1.ReportSource = orden;
        }
     
}
}