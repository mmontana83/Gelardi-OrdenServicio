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
using System.Data.SqlClient;

namespace Gelardi.Formularios
{
    public partial class frOrdenServicio : DevExpress.XtraEditors.XtraForm
    {
        private string Documento;
        private string Unidad = "";
        private string tipoServicio;
        private string Dominio;

        public frOrdenServicio()
        {
            InitializeComponent();
        }

        private void frOrdenServicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoServicioDetalles' Puede moverla o quitarla según sea necesario.
            this.tipoServicioDetallesTableAdapter.Fill(this.gelardiDataSet.tipoServicioDetalles);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet1.tipoServicio' Puede moverla o quitarla según sea necesario.
            this.tipoServicioTableAdapter.Fill(this.gelardiDataSet.tipoServicio);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.FillById(this.gelardiDataSet.Empleados,6);
        }

        private void btBuscarDominio_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderBuscarDominio.Validate())
            {
                Unidad = autosTableAdapter.SelectUnidadByUnidad(unidadTextEdit.Text.Trim()).ToString();
                Documento = autosTableAdapter.SelectDocByUnidad(Unidad).ToString();
                Dominio = autosTableAdapter.SelectDomByUnidad(Unidad);
                
                if (Unidad == null)
                    XtraMessageBox.Show("No se ha encontrado cliente para la unidad ingresada.");
                else this.Text = "Nueva Orden de Servicio para " + clientesTableAdapter.clienteByDocumento(Documento);

            }
        }
        //FILTRO PARA COMPLETAR LA TABLA DE DETALLES
        private void tipoServicioLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try {
                detallesTableAdapter.Fill(gelardiDataSet.Detalles, Convert.ToInt32(tipoServicioLookUpEdit.EditValue));
                colidTipoServicioDetalles.BestFit();
            }
            catch { }
        }

        // METODO PARA BORRAR FILAS
        private void ordenServicioDetallesGridControl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            DevExpress.XtraGrid.GridControl gridControl = (DevExpress.XtraGrid.GridControl)sender;
            DevExpress.XtraGrid.Views.Grid.GridView currentView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl.FocusedView;
            if (e.KeyCode == Keys.Delete)
                currentView.DeleteRow(currentView.FocusedRowHandle);
        }

        //METODO PARA PODER VALIDAR CELDAS CON ENTER
        private void detallesGridControl_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!this.gridViewDetalles.IsLastVisibleRow)
                    this.gridViewDetalles.MoveNext();
                else
                    this.gridViewDetalles.MoveFirst();
            }
        }

        private void btGuardarOrden_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderGuardar.Validate())
            {
                if (tipoServicioLookUpEdit.EditValue.ToString() == "13")
                {
                    if (Convert.ToInt32(kmSpinEdit.EditValue) != 0)
                    {
                        tipoServicio = "SERVICIO O MANTENIMIENTO: " + kmSpinEdit.EditValue.ToString();
                    }
                    else
                    {
                        XtraMessageBox.Show("Para el Tipo de Servicio ''SERVICIO O MANTENIMIENTO'' el campo Km no puede estar en 0");
                        kmSpinEdit.Focus();
                        return;
                    }
                }
                else tipoServicio = tipoServicioLookUpEdit.Text;

                if (Unidad == "")
                {
                    XtraMessageBox.Show("Debe hacer click en el botón Buscar Dominio para proceder.");
                    return;
                }    

                if (gridViewDetalles.RowCount == 1) //verifico que la tabla de detalles tenga aunque sea una reparación.
                {
                    XtraMessageBox.Show("La tabla de detalles debe contener aunque sea una reparación.");
                    return;
                }
                else
                {
                    try
                    {
                        //Inserto datos en la tabla Orden Servicio
                        ordenServicioTableAdapter.Insert(Unidad, tipoServicio, fechaRecepcionDateEdit.DateTime, fechaPrometidaDateEdit.DateTime,
                        fecheEntregaDateEdit.DateTime, Convert.ToInt32(kmSpinEdit.EditValue), Convert.ToBoolean(garantiaCheckEdit.EditValue), 0,
                        observacionesMemoEdit.Text, Convert.ToInt32(idTecnicoLookUpEdit.EditValue));
                    }
                    catch (SqlException ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                        return;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                        return;
                    }

                    try
                    {
                        int? ut = null;
                        double? precio = null;

                        //Inserto los detalles del servicio en la Tabla Orden Servicio Detalles
                        for (int i = 0; i < gridViewDetalles.RowCount - 1; i++)
                        {
                            try { ut = Convert.ToInt32(gridViewDetalles.GetRowCellValue(i, colUT)); }
                            catch { ut = 0; }

                            try { precio = Convert.ToDouble(gridViewDetalles.GetRowCellValue(i, colprecio)); }
                            catch { precio = 0.0; }
                            
                            ordenServicioDetallesTableAdapter.Insert(Convert.ToInt32(gridViewDetalles.GetRowCellValue(i, colidTipoServicioDetalles)),
                                ut, precio, Unidad, tipoServicio);
                        }
                    }
                    catch (SqlException ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                        return;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                        return;
                    }

                    XtraMessageBox.Show("La orden se guardó con éxito");

                    frOrdenServicioReport ordenServicioImpresion = new frOrdenServicioReport(Documento, Dominio, Unidad, tipoServicio);
                    ordenServicioImpresion.Show();
                    this.Close();
                }
            }
        }
    }
}