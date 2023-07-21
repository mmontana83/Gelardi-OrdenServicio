using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace Gelardi
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            WindowsFormsSettings.ForceDirectXPaint();
            WindowsFormsSettings.EnableFormSkins();

            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();

            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formularios.frMain());
            //Application.Run(new Formularios.frLogin());
        }
    }
}
