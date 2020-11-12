using BusinessLogicalLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.CEP;
using System.Drawing.Text;
using System.IO;
using System.Collections.ObjectModel;
using Common;
using PresentationLayer.Messages;

namespace PresentationLayer
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.FromArgb(230, 180, 83);
                linhaNome.BackColor = Color.Silver;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome";
                txtNome.ForeColor = Color.Silver;
                linhaNome.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtCpf.Text == "CPF")
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
                txtCpf.Text = "CPF";
                txtCpf.ForeColor = Color.Silver;
                linhaCpf.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtRg_Enter(object sender, EventArgs e)
        {
            if (txtRg.Text == "RG")
            {
                txtRg.Text = "";
                txtRg.ForeColor = Color.FromArgb(230, 180, 83);
                linhaRg.BackColor = Color.Silver;
            }
        }

        private void txtRg_Leave(object sender, EventArgs e)
        {
            if (txtRg.Text == "")
            {
                txtRg.Text = "RG";
                txtRg.ForeColor = Color.Silver;
                linhaRg.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "Telefone")
            {
                txtTelefone.Text = "";
                txtTelefone.ForeColor = Color.FromArgb(230, 180, 83);
                linhaTelefone.BackColor = Color.Silver;
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                txtTelefone.Text = "Telefone";
                txtTelefone.ForeColor = Color.Silver;
                linhaTelefone.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtTelefone2_Enter(object sender, EventArgs e)
        {
            if (txtTelefone2.Text == "Telefone*")
            {
                txtTelefone2.Text = "";
                txtTelefone2.ForeColor = Color.FromArgb(230, 180, 83);
                linhaTelefone2.BackColor = Color.Silver;
            }
        }

        private void txtTelefone2_Leave(object sender, EventArgs e)
        {
            if (txtTelefone2.Text == "")
            {
                txtTelefone2.Text = "Telefone*";
                txtTelefone2.ForeColor = Color.Silver;
                linhaTelefone2.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtCep_Enter(object sender, EventArgs e)
        {
            if (txtCep.Text == "CEP")
            {
                txtCep.Text = "";
                txtCep.ForeColor = Color.FromArgb(230, 180, 83);
                linhaCep.BackColor = Color.Silver;
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (txtCep.Text == "")
            {
                txtCep.Text = "CEP";
                txtCep.ForeColor = Color.Silver;
                linhaCep.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtPais_Enter(object sender, EventArgs e)
        {
            if (txtPais.Text == "País")
            {
                txtPais.Text = "";
                txtPais.ForeColor = Color.FromArgb(230, 180, 83);
                linhaPais.BackColor = Color.Silver;
            }
        }

        private void txtPais_Leave(object sender, EventArgs e)
        {
            if (txtPais.Text == "")
            {
                txtPais.Text = "País";
                txtPais.ForeColor = Color.Silver;
                linhaPais.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtUf_Enter(object sender, EventArgs e)
        {
            if (txtUf.Text == "UF")
            {
                txtUf.Text = "";
                txtUf.ForeColor = Color.FromArgb(230, 180, 83);
                LinhaUf.BackColor = Color.Silver;
            }
        }

        private void txtUf_Leave(object sender, EventArgs e)
        {
            if (txtUf.Text == "")
            {
                txtUf.Text = "UF";
                txtUf.ForeColor = Color.Silver;
                LinhaUf.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtCidade_Enter(object sender, EventArgs e)
        {
            if (txtCidade.Text == "Cidade")
            {
                txtCidade.Text = "";
                txtCidade.ForeColor = Color.FromArgb(230, 180, 83);
                linhaCidade.BackColor = Color.Silver;
            }
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            if (txtCidade.Text == "")
            {
                txtCidade.Text = "Cidade";
                txtCidade.ForeColor = Color.Silver;
                linhaCidade.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtBairro_Enter(object sender, EventArgs e)
        {
            if (txtBairro.Text == "Bairro")
            {
                txtBairro.Text = "";
                txtBairro.ForeColor = Color.FromArgb(230, 180, 83);
                linhaBairro.BackColor = Color.Silver;
            }
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            if (txtBairro.Text == "")
            {
                txtBairro.Text = "Bairro";
                txtBairro.ForeColor = Color.Silver;
                linhaBairro.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtRua_Enter(object sender, EventArgs e)
        {
            if (txtRua.Text == "Rua")
            {
                txtRua.Text = "";
                txtRua.ForeColor = Color.FromArgb(230, 180, 83);
                linhaRua.BackColor = Color.Silver;
            }
        }

        private void txtRua_Leave(object sender, EventArgs e)
        {
            if (txtRua.Text == "")
            {
                txtRua.Text = "Rua";
                txtRua.ForeColor = Color.Silver;
                linhaRua.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {

            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.FromArgb(230, 180, 83);
                linhaEmail.BackColor = Color.Silver;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
                linhaEmail.BackColor = Color.FromArgb(230, 180, 83);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            CustomerBLL customerBLL = new CustomerBLL();
            Response response = new Response();
            customer.Nome = txtNome.Text;
            customer.CPF = txtCpf.Text;
            customer.RG = txtRg.Text;
            customer.Email = txtEmail.Text;
            customer.Telefone = txtTelefone.Text;
            if (txtTelefone2.Text != "Telefone*")
            {
                customer.Telefone_Aux = txtTelefone2.Text;
            }
            else
            {
                customer.Telefone_Aux = "Não informado";
            }
            customer.Endereco.CEP = txtCep.Text;
            customer.Endereco.Pais = txtPais.Text;
            customer.Endereco.Rua = txtRua.Text;
            customer.Endereco.UF = txtUf.Text;
            customer.Endereco.Cidade = txtCidade.Text;
            customer.Endereco.Bairro = txtBairro.Text;
            customer.Endereco.Numero = txtNumero.Text;

            response = customerBLL.InsertAddressCustomerTransaction(customer);

            if (response.Success)
            {
                Form form = new FormCadastradoComSucesso();
                form.Show();
            }
            else
            {
                Form form = new FormNaoCadastrado(response.Message);
                form.Show();
            }

        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Environment.CurrentDirectory, @"Fonts\", "GatsbyFLF-Bold.ttf"));

            txtNome.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtCpf.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtRg.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtTelefone.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtTelefone2.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtCep.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtPais.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtUf.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtCidade.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtBairro.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtRua.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtNumero.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtEmail.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnCadastrar.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);
            labelCadastrarCliente.Font = new Font(pfc.Families[0], 36, FontStyle.Bold);
            labelDadosPessoais.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);
            labelEndereco.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);
        }

        private void panelDadosPessoais_MouseEnter(object sender, EventArgs e)
        {
            if (txtNome.Text != "Nome" && txtCpf.Text != "CPF" && txtRg.Text != "RG" && txtEmail.Text != "Email" && txtTelefone.Text != "Telefone" && txtCep.Text != "CEP" && txtPais.Text != "País" && txtRua.Text != "Rua" && txtBairro.Text != "Bairro" && txtCidade.Text != "Cidade" && txtUf.Text != "UF" && txtNumero.Text != "Número")
            {
                btnCadastrar.BackColor = Color.Black;
                btnCadastrar.ForeColor = Color.FromArgb(230, 180, 83);
                btnCadastrar.Enabled = true;
                btnCadastrar.Cursor = Cursors.Hand;
            }
            else
            {
                btnCadastrar.BackColor = Color.FromArgb(20, 20, 20);
                btnCadastrar.ForeColor = Color.Silver;
                btnCadastrar.Enabled = false;
                btnCadastrar.Cursor = Cursors.Default;
            }
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            if (txtNumero.Text == "Número")
            {
                txtNumero.Text = "";
                txtNumero.ForeColor = Color.FromArgb(230, 180, 83);
                linhaNumero.BackColor = Color.Silver;
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                txtNumero.Text = "Número";
                txtNumero.ForeColor = Color.Silver;
                linhaNumero.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

    }
}
