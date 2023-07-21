using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Gelardi.Formularios
{
    public partial class frMain : DevExpress.XtraEditors.XtraForm
    {
        private string Usuario;
        private int idTipoEmpleado;

        public frMain()
        {
            InitializeComponent();
        }

        public frMain(string Usuario, int idTipoEmpleado)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            this.idTipoEmpleado = idTipoEmpleado;
            this.Text = "Concesionario Honda | Gelardi S.R.L | Usuario: " + Usuario;
        }

        private void barButtonItemClienteNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frClienteNuevo nuevoClienteForm = new frClienteNuevo();
            nuevoClienteForm.MdiParent = this;
            nuevoClienteForm.Show();
        }
        private void barButtonItemClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frClientesTodos listadoGeneral = new frClientesTodos();
            listadoGeneral.MdiParent = this;
            listadoGeneral.Show();
        }

        private void barButtonItemAutoNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frAutoNuevo nuevoAutoForm = new frAutoNuevo();
            nuevoAutoForm.MdiParent = this;
            nuevoAutoForm.Show();
        }

        private void barButtonItemTurnos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frTurnos formularioTurnos = new frTurnos();
            formularioTurnos.MdiParent = this;
            formularioTurnos.Show();
        }

        private void barButtonItemNuevaOrden_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frOrdenServicio nuevaOrdenServicio = new frOrdenServicio();
            nuevaOrdenServicio.MdiParent = this;
            nuevaOrdenServicio.Show();
        }

        private void barButtonItemListadoOrden_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frOrdenServicioListado listadoOrdenes = new frOrdenServicioListado();
            listadoOrdenes.MdiParent = this;
            listadoOrdenes.Show();
        }

        private void barButtonItemAutos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frAutosTodos listadoAutos = new frAutosTodos();
            listadoAutos.MdiParent = this;
            listadoAutos.Show();
        }
    }
}