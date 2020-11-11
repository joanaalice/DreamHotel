using BusinessLogicalLayer;
using Common;
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

namespace PresentationLayer
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }
        CustomerBLL customerBLL = new CustomerBLL();
        List<string> enderecoNomesColunas = new List<string>();
        private void UpdateGridView()
        {
            QueryResponse<Customer> response = customerBLL.GetAll();
            if (response.Success)
            {
                dgvClientes.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
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
                SingleResponse<Customer> response = customerBLL.GetCustomerByCPF(txtCpf.Text);
                if (response.Success)
                {
                    dgvClientes.DataSource = response.Data;
                }
                else
                {
                    MessageBox.Show(response.Message);
                }
            }
            Filtrar("Ativo", btnAtivo);
            FiltrarEndereco();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        #region Text Boxs

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

        #endregion

        #region botões filtro

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
            foreach (DataGridViewColumn dgvcolumn in dgvClientes.Columns)
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
        private void FiltrarEndereco()
        {
            if (btnEnderecoID.BackColor == Color.Black)
            {
                btnEnderecoID.BackColor = Color.Gray;
                btnEnderecoID.ForeColor = Color.Black;

                foreach (DataGridViewColumn dgvcolumn in dgvClientes.Columns)
                {
                    foreach (string nomeColuna in enderecoNomesColunas)
                    {
                        if (dgvcolumn.Name == nomeColuna)
                        {
                            dgvcolumn.Visible = false;
                        }
                    }
                }
            }
            else
            {
                btnEnderecoID.BackColor = Color.Black;
                btnEnderecoID.ForeColor = Color.FromArgb(230, 180, 83);

                foreach (DataGridViewColumn dgvcolumn in dgvClientes.Columns)
                {
                    foreach (string nomeColuna in enderecoNomesColunas)
                    {
                        if (dgvcolumn.Name == nomeColuna)
                        {
                            dgvcolumn.Visible = true;
                        }
                    }
                }
            }

        }

        private void btnID_Click(object sender, EventArgs e)
        {
            Filtrar("ID", btnID);
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

        private void btnTelefone_Click(object sender, EventArgs e)
        {
            Filtrar("Telefone", btnTelefone);
        }

        private void btnTelefone2_Click(object sender, EventArgs e)
        {
            Filtrar("Telefone_aux", btnTelefone2);
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            Filtrar("Email", btnTelefone);
        }

        private void btnEnderecoID_Click(object sender, EventArgs e)
        {
            FiltrarEndereco();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            Filtrar("Data_Cadastro", btnData);
        }

        private void btnAtivo_Click(object sender, EventArgs e)
        {
            Filtrar("Ativo", btnAtivo);
        }

        #endregion

        private void FormClientes_Load(object sender, EventArgs e)
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

        }

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dgvClientes.CurrentCell.Value.ToString() == "Entities.")
            {
                //if (dgvClientes.CurrentCell.)
                //{

                //}
            }
        }
    }
}
