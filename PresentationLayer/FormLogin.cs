using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

       private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        } 

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuário ou email")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
                linhaUsuario.BackColor = Color.White;
            }
        }


        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuário ou email";
                txtUsuario.ForeColor = Color.Black;
                linhaUsuario.BackColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.White;
                txtSenha.Font = new Font(txtSenha.Font.Name, 10,
                txtSenha.Font.Style);
                txtSenha.UseSystemPasswordChar = true;
                linhaSenha.BackColor = Color.White;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Black;
                txtSenha.Font = new Font(txtSenha.Font.Name, 20,
                txtSenha.Font.Style);
                txtSenha.UseSystemPasswordChar = false;
                linhaSenha.BackColor = Color.Black;
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_MouseEnter(object sender, EventArgs e)
        {
            if (txtSenha.Text != "" && txtSenha.Text != "Senha" && txtUsuario.Text != "" && txtUsuario.Text != "Usuário ou email")
            {
                btnLogin.BackColor = Color.Black;
                btnLogin.Enabled = true;
                btnLogin.Cursor = Cursors.Hand;
            }
            else
            {
                btnLogin.BackColor = Color.FromArgb(20, 20, 20);
                btnLogin.Enabled = false;
            }
        }

        private FormIndex formIndex = new FormIndex();
        private void btnLogin_Click(object sender, EventArgs e)
        {

            formIndex.Show();
            this.Hide();
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
