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

namespace PresentationLayer
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();

        }
        List<Control> controles = new List<Control>();

        private void FormCadastroCliente_MouseEnter(object sender, EventArgs e)
        {
            foreach (Panel panel in this.Controls.OfType<Panel>())
            {
                foreach (TextBox tb in panel.Controls.OfType<TextBox>())
                {
                    controles.Add(tb);
                }
            }

            int i = 0;

            foreach (var tb in controles)
            {
                if (tb.Text != "" && tb.Text != "Nome" && tb.Text != "CPF" && tb.Text != "RG" && tb.Text != "Email" && tb.Text != "Telefone" && tb.Text != "CEP" && tb.Text != "País" && tb.Text != "Rua" && tb.Text != "Bairro" && tb.Text != "Cidade" && tb.Text != "UF")
                {
                    i += 1;
                }
            }
            if (i == 11)
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
                btnCadastrar.Enabled = true;
                btnCadastrar.Cursor = Cursors.Default;
            }
            controles.Clear();

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //AddressBLL addressBLL = new AddressBLL();
            CustomerBLL customerBLL = new CustomerBLL();
            Customer customer = new Customer();
            //cepConsulta cepAddress = correiosCEP.GetAddress("88345677");

            Address address = new Address();
            address.Pais = "Brasil";
            address.Rua = "rua um";
            address.CEP = "88220000";
            address.Bairro = "bairro teste";
            address.Cidade = "CAMBORIU";
            address.UF = "PR";
            address.Numero = "126";
            customer.Nome = "TESTE";
            customer.CPF = "12600204954";
            customer.RG = "567467";
            customer.Telefone = "479999995";
            //customer.Email = "";
            customer.Endereco = address;
            customerBLL.InsertAddressCustomerTransaction(customer);

            //Response response = new AddressUserTransaction().InsertAddressUserTransaction(user);
            //MessageBox.Show(response.Message);
            //Response response = userBLL.Insert(user);
            //MessageBox.Show(response.Message);
        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"Fonts\", "GatsbyFLF.ttf");
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(path);
            FontFamily fontFamily = new FontFamily(pfc.Families.First().Name, pfc);
        }

        private void panelCadastroCliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
