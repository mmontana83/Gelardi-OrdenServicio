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
    public partial class frAutoNuevo : DevExpress.XtraEditors.XtraForm
    {
        private string documentoCliente = null;

        public frAutoNuevo()
        {
            InitializeComponent();

        }

        private void frAutoNuevo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.gelardiDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoTransmision' Puede moverla o quitarla según sea necesario.
            this.tipoTransmisionTableAdapter.Fill(this.gelardiDataSet.tipoTransmision);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoColorInterior' Puede moverla o quitarla según sea necesario.
            this.tipoColorInteriorTableAdapter.Fill(this.gelardiDataSet.tipoColorInterior);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoColorExterior' Puede moverla o quitarla según sea necesario.
            this.tipoColorExteriorTableAdapter.Fill(this.gelardiDataSet.tipoColorExterior);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoAutoVersion' Puede moverla o quitarla según sea necesario.
            this.tipoAutoVersionTableAdapter.Fill(this.gelardiDataSet.tipoAutoVersion);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoAutoModelo' Puede moverla o quitarla según sea necesario.
            this.tipoAutoModeloTableAdapter.Fill(this.gelardiDataSet.tipoAutoModelo);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Autos' Puede moverla o quitarla según sea necesario.
            //this.autosTableAdapter.Fill(this.gelardiDataSet.Autos);

        }

        private void btBuscarCliente_Click(object sender, EventArgs e)
        {
            if (documentoTextEdit.Text != "")
            {
                if (clientesTableAdapter.countByDocumento(documentoTextEdit.Text) != 0)
                {
                    XtraMessageBox.Show("El cliente ha sido encontrado");
                    documentoCliente = documentoTextEdit.Text;
                    this.Text = "Nuevo Auto para " + clientesTableAdapter.clienteByDocumento(documentoTextEdit.Text);
                }
                else
                {
                    XtraMessageBox.Show("No se encontró cliente con el documento ingresado.");
                    documentoTextEdit.Focus();
                }
            }
            else
            {
                XtraMessageBox.Show("Debe Ingresar un Documento");
                documentoTextEdit.Focus();
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (documentoCliente == null)
            {
                XtraMessageBox.Show("Debe BUSCAR un cliente por documento primeramente.");
            }
            if (dxValidationProvider1.Validate())
            {

                int? colorInterior = null;
                int? colorExterior = null;

                if (idTipoColorInteriorTextEdit.EditValue != null)
                {
                    colorInterior = Convert.ToInt32(idTipoColorInteriorTextEdit.EditValue);
                }

                if (idTipoColorExteriorTextEdit.EditValue != null)
                {
                    colorExterior = Convert.ToInt32(idTipoColorExteriorTextEdit.EditValue);
                }

                try
                {
                    autosTableAdapter.Insert(UnidadTextEdit.Text, DominioTextEdit.Text, ChasisTextEdit.Text, MotorTextEdit.Text,
                        Convert.ToInt32(idTipoModeloTextEdit.EditValue), Convert.ToInt32(idTipoTransmisionTextEdit.EditValue),
                        Convert.ToInt32(idTipoVersionTextEdit.EditValue), Convert.ToInt32(AñoTextEdit.Value), Convert.ToInt32(PuertasTextEdit.Text),
                        textEditCodigoLlave.Text, textEditCodigoRadio.Text, colorInterior, colorExterior, dateEditFechaVenta.DateTime, documentoCliente);
                    
                    Control mycontrol = new Control();
                    if (XtraDialog.Show(mycontrol,"El vehículo fue ingresado con éxito. Desea agregar otro vehículo?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        documentoCliente = null;
                        documentoTextEdit.Text = "";
                        UnidadTextEdit.Text = "";
                        DominioTextEdit.Text = "";
                        ChasisTextEdit.Text = "";
                        MotorTextEdit.Text = "";
                        idTipoModeloTextEdit.EditValue = null;
                        idTipoTransmisionTextEdit.EditValue = null;
                        idTipoVersionTextEdit.EditValue = null;
                        AñoTextEdit.EditValue = null;
                        PuertasTextEdit.EditValue = null;
                        textEditCodigoLlave.Text = "";
                        textEditCodigoRadio.Text = "";
                        colorInterior = colorExterior = null;
                        dateEditFechaVenta.EditValue = null;
                        this.Text = "Nuevo Auto";
                        documentoTextEdit.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                      
                }catch(SqlException ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
    }
}
