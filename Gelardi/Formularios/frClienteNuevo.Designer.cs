
namespace Gelardi.Formularios
{
    partial class frClienteNuevo
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frClienteNuevo));
            this.gelardiDataSet = new Gelardi.GelardiDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Gelardi.GelardiDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new Gelardi.GelardiDataSetTableAdapters.TableAdapterManager();
            this.clientesContactoTableAdapter = new Gelardi.GelardiDataSetTableAdapters.ClientesContactoTableAdapter();
            this.tipoContactoTableAdapter = new Gelardi.GelardiDataSetTableAdapters.tipoContactoTableAdapter();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageDatosPersonales = new DevExpress.XtraTab.XtraTabPage();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.documentoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.organizacionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nombresTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.apellidosTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.idtipoDocumento = new DevExpress.XtraEditors.LookUpEdit();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem36 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraTabPageContactos = new DevExpress.XtraTab.XtraTabPage();
            this.contactosGridControl = new DevExpress.XtraGrid.GridControl();
            this.clientesContactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewContactos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidClientesContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipoContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditTipoContacto = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tipoContactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colcontacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageDomicilio = new DevExpress.XtraTab.XtraTabPage();
            this.clientesDomiciliosGridControl = new DevExpress.XtraGrid.GridControl();
            this.clientesDomiciliosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDomicilios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidTipoDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditTipoDireccion = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tipoDireccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colcalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colnumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarrio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidLocalidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditLocalidad = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.localidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidPartido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPartido = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.partidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidProvincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditProvincia = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidPais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPais = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.clientesDataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.tipoDocumentoTableAdapter = new Gelardi.GelardiDataSetTableAdapters.tipoDocumentoTableAdapter();
            this.clientesDomiciliosTableAdapter = new Gelardi.GelardiDataSetTableAdapters.ClientesDomiciliosTableAdapter();
            this.tipoDireccionTableAdapter = new Gelardi.GelardiDataSetTableAdapters.tipoDireccionTableAdapter();
            this.paisesTableAdapter = new Gelardi.GelardiDataSetTableAdapters.PaisesTableAdapter();
            this.partidosTableAdapter = new Gelardi.GelardiDataSetTableAdapters.PartidosTableAdapter();
            this.provinciasTableAdapter = new Gelardi.GelardiDataSetTableAdapters.ProvinciasTableAdapter();
            this.localidadesTableAdapter = new Gelardi.GelardiDataSetTableAdapters.LocalidadesTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gelardiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizacionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombresTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apellidosTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipoDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).BeginInit();
            this.xtraTabPageContactos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesContactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTipoContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoContactoBindingSource)).BeginInit();
            this.xtraTabPageDomicilio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDomiciliosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDomiciliosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDomicilios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTipoDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDireccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPartido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gelardiDataSet
            // 
            this.gelardiDataSet.DataSetName = "GelardiDataSet";
            this.gelardiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.gelardiDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.AutosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesContactoTableAdapter = this.clientesContactoTableAdapter;
            this.tableAdapterManager.ClientesDomiciliosTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.LocalidadesTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.ordenServicioDetallesTableAdapter = null;
            this.tableAdapterManager.ordenServicioTableAdapter = null;
            this.tableAdapterManager.PaisesTableAdapter = null;
            this.tableAdapterManager.PartidosTableAdapter = null;
            this.tableAdapterManager.ProvinciasTableAdapter = null;
            this.tableAdapterManager.ResourcesTableAdapter = null;
            this.tableAdapterManager.tipoAutoModeloTableAdapter = null;
            this.tableAdapterManager.tipoAutoVersionTableAdapter = null;
            this.tableAdapterManager.tipoColorExteriorTableAdapter = null;
            this.tableAdapterManager.tipoColorInteriorTableAdapter = null;
            this.tableAdapterManager.tipoContactoTableAdapter = this.tipoContactoTableAdapter;
            this.tableAdapterManager.tipoDireccionTableAdapter = null;
            this.tableAdapterManager.tipoDocumentoTableAdapter = null;
            this.tableAdapterManager.tipoEmpleadoTableAdapter = null;
            this.tableAdapterManager.tipoMantenimientoTableAdapter = null;
            this.tableAdapterManager.tipoServicioDetallesTableAdapter = null;
            this.tableAdapterManager.tipoServicioTableAdapter = null;
            this.tableAdapterManager.tipoTransmisionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gelardi.GelardiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesContactoTableAdapter
            // 
            this.clientesContactoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoContactoTableAdapter
            // 
            this.tipoContactoTableAdapter.ClearBeforeFill = true;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageDatosPersonales;
            this.xtraTabControl1.Size = new System.Drawing.Size(477, 357);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageDatosPersonales,
            this.xtraTabPageContactos,
            this.xtraTabPageDomicilio});
            // 
            // xtraTabPageDatosPersonales
            // 
            this.xtraTabPageDatosPersonales.Controls.Add(this.dataLayoutControl1);
            this.xtraTabPageDatosPersonales.Name = "xtraTabPageDatosPersonales";
            this.xtraTabPageDatosPersonales.Size = new System.Drawing.Size(475, 328);
            this.xtraTabPageDatosPersonales.Text = "Datos Personales";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.documentoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.organizacionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.nombresTextEdit);
            this.dataLayoutControl1.Controls.Add(this.apellidosTextEdit);
            this.dataLayoutControl1.Controls.Add(this.idtipoDocumento);
            this.dataLayoutControl1.Controls.Add(this.notasMemoEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(958, 92, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(475, 328);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // documentoTextEdit
            // 
            this.documentoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientesBindingSource, "documento", true));
            this.documentoTextEdit.Location = new System.Drawing.Point(262, 96);
            this.documentoTextEdit.Name = "documentoTextEdit";
            this.documentoTextEdit.Size = new System.Drawing.Size(201, 24);
            this.documentoTextEdit.StyleController = this.dataLayoutControl1;
            this.documentoTextEdit.TabIndex = 4;
            this.documentoTextEdit.ToolTip = "Ingrese sólo Números (sin puntos, sin guiones)";
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Este campo no puede estar vacío";
            this.dxValidationProvider1.SetValidationRule(this.documentoTextEdit, conditionValidationRule1);
            // 
            // organizacionTextEdit
            // 
            this.organizacionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientesBindingSource, "organizacion", true));
            this.organizacionTextEdit.Location = new System.Drawing.Point(172, 68);
            this.organizacionTextEdit.Name = "organizacionTextEdit";
            this.organizacionTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.organizacionTextEdit.Size = new System.Drawing.Size(291, 24);
            this.organizacionTextEdit.StyleController = this.dataLayoutControl1;
            this.organizacionTextEdit.TabIndex = 2;
            // 
            // nombresTextEdit
            // 
            this.nombresTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientesBindingSource, "nombres", true));
            this.nombresTextEdit.Location = new System.Drawing.Point(172, 40);
            this.nombresTextEdit.Name = "nombresTextEdit";
            this.nombresTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombresTextEdit.Size = new System.Drawing.Size(291, 24);
            this.nombresTextEdit.StyleController = this.dataLayoutControl1;
            this.nombresTextEdit.TabIndex = 1;
            // 
            // apellidosTextEdit
            // 
            this.apellidosTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientesBindingSource, "apellidos", true));
            this.apellidosTextEdit.Location = new System.Drawing.Point(172, 12);
            this.apellidosTextEdit.Name = "apellidosTextEdit";
            this.apellidosTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apellidosTextEdit.Size = new System.Drawing.Size(291, 24);
            this.apellidosTextEdit.StyleController = this.dataLayoutControl1;
            this.apellidosTextEdit.TabIndex = 0;
            // 
            // idtipoDocumento
            // 
            this.idtipoDocumento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientesBindingSource, "idtipoDocumento", true));
            this.idtipoDocumento.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idtipoDocumento.Location = new System.Drawing.Point(172, 96);
            this.idtipoDocumento.Name = "idtipoDocumento";
            this.idtipoDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idtipoDocumento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idtipoDocumento", "idtipo Documento", 129, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipoDocumento", "Seleccione...", 117, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.idtipoDocumento.Properties.DataSource = this.tipoDocumentoBindingSource;
            this.idtipoDocumento.Properties.DisplayMember = "tipoDocumento";
            this.idtipoDocumento.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.idtipoDocumento.Properties.NullText = "";
            this.idtipoDocumento.Properties.ShowFooter = false;
            this.idtipoDocumento.Properties.ShowHeader = false;
            this.idtipoDocumento.Properties.ValueMember = "idtipoDocumento";
            this.idtipoDocumento.Size = new System.Drawing.Size(86, 24);
            this.idtipoDocumento.StyleController = this.dataLayoutControl1;
            this.idtipoDocumento.TabIndex = 3;
            conditionValidationRule2.ErrorText = "Este campo no puede estar vacío";
            this.dxValidationProvider1.SetValidationRule(this.idtipoDocumento, conditionValidationRule2);
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "tipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.gelardiDataSet;
            // 
            // notasMemoEdit
            // 
            this.notasMemoEdit.Location = new System.Drawing.Point(12, 145);
            this.notasMemoEdit.Name = "notasMemoEdit";
            this.notasMemoEdit.Size = new System.Drawing.Size(451, 170);
            this.notasMemoEdit.StyleController = this.dataLayoutControl1;
            this.notasMemoEdit.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.simpleSeparator1,
            this.simpleLabelItem1,
            this.layoutControlItem36});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(475, 328);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.apellidosTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(455, 28);
            this.layoutControlItem2.Text = "Apellidos:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(157, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.nombresTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(455, 28);
            this.layoutControlItem3.Text = "Nombres:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(157, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.organizacionTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(455, 28);
            this.layoutControlItem4.Text = "Organización:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(157, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem5.Control = this.idtipoDocumento;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(250, 28);
            this.layoutControlItem5.Text = "Tipo Doc. / Documento:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(157, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem6.Control = this.documentoTextEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(250, 84);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(205, 28);
            this.layoutControlItem6.Text = "documento:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 307);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(455, 1);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 112);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(455, 21);
            this.simpleLabelItem1.Text = "Otros Datos";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(157, 17);
            // 
            // layoutControlItem36
            // 
            this.layoutControlItem36.Control = this.notasMemoEdit;
            this.layoutControlItem36.Location = new System.Drawing.Point(0, 133);
            this.layoutControlItem36.Name = "layoutControlItem36";
            this.layoutControlItem36.Size = new System.Drawing.Size(455, 174);
            this.layoutControlItem36.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem36.TextVisible = false;
            // 
            // xtraTabPageContactos
            // 
            this.xtraTabPageContactos.Controls.Add(this.contactosGridControl);
            this.xtraTabPageContactos.Name = "xtraTabPageContactos";
            this.xtraTabPageContactos.Size = new System.Drawing.Size(475, 328);
            this.xtraTabPageContactos.Text = "Agregar Contactos...";
            // 
            // contactosGridControl
            // 
            this.contactosGridControl.DataSource = this.clientesContactoBindingSource;
            this.contactosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactosGridControl.Location = new System.Drawing.Point(0, 0);
            this.contactosGridControl.MainView = this.gridViewContactos;
            this.contactosGridControl.Name = "contactosGridControl";
            this.contactosGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditTipoContacto});
            this.contactosGridControl.Size = new System.Drawing.Size(475, 328);
            this.contactosGridControl.TabIndex = 6;
            this.contactosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContactos});
            this.contactosGridControl.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.contactosGridControl_PreviewKeyDown);
            // 
            // clientesContactoBindingSource
            // 
            this.clientesContactoBindingSource.DataMember = "ClientesContacto";
            this.clientesContactoBindingSource.DataSource = this.gelardiDataSet;
            // 
            // gridViewContactos
            // 
            this.gridViewContactos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidClientesContacto,
            this.colidTipoContacto,
            this.colcontacto,
            this.coldocumento});
            this.gridViewContactos.GridControl = this.contactosGridControl;
            this.gridViewContactos.Name = "gridViewContactos";
            this.gridViewContactos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewContactos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewContactos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewContactos.OptionsView.ShowGroupPanel = false;
            // 
            // colidClientesContacto
            // 
            this.colidClientesContacto.FieldName = "idClientesContacto";
            this.colidClientesContacto.Name = "colidClientesContacto";
            // 
            // colidTipoContacto
            // 
            this.colidTipoContacto.Caption = "Tipo de Contacto";
            this.colidTipoContacto.ColumnEdit = this.repositoryItemLookUpEditTipoContacto;
            this.colidTipoContacto.FieldName = "idTipoContacto";
            this.colidTipoContacto.Name = "colidTipoContacto";
            this.colidTipoContacto.Visible = true;
            this.colidTipoContacto.VisibleIndex = 0;
            this.colidTipoContacto.Width = 110;
            // 
            // repositoryItemLookUpEditTipoContacto
            // 
            this.repositoryItemLookUpEditTipoContacto.AutoHeight = false;
            this.repositoryItemLookUpEditTipoContacto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditTipoContacto.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idTipoContacto", "id Tipo Contacto", 119, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipoContacto", "tipo Contacto", 103, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEditTipoContacto.DataSource = this.tipoContactoBindingSource;
            this.repositoryItemLookUpEditTipoContacto.DisplayMember = "tipoContacto";
            this.repositoryItemLookUpEditTipoContacto.Name = "repositoryItemLookUpEditTipoContacto";
            this.repositoryItemLookUpEditTipoContacto.ShowFooter = false;
            this.repositoryItemLookUpEditTipoContacto.ShowHeader = false;
            this.repositoryItemLookUpEditTipoContacto.ShowLines = false;
            this.repositoryItemLookUpEditTipoContacto.ValueMember = "idTipoContacto";
            // 
            // tipoContactoBindingSource
            // 
            this.tipoContactoBindingSource.DataMember = "tipoContacto";
            this.tipoContactoBindingSource.DataSource = this.gelardiDataSet;
            // 
            // colcontacto
            // 
            this.colcontacto.Caption = "Contacto";
            this.colcontacto.FieldName = "contacto";
            this.colcontacto.Name = "colcontacto";
            this.colcontacto.Visible = true;
            this.colcontacto.VisibleIndex = 1;
            this.colcontacto.Width = 245;
            // 
            // coldocumento
            // 
            this.coldocumento.FieldName = "documento";
            this.coldocumento.Name = "coldocumento";
            // 
            // xtraTabPageDomicilio
            // 
            this.xtraTabPageDomicilio.AutoScroll = true;
            this.xtraTabPageDomicilio.Controls.Add(this.clientesDomiciliosGridControl);
            this.xtraTabPageDomicilio.Name = "xtraTabPageDomicilio";
            this.xtraTabPageDomicilio.Size = new System.Drawing.Size(475, 328);
            this.xtraTabPageDomicilio.Text = "Agregar Domicilios...";
            // 
            // clientesDomiciliosGridControl
            // 
            this.clientesDomiciliosGridControl.DataSource = this.clientesDomiciliosBindingSource;
            this.clientesDomiciliosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientesDomiciliosGridControl.Location = new System.Drawing.Point(0, 0);
            this.clientesDomiciliosGridControl.MainView = this.gridViewDomicilios;
            this.clientesDomiciliosGridControl.Name = "clientesDomiciliosGridControl";
            this.clientesDomiciliosGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditTipoDireccion,
            this.repositoryItemLookUpEditLocalidad,
            this.repositoryItemLookUpEditPartido,
            this.repositoryItemLookUpEditProvincia,
            this.repositoryItemLookUpEditPais,
            this.repositoryItemTextEdit1});
            this.clientesDomiciliosGridControl.Size = new System.Drawing.Size(475, 328);
            this.clientesDomiciliosGridControl.TabIndex = 0;
            this.clientesDomiciliosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDomicilios});
            this.clientesDomiciliosGridControl.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.clientesDomiciliosGridControl_PreviewKeyDown);
            // 
            // clientesDomiciliosBindingSource
            // 
            this.clientesDomiciliosBindingSource.DataMember = "ClientesDomicilios";
            this.clientesDomiciliosBindingSource.DataSource = this.gelardiDataSet;
            // 
            // gridViewDomicilios
            // 
            this.gridViewDomicilios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidTipoDireccion,
            this.colcalle,
            this.colnumero,
            this.colbarrio,
            this.colidLocalidad,
            this.colidPartido,
            this.colidProvincia,
            this.colidPais});
            this.gridViewDomicilios.GridControl = this.clientesDomiciliosGridControl;
            this.gridViewDomicilios.Name = "gridViewDomicilios";
            this.gridViewDomicilios.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewDomicilios.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewDomicilios.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewDomicilios.OptionsView.ShowGroupPanel = false;
            // 
            // colidTipoDireccion
            // 
            this.colidTipoDireccion.Caption = "Tipo de Dirección";
            this.colidTipoDireccion.ColumnEdit = this.repositoryItemLookUpEditTipoDireccion;
            this.colidTipoDireccion.FieldName = "idTipoDireccion";
            this.colidTipoDireccion.Name = "colidTipoDireccion";
            this.colidTipoDireccion.Visible = true;
            this.colidTipoDireccion.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEditTipoDireccion
            // 
            this.repositoryItemLookUpEditTipoDireccion.AutoHeight = false;
            this.repositoryItemLookUpEditTipoDireccion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditTipoDireccion.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idTipoDireccion", "id Tipo Direccion", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipoDireccion", "tipo Direccion", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEditTipoDireccion.DataSource = this.tipoDireccionBindingSource;
            this.repositoryItemLookUpEditTipoDireccion.DisplayMember = "tipoDireccion";
            this.repositoryItemLookUpEditTipoDireccion.Name = "repositoryItemLookUpEditTipoDireccion";
            this.repositoryItemLookUpEditTipoDireccion.ShowFooter = false;
            this.repositoryItemLookUpEditTipoDireccion.ShowHeader = false;
            this.repositoryItemLookUpEditTipoDireccion.ValueMember = "idTipoDireccion";
            // 
            // tipoDireccionBindingSource
            // 
            this.tipoDireccionBindingSource.DataMember = "tipoDireccion";
            this.tipoDireccionBindingSource.DataSource = this.gelardiDataSet;
            // 
            // colcalle
            // 
            this.colcalle.Caption = "Calle";
            this.colcalle.ColumnEdit = this.repositoryItemTextEdit1;
            this.colcalle.FieldName = "calle";
            this.colcalle.Name = "colcalle";
            this.colcalle.Visible = true;
            this.colcalle.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colnumero
            // 
            this.colnumero.Caption = "Número";
            this.colnumero.ColumnEdit = this.repositoryItemTextEdit1;
            this.colnumero.FieldName = "numero";
            this.colnumero.Name = "colnumero";
            this.colnumero.Visible = true;
            this.colnumero.VisibleIndex = 2;
            // 
            // colbarrio
            // 
            this.colbarrio.Caption = "Barrio";
            this.colbarrio.ColumnEdit = this.repositoryItemTextEdit1;
            this.colbarrio.FieldName = "barrio";
            this.colbarrio.Name = "colbarrio";
            this.colbarrio.Visible = true;
            this.colbarrio.VisibleIndex = 3;
            // 
            // colidLocalidad
            // 
            this.colidLocalidad.Caption = "Localidad";
            this.colidLocalidad.ColumnEdit = this.repositoryItemLookUpEditLocalidad;
            this.colidLocalidad.FieldName = "idLocalidad";
            this.colidLocalidad.Name = "colidLocalidad";
            this.colidLocalidad.Visible = true;
            this.colidLocalidad.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEditLocalidad
            // 
            this.repositoryItemLookUpEditLocalidad.AutoHeight = false;
            this.repositoryItemLookUpEditLocalidad.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditLocalidad.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idLocalidad", "id Localidad", 90, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("localidad", "localidad", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEditLocalidad.DataSource = this.localidadesBindingSource;
            this.repositoryItemLookUpEditLocalidad.DisplayMember = "localidad";
            this.repositoryItemLookUpEditLocalidad.Name = "repositoryItemLookUpEditLocalidad";
            this.repositoryItemLookUpEditLocalidad.ShowFooter = false;
            this.repositoryItemLookUpEditLocalidad.ShowHeader = false;
            this.repositoryItemLookUpEditLocalidad.ValueMember = "idLocalidad";
            // 
            // localidadesBindingSource
            // 
            this.localidadesBindingSource.DataMember = "Localidades";
            this.localidadesBindingSource.DataSource = this.gelardiDataSet;
            // 
            // colidPartido
            // 
            this.colidPartido.Caption = "Partido";
            this.colidPartido.ColumnEdit = this.repositoryItemLookUpEditPartido;
            this.colidPartido.FieldName = "idPartido";
            this.colidPartido.Name = "colidPartido";
            this.colidPartido.Visible = true;
            this.colidPartido.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEditPartido
            // 
            this.repositoryItemLookUpEditPartido.AutoHeight = false;
            this.repositoryItemLookUpEditPartido.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPartido.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idPartido", "id Partido", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("partido", "partido", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEditPartido.DataSource = this.partidosBindingSource;
            this.repositoryItemLookUpEditPartido.DisplayMember = "partido";
            this.repositoryItemLookUpEditPartido.Name = "repositoryItemLookUpEditPartido";
            this.repositoryItemLookUpEditPartido.ShowFooter = false;
            this.repositoryItemLookUpEditPartido.ShowHeader = false;
            this.repositoryItemLookUpEditPartido.ValueMember = "idPartido";
            // 
            // partidosBindingSource
            // 
            this.partidosBindingSource.DataMember = "Partidos";
            this.partidosBindingSource.DataSource = this.gelardiDataSet;
            // 
            // colidProvincia
            // 
            this.colidProvincia.Caption = "Provincia";
            this.colidProvincia.ColumnEdit = this.repositoryItemLookUpEditProvincia;
            this.colidProvincia.FieldName = "idProvincia";
            this.colidProvincia.Name = "colidProvincia";
            this.colidProvincia.Visible = true;
            this.colidProvincia.VisibleIndex = 6;
            // 
            // repositoryItemLookUpEditProvincia
            // 
            this.repositoryItemLookUpEditProvincia.AutoHeight = false;
            this.repositoryItemLookUpEditProvincia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditProvincia.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idProvincia", "id Provincia", 85, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("provincia", "provincia", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEditProvincia.DataSource = this.provinciasBindingSource;
            this.repositoryItemLookUpEditProvincia.DisplayMember = "provincia";
            this.repositoryItemLookUpEditProvincia.Name = "repositoryItemLookUpEditProvincia";
            this.repositoryItemLookUpEditProvincia.ShowFooter = false;
            this.repositoryItemLookUpEditProvincia.ShowHeader = false;
            this.repositoryItemLookUpEditProvincia.ValueMember = "idProvincia";
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "Provincias";
            this.provinciasBindingSource.DataSource = this.gelardiDataSet;
            // 
            // colidPais
            // 
            this.colidPais.Caption = "País";
            this.colidPais.ColumnEdit = this.repositoryItemLookUpEditPais;
            this.colidPais.FieldName = "idPais";
            this.colidPais.Name = "colidPais";
            this.colidPais.Visible = true;
            this.colidPais.VisibleIndex = 7;
            // 
            // repositoryItemLookUpEditPais
            // 
            this.repositoryItemLookUpEditPais.AutoHeight = false;
            this.repositoryItemLookUpEditPais.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPais.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idPais", "id Pais", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pais", "pais", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEditPais.DataSource = this.paisesBindingSource;
            this.repositoryItemLookUpEditPais.DisplayMember = "pais";
            this.repositoryItemLookUpEditPais.Name = "repositoryItemLookUpEditPais";
            this.repositoryItemLookUpEditPais.ValueMember = "idPais";
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "Paises";
            this.paisesBindingSource.DataSource = this.gelardiDataSet;
            // 
            // btGuardar
            // 
            this.btGuardar.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Appearance.Options.UseFont = true;
            this.btGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btGuardar.Location = new System.Drawing.Point(0, 357);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(477, 55);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "Guardar...";
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // clientesDataLayoutControl
            // 
            this.clientesDataLayoutControl.DataSource = this.clientesBindingSource;
            this.clientesDataLayoutControl.Location = new System.Drawing.Point(247, 430);
            this.clientesDataLayoutControl.Name = "clientesDataLayoutControl";
            this.clientesDataLayoutControl.Root = null;
            this.clientesDataLayoutControl.Size = new System.Drawing.Size(300, 220);
            this.clientesDataLayoutControl.TabIndex = 2;
            this.clientesDataLayoutControl.Text = "dataLayoutControl1";
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // clientesDomiciliosTableAdapter
            // 
            this.clientesDomiciliosTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDireccionTableAdapter
            // 
            this.tipoDireccionTableAdapter.ClearBeforeFill = true;
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
            // 
            // partidosTableAdapter
            // 
            this.partidosTableAdapter.ClearBeforeFill = true;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // localidadesTableAdapter
            // 
            this.localidadesTableAdapter.ClearBeforeFill = true;
            // 
            // frClienteNuevo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(477, 412);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btGuardar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frClienteNuevo.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frClienteNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente Nuevo";
            this.Load += new System.EventHandler(this.frClienteNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gelardiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageDatosPersonales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizacionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombresTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apellidosTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipoDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).EndInit();
            this.xtraTabPageContactos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contactosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesContactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTipoContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoContactoBindingSource)).EndInit();
            this.xtraTabPageDomicilio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesDomiciliosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDomiciliosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDomicilios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTipoDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDireccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPartido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GelardiDataSet gelardiDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private GelardiDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private GelardiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraDataLayout.DataLayoutControl clientesDataLayoutControl;
        private GelardiDataSetTableAdapters.ClientesContactoTableAdapter clientesContactoTableAdapter;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDatosPersonales;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit documentoTextEdit;
        private DevExpress.XtraEditors.TextEdit organizacionTextEdit;
        private DevExpress.XtraEditors.TextEdit nombresTextEdit;
        private DevExpress.XtraEditors.TextEdit apellidosTextEdit;
        private DevExpress.XtraEditors.LookUpEdit idtipoDocumento;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDomicilio;
        private DevExpress.XtraEditors.SimpleButton btGuardar;
        private System.Windows.Forms.BindingSource clientesContactoBindingSource;
        private GelardiDataSetTableAdapters.tipoContactoTableAdapter tipoContactoTableAdapter;
        private System.Windows.Forms.BindingSource tipoContactoBindingSource;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private GelardiDataSetTableAdapters.tipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.BindingSource clientesDomiciliosBindingSource;
        private GelardiDataSetTableAdapters.ClientesDomiciliosTableAdapter clientesDomiciliosTableAdapter;
        private DevExpress.XtraGrid.GridControl clientesDomiciliosGridControl;
        private System.Windows.Forms.BindingSource tipoDireccionBindingSource;
        private GelardiDataSetTableAdapters.tipoDireccionTableAdapter tipoDireccionTableAdapter;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private GelardiDataSetTableAdapters.PaisesTableAdapter paisesTableAdapter;
        private System.Windows.Forms.BindingSource partidosBindingSource;
        private GelardiDataSetTableAdapters.PartidosTableAdapter partidosTableAdapter;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private GelardiDataSetTableAdapters.ProvinciasTableAdapter provinciasTableAdapter;
        private System.Windows.Forms.BindingSource localidadesBindingSource;
        private GelardiDataSetTableAdapters.LocalidadesTableAdapter localidadesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditTipoDireccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditLocalidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPartido;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditProvincia;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPais;
        private DevExpress.XtraEditors.MemoEdit notasMemoEdit;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem36;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageContactos;
        private DevExpress.XtraGrid.GridControl contactosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewContactos;
        private DevExpress.XtraGrid.Columns.GridColumn colidClientesContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipoContacto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditTipoContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colcontacto;
        private DevExpress.XtraGrid.Columns.GridColumn coldocumento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDomicilios;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipoDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colcalle;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero;
        private DevExpress.XtraGrid.Columns.GridColumn colbarrio;
        private DevExpress.XtraGrid.Columns.GridColumn colidLocalidad;
        private DevExpress.XtraGrid.Columns.GridColumn colidPartido;
        private DevExpress.XtraGrid.Columns.GridColumn colidProvincia;
        private DevExpress.XtraGrid.Columns.GridColumn colidPais;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}