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
    public partial class frOrdenServicioEditar : DevExpress.XtraEditors.XtraForm
    {
        private string Unidad;
        private string tipoServicio;
        private string Documento;
        private string Dominio;

        public frOrdenServicioEditar()
        {
            InitializeComponent();
        }

        public frOrdenServicioEditar(string Unidad, string tipoServicio)
        {
            InitializeComponent();
            this.Unidad = Unidad;
            this.tipoServicio = tipoServicio;
        }


        private void frOrdenServicioEditar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoServicio' Puede moverla o quitarla según sea necesario.
            this.tipoServicioTableAdapter.Fill(this.gelardiDataSet.tipoServicio);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.FillById(this.gelardiDataSet.Empleados,6);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoServicioDetalles' Puede moverla o quitarla según sea necesario.
            this.tipoServicioDetallesTableAdapter.Fill(this.gelardiDataSet.tipoServicioDetalles);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.ordenServicioDetalles' Puede moverla o quitarla según sea necesario.
            this.ordenServicioDetallesTableAdapter.Fill(this.gelardiDataSet.ordenServicioDetalles);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.ordenServicio' Puede moverla o quitarla según sea necesario.
            this.ordenServicioTableAdapter.FillByUnidad_TipoServicio(this.gelardiDataSet.ordenServicio,Unidad,tipoServicio);

        }

        private void ordenServicioDetallesGridControl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            DevExpress.XtraGrid.GridControl gridControl = (DevExpress.XtraGrid.GridControl)sender;
            DevExpress.XtraGrid.Views.Grid.GridView currentView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl.FocusedView;
            if (e.KeyCode == Keys.Delete)
                currentView.DeleteRow(currentView.FocusedRowHandle);
        }

        private void ordenServicioDetallesGridControl_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!this.gridViewDetalles.IsLastVisibleRow)
                    this.gridViewDetalles.MoveNext();
                else
                    this.gridViewDetalles.MoveFirst();
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try {
                this.Validate();
                this.ordenServicioBindingSource.EndEdit();
                this.ordenServicioDetallesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gelardiDataSet);

                if (XtraMessageBox.Show("La orden de servicio se actualizó con éxito. Desea imprimirla?","Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Documento = autosTableAdapter.SelectDocByUnidad(Unidad).ToString();
                    Dominio = autosTableAdapter.SelectDomByUnidad(Unidad);
                    frOrdenServicioReport reporte = new frOrdenServicioReport(Documento, Dominio, Unidad, tipoServicio);
                    reporte.ShowDialog();
                }
                else { }

            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}