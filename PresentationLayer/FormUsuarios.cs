using BusinessLogicalLayer;
using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        UserBLL userBLL = new UserBLL();
        List<string> enderecoNomesColunas = new List<string>();

        private void UpdateGridView()
        {
            //QueryResponse<User> response = userBLL.GetAll();
            //if (response.Success)
            //{
            //    dgvUsuarios.DataSource = response.Data;
            //}
            //else
            //{
            //    MessageBox.Show(response.Message);
            //}
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtCpf.Text == "Por CPF...")
            {
                txtCpf.Text = "";
                txtCpf.ForeColor = Color.FromArgb(230, 180, 83);
                linhaCpf.BackColor = Color.Silver;
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (txtCpf.Text == "")
            {
                txtCpf.Text = "Por CPF...";
                txtCpf.ForeColor = Color.Silver;
                linhaCpf.BackColor = Color.FromArgb(230, 180, 83);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text == "Por CPF...")
            {
                UpdateGridView();
            }
            else
            {
                SingleResponse<User> response = userBLL.GetUserByCPF(txtCpf.Text);
                if (response.Success)
                {
                    dgvUsuarios.DataSource = new List<User>() { response.Data };
                }
                else
                {
                    MessageBox.Show(response.Message);
                }
            }
            foreach (DataGridViewColumn column in dgvUsuarios.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (panelFiltro.Visible == true)
            {
                panelFiltro.Visible = false;
            }
            else
            {
                panelFiltro.Visible = true;
            }
        }

        private void Filtrar(string nomeColuna, Button botao)
        {
            foreach (DataGridViewColumn dgvcolumn in dgvUsuarios.Columns)
            {
                if (dgvcolumn.Name == nomeColuna)
                {
                    if (botao.BackColor == Color.Black)
                    {
                        dgvcolumn.Visible = false;
                        botao.BackColor = Color.Gray;
                        botao.ForeColor = Color.Black;
                    }
                    else
                    {
                        dgvcolumn.Visible = true;
                        botao.BackColor = Color.Black;
                        botao.ForeColor = Color.FromArgb(230, 180, 83);
                    }
                }
            }
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            Filtrar("Nome", btnNome);
        }

        private void btnCPF_Click(object sender, EventArgs e)
        {
            Filtrar("CPF", btnCPF);
        }

        private void btnRG_Click(object sender, EventArgs e)
        {
            Filtrar("RG", btnRG);
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            Filtrar("Email", btnTelefone);
        }

        private void btnTelefone_Click(object sender, EventArgs e)
        {
            Filtrar("Telefone", btnTelefone2);
        }

        private void btnTelefone2_Click(object sender, EventArgs e)
        {
            Filtrar("Telefone_aux", btnTelefone2);
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            enderecoNomesColunas.Add("EnderecoId");
            enderecoNomesColunas.Add("Endereco");
            enderecoNomesColunas.Add("Rua");
            enderecoNomesColunas.Add("Bairro");
            enderecoNomesColunas.Add("Cidade");
            enderecoNomesColunas.Add("UF");
            enderecoNomesColunas.Add("CEP");
            enderecoNomesColunas.Add("Pais");
            enderecoNomesColunas.Add("Numero");

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Environment.CurrentDirectory, @"Fonts\", "GatsbyFLF-Bold.ttf"));

            labelUsuarios.Font = new Font(pfc.Families[0], 36, FontStyle.Bold);
            txtCpf.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);
            btnBuscar.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnNome.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnCPF.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnRG.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnTelefone.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnTelefone2.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnEmail.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnDeletar.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnFiltrar.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnEditar.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
        }
    }
}
