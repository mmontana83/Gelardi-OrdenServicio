using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gelardi.Formularios
{
    public partial class frTurnos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frTurnos()
        {
            InitializeComponent();
        }

        private void frTurnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Resources' Puede moverla o quitarla según sea necesario.
            this.resourcesTableAdapter.Fill(this.gelardiDataSet.Resources);
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Appointments' Puede moverla o quitarla según sea necesario.
            this.appointmentsTableAdapter.Fill(this.gelardiDataSet.Appointments);

            schedulerControl1.Start = DateTime.Now;
            schedulerControl1.DayView.ShowWorkTimeOnly = true;
        }

        private void schedulerDataStorage1_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(gelardiDataSet);
            gelardiDataSet.AcceptChanges();

        }
    }
}