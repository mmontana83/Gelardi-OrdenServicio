
namespace Gelardi.Formularios
{
    partial class frOrdenServicioListado
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
            this.ordenServicioBusquedaGridControl = new DevExpress.XtraGrid.GridControl();
            this.ordenServicioBusquedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gelardiDataSet = new Gelardi.GelardiDataSet();
            this.gridViewOrdenesServicio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDominio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRealización = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTécnico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ordenServicioBusquedaTableAdapter = new Gelardi.GelardiDataSetTableAdapters.OrdenServicioBusquedaTableAdapter();
            this.barButtonItemEditarOrden = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPrevisualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemEditar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.ordenServicioBusquedaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenServicioBusquedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelardiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenesServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ordenServicioBusquedaGridControl
            // 
            this.ordenServicioBusquedaGridControl.DataSource = this.ordenServicioBusquedaBindingSource;
            this.ordenServicioBusquedaGridControl.Location = new System.Drawing.Point(12, 34);
            this.ordenServicioBusquedaGridControl.MainView = this.gridViewOrdenesServicio;
            this.ordenServicioBusquedaGridControl.Name = "ordenServicioBusquedaGridControl";
            this.ordenServicioBusquedaGridControl.Size = new System.Drawing.Size(915, 326);
            this.ordenServicioBusquedaGridControl.TabIndex = 7;
            this.ordenServicioBusquedaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrdenesServicio});
            // 
            // ordenServicioBusquedaBindingSource
            // 
            this.ordenServicioBusquedaBindingSource.DataMember = "OrdenServicioBusqueda";
            this.ordenServicioBusquedaBindingSource.DataSource = this.gelardiDataSet;
            // 
            // gelardiDataSet
            // 
            this.gelardiDataSet.DataSetName = "GelardiDataSet";
            this.gelardiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewOrdenesServicio
            // 
            this.gridViewOrdenesServicio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCliente,
            this.colDocumento,
            this.colAuto,
            this.colDominio,
            this.colUnidad,
            this.colService,
            this.colFechaRealización,
            this.colTécnico});
            this.gridViewOrdenesServicio.GridControl = this.ordenServicioBusquedaGridControl;
            this.gridViewOrdenesServicio.GroupCount = 2;
            this.gridViewOrdenesServicio.Name = "gridViewOrdenesServicio";
            this.gridViewOrdenesServicio.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCliente, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDominio, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewOrdenesServicio.DoubleClick += new System.EventHandler(this.gridViewOrdenes_DoubleClick);
            // 
            // colCliente
            // 
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 0;
            // 
            // colDocumento
            // 
            this.colDocumento.FieldName = "Documento";
            this.colDocumento.Name = "colDocumento";
            this.colDocumento.Visible = true;
            this.colDocumento.VisibleIndex = 0;
            this.colDocumento.Width = 91;
            // 
            // colAuto
            // 
            this.colAuto.FieldName = "Auto";
            this.colAuto.Name = "colAuto";
            this.colAuto.Visible = true;
            this.colAuto.VisibleIndex = 1;
            // 
            // colDominio
            // 
            this.colDominio.FieldName = "Dominio";
            this.colDominio.Name = "colDominio";
            this.colDominio.Visible = true;
            this.colDominio.VisibleIndex = 2;
            // 
            // colUnidad
            // 
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 2;
            // 
            // colService
            // 
            this.colService.FieldName = "Service";
            this.colService.Name = "colService";
            this.colService.Visible = true;
            this.colService.VisibleIndex = 3;
            // 
            // colFechaRealización
            // 
            this.colFechaRealización.FieldName = "Fecha Realización";
            this.colFechaRealización.Name = "colFechaRealización";
            this.colFechaRealización.Visible = true;
            this.colFechaRealización.VisibleIndex = 4;
            // 
            // colTécnico
            // 
            this.colTécnico.FieldName = "Técnico";
            this.colTécnico.Name = "colTécnico";
            this.colTécnico.Visible = true;
            this.colTécnico.VisibleIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.simpleSeparator1,
            this.simpleSeparator2,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(939, 372);
            this.Root.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(918, 21);
            this.simpleLabelItem1.Text = "Búsqueda de Órdenes";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(141, 17);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 21);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(918, 1);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(918, 0);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(1, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ordenServicioBusquedaGridControl;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(919, 330);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ordenServicioBusquedaGridControl);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 24);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1154, 388, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(939, 372);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ordenServicioBusquedaTableAdapter
            // 
            this.ordenServicioBusquedaTableAdapter.ClearBeforeFill = true;
            // 
            // barButtonItemEditarOrden
            // 
            this.barButtonItemEditarOrden.Id = 6;
            this.barButtonItemEditarOrden.Name = "barButtonItemEditarOrden";
            // 
            // barButtonItemPrevisualizar
            // 
            this.barButtonItemPrevisualizar.Id = 7;
            this.barButtonItemPrevisualizar.Name = "barButtonItemPrevisualizar";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemEditarOrden,
            this.barButtonItemPrevisualizar,
            this.barSubItem1,
            this.barButtonItemEditar,
            this.barButtonItemImprimir});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.AutoUpdateMergedBars = DevExpress.Utils.DefaultBoolean.False;
            this.bar1.BarName = "Personalizada 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Personalizada 2";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Edición";
            this.barSubItem1.Id = 3;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemImprimir)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItemEditar
            // 
            this.barButtonItemEditar.Caption = "Editar Órden";
            this.barButtonItemEditar.Id = 4;
            this.barButtonItemEditar.Name = "barButtonItemEditar";
            this.barButtonItemEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditar_ItemClick);
            // 
            // barButtonItemImprimir
            // 
            this.barButtonItemImprimir.Caption = "Pre-Visualizar Órden";
            this.barButtonItemImprimir.Id = 5;
            this.barButtonItemImprimir.Name = "barButtonItemImprimir";
            this.barButtonItemImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemImprimir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(939, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 396);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(939, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 372);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(939, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 372);
            // 
            // frOrdenServicioListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 396);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frOrdenServicioListado";
            this.Text = "Ordenes de Servicio";
            this.Load += new System.EventHandler(this.frOrdenServicioListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordenServicioBusquedaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenServicioBusquedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelardiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenesServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private GelardiDataSet gelardiDataSet;
        private System.Windows.Forms.BindingSource ordenServicioBusquedaBindingSource;
        private GelardiDataSetTableAdapters.OrdenServicioBusquedaTableAdapter ordenServicioBusquedaTableAdapter;
        private DevExpress.XtraGrid.GridControl ordenServicioBusquedaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrdenesServicio;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDominio;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colAuto;
        private DevExpress.XtraGrid.Columns.GridColumn colService;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRealización;
        private DevExpress.XtraGrid.Columns.GridColumn colTécnico;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditarOrden;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrevisualizar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemImprimir;
    }
}