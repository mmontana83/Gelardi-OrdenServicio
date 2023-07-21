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
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Gelardi.Formularios
{
    public partial class frOrdenServicioListado : DevExpress.XtraEditors.XtraForm
    {
        public frOrdenServicioListado()
        {
            InitializeComponent();
        }

        private void frOrdenServicioListado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.OrdenServicioBusqueda' Puede moverla o quitarla según sea necesario.
            this.ordenServicioBusquedaTableAdapter.Fill(this.gelardiDataSet.OrdenServicioBusqueda);
        }

        private void gridViewOrdenes_MasterRowGetRelationDisplayCaption(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            switch (e.RelationName)
            {
                case "FK_orden Servicio Detalles_orden Servicio":
                    e.RelationName = "Detalles de la Orden";
                    break;
                default: break;
            }
        }

        private void gridViewOrdenes_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));

                string Documento = gridViewOrdenesServicio.GetRowCellValue(info.RowHandle, "Documento").ToString();
                string Dominio = gridViewOrdenesServicio.GetRowCellValue(info.RowHandle, "Dominio").ToString();
                string tipoServicio = gridViewOrdenesServicio.GetRowCellValue(info.RowHandle, "Service").ToString();
                string Unidad = gridViewOrdenesServicio.GetRowCellValue(info.RowHandle, "Unidad").ToString();

                /*MessageBox.Show(string.Format("DoubleClick on row: {0}: Documento: {1}, Dominio {2}, UNidad {3}, Service {4}", info.RowHandle, Documento,
                    Dominio, Unidad, tipoServicio));*/
                frOrdenServicioReport orden = new frOrdenServicioReport(Documento, Dominio, Unidad, tipoServicio);
                orden.ShowDialog();
            }
        }

        private void barButtonItemImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowSelected = gridViewOrdenesServicio.GetSelectedRows()[0];
            if (rowSelected == -1)
            {
                XtraMessageBox.Show("Debe seleccionar una fila");
            }
            else
            {
                string Documento = gridViewOrdenesServicio.GetRowCellValue(rowSelected, "Documento").ToString();
                string Dominio = gridViewOrdenesServicio.GetRowCellValue(rowSelected, "Dominio").ToString();
                string tipoServicio = gridViewOrdenesServicio.GetRowCellValue(rowSelected, "Service").ToString();
                string Unidad = gridViewOrdenesServicio.GetRowCellValue(rowSelected, "Unidad").ToString();

                frOrdenServicioReport orden = new frOrdenServicioReport(Documento, Dominio, Unidad, tipoServicio);
                orden.ShowDialog();
            }
        }

        private void barButtonItemEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowSelected = gridViewOrdenesServicio.GetSelectedRows()[0];
            if (rowSelected == -1)
            {
                XtraMessageBox.Show("Debe seleccionar una fila");
            }
            else
            {
                string Documento = gridViewOrdenesServicio.GetRowCellValue(rowSelected, "Documento").ToString();
                string Dominio = gridViewOrdenesServicio.GetRowCellValue(rowSelected, "Dominio").ToString();
                string tipoServicio = gridViewOrdenesServicio.GetRowCellValue(rowSelected, "Service").ToString();
                string Unidad = gridViewOrdenesServicio.GetRowCellValue(rowSelected, "Unidad").ToString();

                frOrdenServicioEditar editarOrden = new frOrdenServicioEditar(Unidad, tipoServicio);
                editarOrden.ShowDialog();
            }
        }
    }
}