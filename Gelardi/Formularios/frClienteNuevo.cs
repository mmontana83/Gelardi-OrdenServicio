using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Gelardi.Formularios
{
    public partial class frClienteNuevo : DevExpress.XtraEditors.XtraForm
    {
        private string documento = "";

        public frClienteNuevo()
        {
            InitializeComponent();
           
        }
        
        private void frClienteNuevo_Load(object sender, EventArgs e)
        {
            /* CARGO REPOSITORIOS */

            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Localidades' Puede moverla o quitarla según sea necesario.
            this.localidadesTableAdapter.Fill(this.gelardiDataSet.Localidades);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.gelardiDataSet.Provincias);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Partidos' Puede moverla o quitarla según sea necesario.
            this.partidosTableAdapter.Fill(this.gelardiDataSet.Partidos);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.gelardiDataSet.Paises);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoDireccion' Puede moverla o quitarla según sea necesario.
            this.tipoDireccionTableAdapter.Fill(this.gelardiDataSet.tipoDireccion);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.gelardiDataSet.tipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoContacto' Puede moverla o quitarla según sea necesario.
            this.tipoContactoTableAdapter.Fill(this.gelardiDataSet.tipoContacto);

            apellidosTextEdit.Focus();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if ((apellidosTextEdit.Text == "" || nombresTextEdit.Text == ""))
            {
                if (organizacionTextEdit.Text == "")
                {
                    XtraMessageBox.Show("Debe completar un Nombre y Apellido u Organización");
                    return;
                }
            }

            if (Convert.ToInt32(idtipoDocumento.EditValue) == 0)
            {
                XtraMessageBox.Show("Debe seleccionar un tipo de documento");
                idtipoDocumento.Focus();
                return;
            }

            if (gridViewContactos.RowCount == 1)
            {
                Control mycontrol = new Control();
                if (XtraDialog.Show(mycontrol, "Desea agregar contactos al cliente?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    xtraTabControl1.SelectedTabPageIndex = 1;
                    return;
                }
            }

            if (gridViewDomicilios.RowCount == 1)
            {
                Control mycontrol = new Control();
                if (XtraDialog.Show(mycontrol, "Desea agregar domicilios al cliente?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    xtraTabControl1.SelectedTabPageIndex = 2;
                    return;
                }
            }

            if (dxValidationProvider1.Validate())
            {
                try
                {
                    documento = documentoTextEdit.Text;

                    clientesTableAdapter.Insert(apellidosTextEdit.Text, nombresTextEdit.Text, organizacionTextEdit.Text, Convert.ToInt32(idtipoDocumento.EditValue),
                         documentoTextEdit.Text, notasMemoEdit.Text);
                     

                    for (int i = 0; i < gridViewContactos.RowCount; i++)
                    {
                        if (gridViewContactos.GetRowCellValue(i, "idTipoContacto") != null)
                        {
                            clientesContactoTableAdapter.Insert(Convert.ToInt32(gridViewContactos.GetRowCellValue(i, "idTipoContacto")),
                                gridViewContactos.GetRowCellValue(i, "contacto").ToString(), documento);
                        }
                    }

                    for (int i = 0; i < gridViewDomicilios.RowCount; i++)
                    {
                        if (gridViewDomicilios.GetRowCellValue(i, "idTipoDireccion") != null)
                        {
                            clientesDomiciliosTableAdapter.Insert(Convert.ToInt32(gridViewDomicilios.GetRowCellValue(i, "idTipoDireccion")),
                                gridViewDomicilios.GetRowCellValue(i, "calle").ToString(), gridViewDomicilios.GetRowCellValue(i, "numero").ToString(),
                                gridViewDomicilios.GetRowCellValue(i, "barrio").ToString(), Convert.ToInt32(gridViewDomicilios.GetRowCellValue(i, "idLocalidad")),
                                Convert.ToInt32(gridViewDomicilios.GetRowCellValue(i, "idPartido")), Convert.ToInt32(gridViewDomicilios.GetRowCellValue(i, "idProvincia")),
                                Convert.ToInt32(gridViewDomicilios.GetRowCellValue(i, "idPais")), documento);
                        }
                    }

                    XtraMessageBox.Show("Se ha guardado con éxito");

                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show("Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex);
                }
            }
        }

        private void contactosGridControl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            DevExpress.XtraGrid.GridControl gridControl = (DevExpress.XtraGrid.GridControl) sender;
            DevExpress.XtraGrid.Views.Grid.GridView currentView = (DevExpress.XtraGrid.Views.Grid.GridView) gridControl.FocusedView;
            if (e.KeyCode == Keys.Delete)
                currentView.DeleteRow(currentView.FocusedRowHandle);
        }

        private void clientesDomiciliosGridControl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            DevExpress.XtraGrid.GridControl gridControl = (DevExpress.XtraGrid.GridControl)sender;
            DevExpress.XtraGrid.Views.Grid.GridView currentView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl.FocusedView;
            if (e.KeyCode == Keys.Delete)
                currentView.DeleteRow(currentView.FocusedRowHandle);
        }
    }
}
