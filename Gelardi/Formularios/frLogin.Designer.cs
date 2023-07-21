
namespace Gelardi.Formularios
{
    partial class frLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLogin));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEditUsuario = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btAcceder = new DevExpress.XtraEditors.SimpleButton();
            this.btPass = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btClose = new System.Windows.Forms.PictureBox();
            this.btMin = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gelardiDataSet = new Gelardi.GelardiDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new Gelardi.GelardiDataSetTableAdapters.EmpleadosTableAdapter();
            this.tableAdapterManager = new Gelardi.GelardiDataSetTableAdapters.TableAdapterManager();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Gelardi.GelardiDataSetTableAdapters.LoginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelardiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.pictureBox2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(322, 399);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEditPassword);
            this.layoutControl1.Controls.Add(this.textEditUsuario);
            this.layoutControl1.Location = new System.Drawing.Point(378, 87);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1039, 0, 650, 400);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(626, 196);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.simpleSeparator1,
            this.emptySpaceItem2,
            this.simpleSeparator2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(626, 196);
            this.Root.TextVisible = false;
            // 
            // textEditUsuario
            // 
            this.textEditUsuario.EditValue = "USUARIO";
            this.textEditUsuario.Location = new System.Drawing.Point(16, 16);
            this.textEditUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEditUsuario.Name = "textEditUsuario";
            this.textEditUsuario.Properties.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.textEditUsuario.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditUsuario.Properties.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.textEditUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.textEditUsuario.Properties.Appearance.Options.UseFont = true;
            this.textEditUsuario.Properties.Appearance.Options.UseForeColor = true;
            this.textEditUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditUsuario.Size = new System.Drawing.Size(594, 26);
            this.textEditUsuario.StyleController = this.layoutControl1;
            this.textEditUsuario.TabIndex = 1;
            this.textEditUsuario.Enter += new System.EventHandler(this.textEditUsuario_Enter);
            this.textEditUsuario.Leave += new System.EventHandler(this.textEditUsuario_Leave);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEditUsuario;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(600, 32);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 101);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(600, 69);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // textEditPassword
            // 
            this.textEditPassword.EditValue = "CONTRASEÑA";
            this.textEditPassword.Location = new System.Drawing.Point(16, 84);
            this.textEditPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.textEditPassword.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPassword.Properties.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.textEditPassword.Properties.Appearance.Options.UseBackColor = true;
            this.textEditPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditPassword.Properties.Appearance.Options.UseForeColor = true;
            this.textEditPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditPassword.Size = new System.Drawing.Size(594, 26);
            this.textEditPassword.StyleController = this.layoutControl1;
            this.textEditPassword.TabIndex = 2;
            this.textEditPassword.Enter += new System.EventHandler(this.textEditPassword_Enter);
            this.textEditPassword.Leave += new System.EventHandler(this.textEditPassword_Leave);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEditPassword;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(600, 32);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 32);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(600, 1);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 33);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(600, 35);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 100);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(600, 1);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(658, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 30);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "LOGIN";
            // 
            // btAcceder
            // 
            this.btAcceder.Appearance.BackColor = System.Drawing.Color.Gray;
            this.btAcceder.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btAcceder.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcceder.Appearance.Options.UseBackColor = true;
            this.btAcceder.Appearance.Options.UseBorderColor = true;
            this.btAcceder.Appearance.Options.UseFont = true;
            this.btAcceder.Location = new System.Drawing.Point(394, 291);
            this.btAcceder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAcceder.Name = "btAcceder";
            this.btAcceder.Size = new System.Drawing.Size(594, 53);
            this.btAcceder.TabIndex = 3;
            this.btAcceder.Text = "ACCEDER";
            this.btAcceder.Click += new System.EventHandler(this.btAcceder_Click);
            // 
            // btPass
            // 
            this.btPass.Appearance.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btPass.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.btPass.Appearance.LinkColor = System.Drawing.Color.Gray;
            this.btPass.Appearance.Options.UseFont = true;
            this.btPass.Appearance.Options.UseForeColor = true;
            this.btPass.Appearance.Options.UseLinkColor = true;
            this.btPass.Appearance.Options.UsePressedColor = true;
            this.btPass.Appearance.PressedColor = System.Drawing.Color.White;
            this.btPass.Location = new System.Drawing.Point(574, 352);
            this.btPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPass.Name = "btPass";
            this.btPass.Size = new System.Drawing.Size(193, 17);
            this.btPass.TabIndex = 0;
            this.btPass.Text = "¿Ha olvidado la Contraseña?";
            // 
            // btClose
            // 
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.Location = new System.Drawing.Point(1018, 4);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(20, 19);
            this.btClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btClose.TabIndex = 5;
            this.btClose.TabStop = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMin
            // 
            this.btMin.Image = ((System.Drawing.Image)(resources.GetObject("btMin.Image")));
            this.btMin.Location = new System.Drawing.Point(990, 4);
            this.btMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(20, 19);
            this.btMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMin.TabIndex = 6;
            this.btMin.TabStop = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // gelardiDataSet
            // 
            this.gelardiDataSet.DataSetName = "GelardiDataSet";
            this.gelardiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.gelardiDataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.AutosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesContactoTableAdapter = null;
            this.tableAdapterManager.ClientesDomiciliosTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = this.empleadosTableAdapter;
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
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.gelardiDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // frLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 399);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btPass);
            this.Controls.Add(this.btAcceder);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frLogin";
            this.Load += new System.EventHandler(this.frLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelardiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.TextEdit textEditUsuario;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btAcceder;
        private DevExpress.XtraEditors.HyperlinkLabelControl btPass;
        private System.Windows.Forms.PictureBox btClose;
        private System.Windows.Forms.PictureBox btMin;
        private GelardiDataSet gelardiDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private GelardiDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private GelardiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private GelardiDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
    }
}