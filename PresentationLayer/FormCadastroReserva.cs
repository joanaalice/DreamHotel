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
    public partial class FormCadastroReserva : Form
    {
        public FormCadastroReserva()
        {
            InitializeComponent();
        }

        Customer customer = new Customer();
        Reservation reservation = new Reservation();
        ReservationBLL reservationBLL = new ReservationBLL();
        User user = new User();
        UserBLL userBLL = new UserBLL();
        CustomerBLL customerBLL = new CustomerBLL();
        RoomBLL roomBLL = new RoomBLL();


        private void FormCadastroReserva_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Environment.CurrentDirectory, @"Fonts\", "GatsbyFLF-Bold.ttf"));

            txtCpf.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            labelQuarto.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            labelReservar.Font = new Font(pfc.Families[0], 36, FontStyle.Bold);
            labelDados.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);
            labelNome.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            labelQuartos.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            labelData.Font = new Font(pfc.Families[0], 18, FontStyle.Bold);
            btnReservar.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);
            btnTipoDeQuarto.Font = new Font(pfc.Families[0], 15, FontStyle.Bold);
            btnTodos.Font = new Font(pfc.Families[0], 15, FontStyle.Bold);
            btnSolteiro.Font = new Font(pfc.Families[0], 15, FontStyle.Bold);
            btnDuplo.Font = new Font(pfc.Families[0], 15, FontStyle.Bold);
            btnCasal.Font = new Font(pfc.Families[0], 15, FontStyle.Bold);
            btnDormitorio.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);

            this.dgvQuartos.DataError += DgvQuartos_DataError;
        }

        private void DgvQuartos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtCpf.Text == "CPF do Cliente")
            {
                txtCpf.Text = "";
                txtCpf.ForeColor = Color.FromArgb(230, 180, 83);
                linhaCpf.BackColor = Color.Silver;
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (txtCpf.Text != "CPF do Cliente" && txtCpf.Text != "")
            {
                if (customerBLL.GetCustomerByCPF(txtCpf.Text).Success)
                {
                    customer = customerBLL.GetCustomerByCPF(txtCpf.Text).Data;
                    labelNome.Text = customer.Nome;
                    linhaNome.BackColor = Color.Silver;
                }
                else
                {
                    labelNome.Text = "Não encontrado";
                }

            }

            if (txtCpf.Text == "")
            {
                txtCpf.Text = "CPF do Cliente";
                txtCpf.ForeColor = Color.Silver;
                linhaCpf.BackColor = Color.FromArgb(230, 180, 83);
            }

        }

        private void btnTipoDeQuarto_Click(object sender, EventArgs e)
        {
            if (panelTipoDeQuarto.Visible == true)
            {
                panelTipoDeQuarto.Visible = false;
            }
            else if (panelTipoDeQuarto.Visible == false)
            {
                panelTipoDeQuarto.Visible = true;
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            panelTipoDeQuarto.Visible = false;
        }

        private void dtpSaida_Leave(object sender, EventArgs e)
        {

        }

        private void panelReservar_MouseEnter(object sender, EventArgs e)
        {
            if (txtCpf.Text != "CPF do Cliente" && labelQuarto.Text != "Quarto" && labelData.Text != "Data")
            {
                btnReservar.Enabled = true;
            }
        }

        private void dgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            linhaQuarto.BackColor = Color.Silver;
        }

        private void btnSolteiro_Click(object sender, EventArgs e)
        {
            panelTipoDeQuarto.Visible = false;
        }

        private void btnDuplo_Click(object sender, EventArgs e)
        {
            panelTipoDeQuarto.Visible = false;
        }

        private void btnCasal_Click(object sender, EventArgs e)
        {
            panelTipoDeQuarto.Visible = false;
        }

        private void btnDormitorio_Click(object sender, EventArgs e)
        {
            panelTipoDeQuarto.Visible = false;
        }

        private void dtpSaida_ValueChanged(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = roomBLL.GetRAvailableRoomsByDate(dtpEntrada.Value, dtpSaida.Value).Data;
            labelData.Text = dtpEntrada.Value.ToString("dd/mm/yyyy") + " a " + dtpSaida.Value.ToString("dd/mm/yyyy") + " (" + (dtpEntrada.Value - dtpSaida.Value).ToString("dd") + " dias)";
            labelData.ForeColor = Color.FromArgb(230, 180, 83);
            linhaData.BackColor = Color.Silver;
        }

        private void dgvReservas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewColumn coluna in dgvQuartos.Columns)
            {
                if (coluna.Name == "Numero")
                {
                    labelQuarto.Text = (string)dgvQuartos.Rows[e.RowIndex].Cells[coluna.DisplayIndex].Value;
                    labelQuarto.ForeColor = Color.FromArgb(230, 180, 83);
                }
            }
            
        }
        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Response response = new Response();

            reservation.Quarto = roomBLL.GetRoomByNumber(labelQuarto.Text).Data;
            reservation.Customer = customerBLL.GetCustomerByCPF(txtCpf.Text).Data;
            reservation.Funcionario = userBLL.GetUserById(IsUserLog.CurrentUser.ID).Data;
            reservation.Data_Entrada = dtpEntrada.Value;
            reservation.Data_Saida = dtpSaida.Value;

            response = reservationBLL.Insert(reservation);

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
    }
}
