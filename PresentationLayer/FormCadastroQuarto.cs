using BusinessLogicalLayer;
using Common;
using Common.Enums;
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
    public partial class FormCadastroQuarto : Form
    {
        public FormCadastroQuarto()
        {
            InitializeComponent();
        }

        Room room = new Room();
        RoomBLL roomBLL = new RoomBLL();
        Response response = new Response();

        private void UpdateGridView(string bloco)
        {
            QueryResponse<Room> response = roomBLL.GetRoomsByBloc(bloco);
            if (response.Success)
            {
                dgvBlocos.DataSource = response.Data;
                foreach (DataGridViewColumn dgvcolumn in dgvBlocos.Columns)
                {
                    if (dgvcolumn.Name == "Bloco" || dgvcolumn.Name == "Numero")
                    {
                        dgvcolumn.Visible = true;
                        dgvcolumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    }
                    else
                    {
                        dgvcolumn.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void panelNome_Click(object sender, EventArgs e)
        {
            if (panelNomeDrop.Visible == true)
            {
                panelNomeDrop.Visible = false;
            }
            else
            {
                panelNomeDrop.Visible = true;
            }
        }

        private void panelTipo_Click(object sender, EventArgs e)
        {
            if (panelTipoDrop.Visible == true)
            {
                panelTipoDrop.Visible = false;
            }
            else
            {
                panelTipoDrop.Visible = true;
            }
        }

        private void labelNome_TextChanged(object sender, EventArgs e)
        {
            linhaNome.BackColor = Color.FromArgb(230, 180, 83);
        }

        private void labelTipo_TextChanged(object sender, EventArgs e)
        {
            linhaTipo.BackColor = Color.FromArgb(230, 180, 83);
        }

        private void txtBloco_Enter(object sender, EventArgs e)
        {
            if (txtBloco.Text == "Bloco")
            {
                txtBloco.Text = "";
                txtBloco.ForeColor = Color.FromArgb(230, 180, 83);
                linhaBloco.BackColor = Color.Silver;
            }
        }
        private void txtBloco_Leave(object sender, EventArgs e)
        {
            if (txtBloco.Text == "")
            {
                txtBloco.Text = "Bloco";
                txtBloco.ForeColor = Color.Silver;
                linhaBloco.BackColor = Color.FromArgb(230, 180, 83);
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
            else if (txtNumero.Text == "A partir do número")
            {
                txtNumero.Text = "";
                txtNumero.ForeColor = Color.FromArgb(230, 180, 83);
                linhaNumero.BackColor = Color.Silver;
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (txtNumero.Text == "" && nudQuartos.Value == 1)
            {
                txtNumero.Text = "Número";
                txtNumero.ForeColor = Color.Silver;
                linhaNumero.BackColor = Color.FromArgb(230, 180, 83);
            }
            else if (txtNumero.Text == "" && nudQuartos.Value > 1)
            {
                txtNumero.Text = "A partir do número";
                txtNumero.ForeColor = Color.Silver;
                linhaNumero.BackColor = Color.FromArgb(230, 180, 83);
            }
        }

        private void FormCadastroQuarto_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Environment.CurrentDirectory, @"Fonts\", "GatsbyFLF-Bold.ttf"));

            labelDados.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);
            labelBlocos.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);
            labelNome.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            labelTipo.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            labelBlocos.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            labelQuartoQuantidade.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            nudQuartos.Font = new Font(pfc.Families[0], 18, FontStyle.Bold);
            labelCadastrarQuarto.Font = new Font(pfc.Families[0], 36, FontStyle.Bold);
            txtBloco.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtNumero.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnSolteiro.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            btnDuplo.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            btnCasal.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            btnDormitorio.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            btnStandard.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            btnPremium.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            btnExecutive.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            btnMaster.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            btnDeluxe.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            btnPresidencial.Font = new Font(pfc.Families[0], 16, FontStyle.Bold);
            btnCadastrar.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (nudQuartos.Value == 1)
            {
                room.Bloco = txtBloco.Text;
                room.Numero = txtNumero.Text;
                room.Nome = (NomeEnum)System.Enum.Parse(typeof(NomeEnum), labelNome.Text);
                room.Tipo = (TipoEnum)System.Enum.Parse(typeof(TipoEnum), labelTipo.Text);
                //falta calcular valor
                room.Valor_Diaria = 20;

                response = roomBLL.Insert(room);

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
            else if (nudQuartos.Value > 1)
            {
                int i = 0;
                for (i = 1; i < nudQuartos.Value; i++)
                {
                    room.Bloco = txtBloco.Text;
                    int numero = Convert.ToInt32(txtNumero.Text);
                    txtNumero.Text = Convert.ToString(numero + 1);
                    room.Numero = txtNumero.Text;
                    room.Nome = (NomeEnum)System.Enum.Parse(typeof(NomeEnum), labelNome.Text);
                    room.Tipo = (TipoEnum)System.Enum.Parse(typeof(TipoEnum), labelTipo.Text);
                    //falta calcular valor
                    room.Valor_Diaria = 20;

                    response = roomBLL.Insert(room);

                    
                }
                if (response.Success && i == nudQuartos.Value)
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
            else
            {
                Form form = new FormNaoCadastrado("O número de quartos para cadastro deve ser um ou superior");
                form.Show();
            }
        }

        private void panelaCadastrar_MouseEnter(object sender, EventArgs e)
        {

            if (labelNome.Text != "Nome" && txtBloco.Text != "Bloco" && txtNumero.Text != "Número" && labelTipo.Text != "Tipo" && nudQuartos.Value > 0)
            {
                btnCadastrar.Enabled = true;
            }
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            labelNome.Text = "Standard";
            panelNomeDrop.Visible = false;
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            labelNome.Text = "Premium";
            panelNomeDrop.Visible = false;
        }

        private void btnExecutive_Click(object sender, EventArgs e)
        {
            labelNome.Text = "Executive";
            panelNomeDrop.Visible = false;
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            labelNome.Text = "Master";
            panelNomeDrop.Visible = false;
        }

        private void btnDeluxe_Click(object sender, EventArgs e)
        {
            labelNome.Text = "Executive";
            panelNomeDrop.Visible = false;
        }

        private void btnPresidencial_Click(object sender, EventArgs e)
        {
            labelNome.Text = "Presidencial";
            panelNomeDrop.Visible = false;
        }

        private void btnSolteiro_Click(object sender, EventArgs e)
        {
            labelTipo.Text = "Solteiro";
            panelTipoDrop.Visible = false;
        }

        private void btnCasal_Click(object sender, EventArgs e)
        {
            labelTipo.Text = "Casal";
            panelTipoDrop.Visible = false;
        }

        private void btnDuplo_Click(object sender, EventArgs e)
        {
            labelTipo.Text = "Duplo";
            panelTipoDrop.Visible = false;
        }

        private void btnDormitorio_Click(object sender, EventArgs e)
        {
            labelTipo.Text = "Dormitório";
            panelTipoDrop.Visible = false;
        }

        private void nudQuartos_ValueChanged(object sender, EventArgs e)
        {
            if (nudQuartos.Value == 1)
            {
                txtNumero.Text = "Número";
            }
            else if (nudQuartos.Value > 1)
            {
                txtNumero.Text = "A partir do número";
            }
            
        }

        private void txtBloco_TextChanged(object sender, EventArgs e)
        {
            UpdateGridView(txtBloco.Text);
        }
    }
}
