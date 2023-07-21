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
using DevExpress.XtraGrid.Views.Grid;

namespace Gelardi.Formularios
{
    public partial class frClientesTodos : DevExpress.XtraEditors.XtraForm
    {
        public frClientesTodos()
        {
            InitializeComponent();
        }

        private void frClientesTodos_Load(object sender, EventArgs e)
        {
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
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Localidades' Puede moverla o quitarla según sea necesario.
            this.localidadesTableAdapter.Fill(this.gelardiDataSet.Localidades);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoEmpleado' Puede moverla o quitarla según sea necesario.
            this.tipoEmpleadoTableAdapter.Fill(this.gelardiDataSet.tipoEmpleado);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoDireccion' Puede moverla o quitarla según sea necesario.
            this.tipoDireccionTableAdapter.Fill(this.gelardiDataSet.tipoDireccion);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoContacto' Puede moverla o quitarla según sea necesario.
            this.tipoContactoTableAdapter.Fill(this.gelardiDataSet.tipoContacto);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.gelardiDataSet.Provincias);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Partidos' Puede moverla o quitarla según sea necesario.
            this.partidosTableAdapter.Fill(this.gelardiDataSet.Partidos);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.gelardiDataSet.Paises);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.ClientesDomicilios' Puede moverla o quitarla según sea necesario.
            this.clientesDomiciliosTableAdapter.Fill(this.gelardiDataSet.ClientesDomicilios);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.ClientesContacto' Puede moverla o quitarla según sea necesario.
            this.clientesContactoTableAdapter.Fill(this.gelardiDataSet.ClientesContacto);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.ordenServicio' Puede moverla o quitarla según sea necesario.
            this.ordenServicioTableAdapter.Fill(this.gelardiDataSet.ordenServicio);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Autos' Puede moverla o quitarla según sea necesario.
            this.autosTableAdapter.Fill(this.gelardiDataSet.Autos);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.tipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.gelardiDataSet.tipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.gelardiDataSet.Clientes);

        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientesBindingSource.EndEdit();
                this.clientesContactoBindingSource.EndEdit();
                this.clientesDomiciliosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gelardiDataSet);
            }
            catch (Exception ex)
            { XtraMessageBox.Show(ex.Message); }
        }

        private void gridViewClientes_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            switch (e.RelationName)
            {
                case "FK_Autos_Clientes":
                    e.RelationName = "Autos";
                    break;
                case "FK_ordenServicioDetalles_ordenServicio":
                    e.RelationName = "Órdenes de Servicio";
                    break;
                case "FK_Clientes Contacto_Clientes":
                    e.RelationName = "Contactos";
                    break;
                case "FK_Clientes Domicilios_Clientes":
                    e.RelationName = "Domicilios";
                    break;
                default:break;
            } 
        }
    }
}