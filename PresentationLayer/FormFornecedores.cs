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
    public partial class FormFornecedores : Form
    {
        public FormFornecedores()
        {
            InitializeComponent();
        }

        ProviderBLL providerBLL = new ProviderBLL();

        private void UpdateGridView()
        {
            //QueryResponse<Provider> response = providerBLL.GetAll();
            //if (response.Success)
            //{
            //    dgvFornecedores.DataSource = response.Data;
            //}
            //else
            //{
            //    MessageBox.Show(response.Message);
            //}
        }

        private void txtCnpj_Enter(object sender, EventArgs e)
        {

        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text == "Por CNPJ...")
            {
                UpdateGridView();
            }
            else
            {
                //SingleResponse<Provider> response = providerBLL.GetProviderByCPF(txtCnpj.Text);
                //if (response.Success)
                //{
                //    dgvFornecedores.DataSource = new List<Provider>() { response.Data };
                //}
                //else
                //{
                //    MessageBox.Show(response.Message);
                //}
            }
            foreach (DataGridViewColumn column in dgvFornecedores.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnNome_Click(object sender, EventArgs e)
        {

        }

        private void btnCnpj_Click(object sender, EventArgs e)
        {

        }

        private void btnRazaoSocial_Click(object sender, EventArgs e)
        {

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnTelefone_Click(object sender, EventArgs e)
        {

        }

        private void btnTelefone2_Click(object sender, EventArgs e)
        {

        }
    }
}
