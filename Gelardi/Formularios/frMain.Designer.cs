namespace Gelardi.Formularios
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItemOrdenServicio = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemNuevaOrden = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemListadoOrden = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemClientes = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemClienteNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemClientes = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemAutos = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemAutoNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAutos = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemTurnos = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemOrdenServicio,
            this.barSubItemClientes,
            this.barButtonItemClienteNuevo,
            this.barButtonItemClientes,
            this.barButtonItemNuevaOrden,
            this.barButtonItemListadoOrden,
            this.barButtonItemTurnos,
            this.barSubItemAutos,
            this.barButtonItemAutoNuevo,
            this.barCheckItem1,
            this.barButtonItemAutos});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Disabled.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Disabled.Options.UseFont = true;
            this.bar2.BarAppearance.Hovered.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Hovered.Options.UseFont = true;
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarAppearance.Pressed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Pressed.Options.UseFont = true;
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemOrdenServicio),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemClientes),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemAutos),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemTurnos)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // barSubItemOrdenServicio
            // 
            this.barSubItemOrdenServicio.Caption = "Orden de Servicio";
            this.barSubItemOrdenServicio.Id = 0;
            this.barSubItemOrdenServicio.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemNuevaOrden),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemListadoOrden)});
            this.barSubItemOrdenServicio.MenuAppearance.AppearanceMenu.Disabled.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemOrdenServicio.MenuAppearance.AppearanceMenu.Disabled.Options.UseFont = true;
            this.barSubItemOrdenServicio.MenuAppearance.AppearanceMenu.Hovered.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemOrdenServicio.MenuAppearance.AppearanceMenu.Hovered.Options.UseFont = true;
            this.barSubItemOrdenServicio.MenuAppearance.AppearanceMenu.Normal.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemOrdenServicio.MenuAppearance.AppearanceMenu.Normal.Options.UseFont = true;
            this.barSubItemOrdenServicio.MenuAppearance.AppearanceMenu.Pressed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemOrdenServicio.MenuAppearance.AppearanceMenu.Pressed.Options.UseFont = true;
            this.barSubItemOrdenServicio.Name = "barSubItemOrdenServicio";
            // 
            // barButtonItemNuevaOrden
            // 
            this.barButtonItemNuevaOrden.Caption = "Nueva";
            this.barButtonItemNuevaOrden.Id = 4;
            this.barButtonItemNuevaOrden.Name = "barButtonItemNuevaOrden";
            this.barButtonItemNuevaOrden.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNuevaOrden_ItemClick);
            // 
            // barButtonItemListadoOrden
            // 
            this.barButtonItemListadoOrden.Caption = "Listado";
            this.barButtonItemListadoOrden.Id = 5;
            this.barButtonItemListadoOrden.Name = "barButtonItemListadoOrden";
            this.barButtonItemListadoOrden.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemListadoOrden_ItemClick);
            // 
            // barSubItemClientes
            // 
            this.barSubItemClientes.Caption = "Clientes";
            this.barSubItemClientes.Id = 1;
            this.barSubItemClientes.ItemAppearance.Disabled.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.ItemAppearance.Disabled.Options.UseFont = true;
            this.barSubItemClientes.ItemAppearance.Hovered.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.ItemAppearance.Hovered.Options.UseFont = true;
            this.barSubItemClientes.ItemAppearance.Normal.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.ItemAppearance.Normal.Options.UseFont = true;
            this.barSubItemClientes.ItemAppearance.Pressed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.ItemAppearance.Pressed.Options.UseFont = true;
            this.barSubItemClientes.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.barSubItemClientes.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.barSubItemClientes.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.barSubItemClientes.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.barSubItemClientes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemClienteNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemClientes)});
            this.barSubItemClientes.MenuAppearance.AppearanceMenu.Disabled.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.MenuAppearance.AppearanceMenu.Disabled.Options.UseFont = true;
            this.barSubItemClientes.MenuAppearance.AppearanceMenu.Hovered.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.MenuAppearance.AppearanceMenu.Hovered.Options.UseFont = true;
            this.barSubItemClientes.MenuAppearance.AppearanceMenu.Normal.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.MenuAppearance.AppearanceMenu.Normal.Options.UseFont = true;
            this.barSubItemClientes.MenuAppearance.AppearanceMenu.Pressed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.MenuAppearance.AppearanceMenu.Pressed.Options.UseFont = true;
            this.barSubItemClientes.MenuAppearance.MenuBar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemClientes.MenuAppearance.MenuBar.Options.UseFont = true;
            this.barSubItemClientes.Name = "barSubItemClientes";
            // 
            // barButtonItemClienteNuevo
            // 
            this.barButtonItemClienteNuevo.Caption = "Nuevo";
            this.barButtonItemClienteNuevo.Id = 2;
            this.barButtonItemClienteNuevo.Name = "barButtonItemClienteNuevo";
            this.barButtonItemClienteNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemClienteNuevo_ItemClick);
            // 
            // barButtonItemClientes
            // 
            this.barButtonItemClientes.Caption = "Listado";
            this.barButtonItemClientes.Id = 3;
            this.barButtonItemClientes.Name = "barButtonItemClientes";
            this.barButtonItemClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemClientes_ItemClick);
            // 
            // barSubItemAutos
            // 
            this.barSubItemAutos.Caption = "Autos";
            this.barSubItemAutos.Id = 7;
            this.barSubItemAutos.ItemAppearance.Disabled.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemAutos.ItemAppearance.Disabled.Options.UseFont = true;
            this.barSubItemAutos.ItemAppearance.Hovered.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemAutos.ItemAppearance.Hovered.Options.UseFont = true;
            this.barSubItemAutos.ItemAppearance.Normal.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemAutos.ItemAppearance.Normal.Options.UseFont = true;
            this.barSubItemAutos.ItemAppearance.Pressed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemAutos.ItemAppearance.Pressed.Options.UseFont = true;
            this.barSubItemAutos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAutoNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAutos)});
            this.barSubItemAutos.MenuAppearance.AppearanceMenu.Disabled.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemAutos.MenuAppearance.AppearanceMenu.Disabled.Options.UseFont = true;
            this.barSubItemAutos.MenuAppearance.AppearanceMenu.Hovered.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemAutos.MenuAppearance.AppearanceMenu.Hovered.Options.UseFont = true;
            this.barSubItemAutos.MenuAppearance.AppearanceMenu.Normal.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemAutos.MenuAppearance.AppearanceMenu.Normal.Options.UseFont = true;
            this.barSubItemAutos.MenuAppearance.AppearanceMenu.Pressed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barSubItemAutos.MenuAppearance.AppearanceMenu.Pressed.Options.UseFont = true;
            this.barSubItemAutos.Name = "barSubItemAutos";
            // 
            // barButtonItemAutoNuevo
            // 
            this.barButtonItemAutoNuevo.Caption = "Nuevo";
            this.barButtonItemAutoNuevo.Id = 8;
            this.barButtonItemAutoNuevo.Name = "barButtonItemAutoNuevo";
            this.barButtonItemAutoNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAutoNuevo_ItemClick);
            // 
            // barButtonItemAutos
            // 
            this.barButtonItemAutos.Caption = "Listado";
            this.barButtonItemAutos.Id = 10;
            this.barButtonItemAutos.Name = "barButtonItemAutos";
            this.barButtonItemAutos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAutos_ItemClick);
            // 
            // barButtonItemTurnos
            // 
            this.barButtonItemTurnos.Caption = "Turnos";
            this.barButtonItemTurnos.Id = 6;
            this.barButtonItemTurnos.Name = "barButtonItemTurnos";
            this.barButtonItemTurnos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemTurnos_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1208, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 687);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1208, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 662);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1208, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 662);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 9;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // frMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 708);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frMain.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frMain";
            this.Text = "Gelardi S.R.L";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItemOrdenServicio;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNuevaOrden;
        private DevExpress.XtraBars.BarButtonItem barButtonItemListadoOrden;
        private DevExpress.XtraBars.BarSubItem barSubItemClientes;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClienteNuevo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClientes;
        private DevExpress.XtraBars.BarButtonItem barButtonItemTurnos;
        private DevExpress.XtraBars.BarSubItem barSubItemAutos;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAutoNuevo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAutos;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
    }
}