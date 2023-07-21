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
using System.Runtime.InteropServices;

namespace Gelardi.Formularios
{
    public partial class frLogin : DevExpress.XtraEditors.XtraForm
    {
        public frLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textEditUsuario_Enter(object sender, EventArgs e)
        {
            if (textEditUsuario.Text == "USUARIO")
            {
                textEditUsuario.Text = "";
                textEditUsuario.ForeColor = Color.White;
            }
        }

        private void textEditUsuario_Leave(object sender, EventArgs e)
        {
            if (textEditUsuario.Text == "")
            {
                textEditUsuario.Text = "USUARIO";
                textEditUsuario.ForeColor = Color.LightGray;
            }
        }

        private void textEditPassword_Enter(object sender, EventArgs e)
        {
            if (textEditPassword.Text == "CONTRASEÑA")
            {
                textEditPassword.Text = "";
                textEditPassword.ForeColor = Color.White;
                textEditPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void textEditPassword_Leave(object sender, EventArgs e)
        {
            if (textEditPassword.Text == "")
            {
                textEditPassword.Properties.UseSystemPasswordChar = false;
                textEditPassword.Text = "CONTRASEÑA";
                textEditPassword.ForeColor = Color.LightGray;
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gelardiDataSet.Login' Puede moverla o quitarla según sea necesario.
            this.loginTableAdapter.Fill(this.gelardiDataSet.Login);
            btAcceder.Focus();
        }

        private void frLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btAcceder_Click(object sender, EventArgs e)
        {
            if (textEditUsuario.Text != "USUARIO")
            {
                if (textEditPassword.Text != "CONTRASEÑA")
                {
                    if ((int)empleadosTableAdapter.countLogin(textEditUsuario.Text, textEditPassword.Text) == 1)
                    {
                        //Recupero los datos del usuario que se loguea
                        GelardiDataSet.EmpleadosDataTable dt = new GelardiDataSet.EmpleadosDataTable();
                        empleadosTableAdapter.FillByLogin(dt,textEditUsuario.Text, textEditPassword.Text);
                        
                        string documento = dt[0]["documento"].ToString();
                        int idTipoEmpleado = (int) dt[0]["idTipoEmpleado"];
                        string usuario = dt.Rows[0]["nombres"].ToString() + " " + dt.Rows[0]["apellidos"].ToString();
                        string nombrePC = System.Environment.MachineName;

                        //Guardo un registro de quién ingresa al sistema.
                        loginTableAdapter.Insert(documento, DateTime.Now, "", "", nombrePC);                        
                        
                        //Muestro el formulario principal
                        Formularios.frMain frMain = new frMain(usuario,idTipoEmpleado);
                        frMain.Show();

                        //Cuando el formulario principal se cierre, volveré a mostrar la ventana de Loguin
                        frMain.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        XtraMessageBox.Show("Usuario y/o Contraseña Incorrecta. \n   Por favor trate nuevamente.");
                        textEditPassword.Text = "CONTRASEÑA";
                        textEditPassword.Properties.UseSystemPasswordChar = false;
                        textEditUsuario.Text = "USUARIO";
                        textEditPassword.Focus();
                    }
                }
                else XtraMessageBox.Show("Ingrese una Contraseña por favor.");
            }
            else XtraMessageBox.Show("Ingrese un Usuario por favor.");
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            textEditPassword.Text = "CONTRASEÑA";
            textEditPassword.Properties.UseSystemPasswordChar = false;
            textEditUsuario.Text = "USUARIO";
            //lblErrorMessage.Visible = false;
            this.Show();
        }

    }
}