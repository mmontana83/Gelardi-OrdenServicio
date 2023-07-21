
namespace Gelardi.Formularios
{
    partial class frOrdenServicioReport
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gelardiDataSet = new Gelardi.GelardiDataSet();
            this.ordenServicioReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenServicioReporteTableAdapter = new Gelardi.GelardiDataSetTableAdapters.OrdenServicioReporteTableAdapter();
            this.tableAdapterManager = new Gelardi.GelardiDataSetTableAdapters.TableAdapterManager();
            this.ordenServicioDetallesReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenServicioDetallesReporteTableAdapter = new Gelardi.GelardiDataSetTableAdapters.OrdenServicioDetallesReporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gelardiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenServicioReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenServicioDetallesReporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(535, 490);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // gelardiDataSet
            // 
            this.gelardiDataSet.DataSetName = "GelardiDataSet";
            this.gelardiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenServicioReporteBindingSource
            // 
            this.ordenServicioReporteBindingSource.DataMember = "OrdenServicioReporte";
            this.ordenServicioReporteBindingSource.DataSource = this.gelardiDataSet;
            // 
            // ordenServicioReporteTableAdapter
            // 
            this.ordenServicioReporteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.AutosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesContactoTableAdapter = null;
            this.tableAdapterManager.ClientesDomiciliosTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.LocalidadesTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.ordenServicioDetallesTableAdapter = null;
            this.tableAdapterManager.OrdenServicioReporteTableAdapter = this.ordenServicioReporteTableAdapter;
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
            // ordenServicioDetallesReporteBindingSource
            // 
            this.ordenServicioDetallesReporteBindingSource.DataMember = "OrdenServicioDetallesReporte";
            this.ordenServicioDetallesReporteBindingSource.DataSource = this.gelardiDataSet;
            // 
            // ordenServicioDetallesReporteTableAdapter
            // 
            this.ordenServicioDetallesReporteTableAdapter.ClearBeforeFill = true;
            // 
            // frOrdenServicioReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 490);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frOrdenServicioReport";
            this.Load += new System.EventHandler(this.frOrdenServicioReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gelardiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenServicioReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenServicioDetallesReporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private GelardiDataSet gelardiDataSet;
        private System.Windows.Forms.BindingSource ordenServicioReporteBindingSource;
        private GelardiDataSetTableAdapters.OrdenServicioReporteTableAdapter ordenServicioReporteTableAdapter;
        private GelardiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource ordenServicioDetallesReporteBindingSource;
        private GelardiDataSetTableAdapters.OrdenServicioDetallesReporteTableAdapter ordenServicioDetallesReporteTableAdapter;
    }
}