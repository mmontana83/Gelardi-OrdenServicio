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

namespace Gelardi.Formularios
{
    public partial class frAutosTodos : DevExpress.XtraEditors.XtraForm
    {
        public frAutosTodos()
        {
            InitializeComponent();
        }

        private void frAutosTodos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.ListadoAutos' Puede moverla o quitarla según sea necesario.
            this.listadoAutosTableAdapter.Fill(this.gelardiDataSet.ListadoAutos);

        }
    }
}