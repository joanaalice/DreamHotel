using BusinessLogicalLayer;
using Common;
<<<<<<< HEAD
using PresentationLayer.Messages;
=======
using Entities;
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
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
                txtSenha.Font = new Font(txtSenha.Font.Name, 10, txtSenha.Font.Style);
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
                txtSenha.Font = new Font(txtSenha.Font.Name, 20, txtSenha.Font.Style);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            userBLL.GetUserLogin(txtUsuario.Text, txtSenha.Text);
<<<<<<< HEAD
            if (IsUserLog.IsUserLoged())
            {
                FormIndex formIndex = new FormIndex();
=======
            if (WhoIsUserLog.IsUserLoged())
            {
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
                formIndex.Show();
                this.Hide();
            }
            else
            {
<<<<<<< HEAD
                Form form = new FormNaoCadastrado("Usuário não encontrado.");
                form.Show();
            }
           
=======
                MessageBox.Show("NEGATIVO");
            }
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Environment.CurrentDirectory, @"Fonts\", "GatsbyFLF-Bold.ttf"));

            txtSenha.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtUsuario.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            labelLogin.Font = new Font(pfc.Families[0], 36, FontStyle.Bold);
            btnLogin.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);


        }
    }
}
