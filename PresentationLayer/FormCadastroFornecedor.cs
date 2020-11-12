using BusinessLogicalLayer;
using Common;
using Entities;
using PresentationLayer.Messages;
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
    public partial class FormCadastroFornecedor : Form
    {
        public FormCadastroFornecedor()
        {
            InitializeComponent();
        }

        #region Enter Leave TextBoxes

        private void enterTextBox(TextBox txt, Label linha, string nome)
        {
            if (txt.Text == nome)
            {
                txt.Text = "";
                txt.ForeColor = Color.FromArgb(230, 180, 83);
                linha.BackColor = Color.Silver;
            }
        }
        private void leaveTextBox(TextBox txt, Label linha, string nome)
        {
            if (txt.Text == "")
            {
                txt.Text = nome;
                txt.ForeColor = Color.Silver;
                linha.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtNome, linhaNome, "Nome do Contato");
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtNome, linhaNome, "Nome do Contato");
        }

        private void txtCnpj_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtCnpj, linhaCnpj, "CNPJ");
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtCnpj, linhaCnpj, "CNPJ");
        }

        private void txtRazaoSocial_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtRazaoSocial, linhaRazaoSocial, "Razao Social");
        }

        private void txtRazaoSocial_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtRazaoSocial, linhaRazaoSocial, "Razao Social");
        }

        private void txtNomeFantasia_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtNomeFantasia, linhaNomeFantasia, "Nome Fantasia");
        }

        private void txtNomeFantasia_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtNomeFantasia, linhaNomeFantasia, "Nome Fantasia");
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtTelefone, linhaTelefone, "Telefone");
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtTelefone, linhaTelefone, "Telefone");
        }

        private void txtTelefone2_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtTelefone2, linhaTelefone2, "Telefone*");
        }

        private void txtTelefone2_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtTelefone2, linhaTelefone2, "Telefone*");
        }

        private void txtCep_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtCep, linhaCep, "Cep");
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtCep, linhaCep, "Cep");
        }

        private void txtPais_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtPais, linhaPais, "País");
        }

        private void txtPais_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtPais, linhaPais, "País");
        }

        private void txtUf_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtUf, LinhaUf, "UF");
        }

        private void txtUf_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtPais, linhaPais, "País");
        }

        private void txtCidade_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtCidade, linhaCidade, "Cidade");
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtCidade, linhaCidade, "Cidade");
        }

        private void txtBairro_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtBairro, linhaBairro, "Bairro");
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtBairro, linhaBairro, "Bairro");
        }

        private void txtRua_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtRua, linhaRua, "Rua");
        }

        private void txtRua_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtRua, linhaRua, "Rua");
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            enterTextBox(txtNumero, linhaNumero, "Número");
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            leaveTextBox(txtNumero, linhaNumero, "Número");
        }

        #endregion

        #region Enable Button

        private void panelCadastroFornecedor_MouseEnter(object sender, EventArgs e)
        {
            if (txtNome.Text != "Nome do Contato" && txtCnpj.Text != "CNPJ" && txtRazaoSocial.Text != "Razao Social" && txtNomeFantasia.Text != "Nome Fantasia" && txtEmail.Text != "Email" && txtTelefone.Text != "Telefone" && txtCep.Text != "CEP" && txtPais.Text != "País" && txtRua.Text != "Rua" && txtBairro.Text != "Bairro" && txtCidade.Text != "Cidade" && txtUf.Text != "UF" && txtNumero.Text != "Número")
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

        #endregion

        #region Install Font

        private void FormCadastroFornecedor_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Environment.CurrentDirectory, @"Fonts\", "GatsbyFLF-Bold.ttf"));

            txtNome.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtCnpj.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtRazaoSocial.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtNomeFantasia.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
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
            labelCadastrarFornecedor.Font = new Font(pfc.Families[0], 36, FontStyle.Bold);
            labelDados.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);
            labelEndereco.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);
        }

        #endregion

        #region Insert Fornecedor

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            ProviderBLL providerBLL = new ProviderBLL();
            Response response = new Response();
            provider.NomeContato = txtNome.Text;
            provider.CNPJ = txtCnpj.Text;
            provider.NomeFantasia = txtNomeFantasia.Text;
            provider.RazaoSocial = txtRazaoSocial.Text;
            provider.Email = txtEmail.Text;
            provider.Telefone = txtTelefone.Text;
            if (txtTelefone2.Text != "Telefone*")
            {
                provider.Telefone_Aux = txtTelefone2.Text;
            }
            else
            {
                provider.Telefone_Aux = "Não informado";
            }
            provider.Endereco.CEP = txtCep.Text;
            provider.Endereco.Pais = txtPais.Text;
            provider.Endereco.Rua = txtRua.Text;
            provider.Endereco.UF = txtUf.Text;
            provider.Endereco.Cidade = txtCidade.Text;
            provider.Endereco.Bairro = txtBairro.Text;
            provider.Endereco.Numero = txtNumero.Text;

            response = providerBLL.InsertAddressProviderTransaction(provider);

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

        #endregion
    }
}
