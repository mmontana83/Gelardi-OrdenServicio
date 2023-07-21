
namespace Gelardi.Formularios
{
    partial class frAutosTodos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gelardiDataSet = new Gelardi.GelardiDataSet();
            this.listadoAutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadoAutosTableAdapter = new Gelardi.GelardiDataSetTableAdapters.ListadoAutosTableAdapter();
            this.tableAdapterManager = new Gelardi.GelardiDataSetTableAdapters.TableAdapterManager();
            this.listadoAutosGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDoc_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehiculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDominio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChasis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAño = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechadeVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gelardiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAutosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gelardiDataSet
            // 
            this.gelardiDataSet.DataSetName = "GelardiDataSet";
            this.gelardiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listadoAutosBindingSource
            // 
            this.listadoAutosBindingSource.DataMember = "ListadoAutos";
            this.listadoAutosBindingSource.DataSource = this.gelardiDataSet;
            // 
            // listadoAutosTableAdapter
            // 
            this.listadoAutosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.AutosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesContactoTableAdapter = null;
            this.tableAdapterManager.ClientesDomiciliosTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.LocalidadesTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.ordenServicioDetallesTableAdapter = null;
            this.tableAdapterManager.OrdenServicioReporteTableAdapter = null;
            this.tableAdapterManager.ordenServicioTableAdapter = null;
            this.tableAdapterManager.PaisesTableAdapter = null;
            this.tableAdapterManager.PartidosTableAdapter = null;
            this.tableAdapterManager.ProvinciasTableAdapter = null;
            this.tableAdapterManager.ResourcesTableAdapter = null;
            this.tableAdapterManager.tipoAutoModeloTableAdapter = null;
            this.tableAdapterManager.tipoAutoVersionTableAdapter = null;
            this.tableAdapterManager.tipoColorExteriorTableAdapter = null;
            this.tableAdapterManager.tipoColorInteriorTableAdapter = null;
            this.tableAdapterManager.tipoContactoTableAdapter = null;
            this.tableAdapterManager.tipoDireccionTableAdapter = null;
            this.tableAdapterManager.tipoDocumentoTableAdapter = null;
            this.tableAdapterManager.tipoEmpleadoTableAdapter = null;
            this.tableAdapterManager.tipoMantenimientoTableAdapter = null;
            this.tableAdapterManager.tipoServicioDetallesTableAdapter = null;
            this.tableAdapterManager.tipoServicioTableAdapter = null;
            this.tableAdapterManager.tipoTransmisionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gelardi.GelardiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listadoAutosGridControl
            // 
            this.listadoAutosGridControl.DataSource = this.listadoAutosBindingSource;
            this.listadoAutosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoAutosGridControl.Location = new System.Drawing.Point(0, 0);
            this.listadoAutosGridControl.MainView = this.gridView1;
            this.listadoAutosGridControl.Name = "listadoAutosGridControl";
            this.listadoAutosGridControl.Size = new System.Drawing.Size(791, 535);
            this.listadoAutosGridControl.TabIndex = 1;
            this.listadoAutosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCliente,
            this.colTipoDoc_,
            this.colDocumento,
            this.colVehiculo,
            this.colDominio,
            this.colUnidad,
            this.colChasis,
            this.colMotor,
            this.colAño,
            this.colFechadeVenta});
            this.gridView1.GridControl = this.listadoAutosGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCliente
            // 
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 0;
            // 
            // colTipoDoc_
            // 
            this.colTipoDoc_.FieldName = "Tipo Doc_";
            this.colTipoDoc_.Name = "colTipoDoc_";
            this.colTipoDoc_.Visible = true;
            this.colTipoDoc_.VisibleIndex = 1;
            // 
            // colDocumento
            // 
            this.colDocumento.FieldName = "Documento";
            this.colDocumento.Name = "colDocumento";
            this.colDocumento.Visible = true;
            this.colDocumento.VisibleIndex = 2;
            // 
            // colVehiculo
            // 
            this.colVehiculo.FieldName = "Vehiculo";
            this.colVehiculo.Name = "colVehiculo";
            this.colVehiculo.Visible = true;
            this.colVehiculo.VisibleIndex = 3;
            // 
            // colDominio
            // 
            this.colDominio.FieldName = "Dominio";
            this.colDominio.Name = "colDominio";
            this.colDominio.Visible = true;
            this.colDominio.VisibleIndex = 4;
            // 
            // colUnidad
            // 
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 5;
            // 
            // colChasis
            // 
            this.colChasis.FieldName = "Chasis";
            this.colChasis.Name = "colChasis";
            this.colChasis.Visible = true;
            this.colChasis.VisibleIndex = 6;
            // 
            // colMotor
            // 
            this.colMotor.FieldName = "Motor";
            this.colMotor.Name = "colMotor";
            this.colMotor.Visible = true;
            this.colMotor.VisibleIndex = 7;
            // 
            // colAño
            // 
            this.colAño.FieldName = "Año";
            this.colAño.Name = "colAño";
            this.colAño.Visible = true;
            this.colAño.VisibleIndex = 8;
            // 
            // colFechadeVenta
            // 
            this.colFechadeVenta.FieldName = "Fecha de Venta";
            this.colFechadeVenta.Name = "colFechadeVenta";
            this.colFechadeVenta.Visible = true;
            this.colFechadeVenta.VisibleIndex = 9;
            // 
            // frAutosTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 535);
            this.Controls.Add(this.listadoAutosGridControl);
            this.Name = "frAutosTodos";
            this.Text = "Listado de Autos";
            this.Load += new System.EventHandler(this.frAutosTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gelardiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAutosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GelardiDataSet gelardiDataSet;
        private System.Windows.Forms.BindingSource listadoAutosBindingSource;
        private GelardiDataSetTableAdapters.ListadoAutosTableAdapter listadoAutosTableAdapter;
        private GelardiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl listadoAutosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDoc_;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colVehiculo;
        private DevExpress.XtraGrid.Columns.GridColumn colDominio;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colChasis;
        private DevExpress.XtraGrid.Columns.GridColumn colMotor;
        private DevExpress.XtraGrid.Columns.GridColumn colAño;
        private DevExpress.XtraGrid.Columns.GridColumn colFechadeVenta;
    }
}