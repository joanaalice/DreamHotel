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
                    dgvClientes.DataSource = new List<Customer>() { response.Data };
                }
                else
                {
                    MessageBox.Show(response.Message);
                }
            }
            foreach (DataGridViewColumn column in dgvClientes.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvClientes.SelectedRows.Count > 0)
            {
                string idt = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
            }
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
<<<<<<< HEAD
=======
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
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96

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

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Environment.CurrentDirectory, @"Fonts\", "GatsbyFLF-Bold.ttf"));

            labelClientes.Font = new Font(pfc.Families[0], 36, FontStyle.Bold);
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

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            string id = dgvClientes[e.ColumnIndex, e.RowIndex].Value.ToString();
            MessageBox.Show(id);
        }

        private void dgvClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
