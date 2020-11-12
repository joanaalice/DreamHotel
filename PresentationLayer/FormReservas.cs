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
    public partial class FormReservas : Form
    {
        public FormReservas()
        {
            InitializeComponent();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime PrimeiroDia = monthCalendar.SelectionRange.Start;
            DateTime SegundoDia = monthCalendar.SelectionRange.End;
            SelectionRange dias = monthCalendar.GetDisplayRange(true);
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Environment.CurrentDirectory, @"Fonts\", "GatsbyFLF-Bold.ttf"));

            labelReservas.Font = new Font(pfc.Families[0], 36, FontStyle.Bold);
            txtCpf.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnBuscar.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnDeletar.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            btnEditar.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            txtQuarto.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvReservas.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtCpf.Text == "Por CPF do cliente...")
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
                txtCpf.Text = "Por CPF do cliente...";
                txtCpf.ForeColor = Color.Silver;
                linhaCpf.BackColor = Color.FromArgb(230, 180, 83);
            }

        }

        private void txtQuarto_Enter(object sender, EventArgs e)
        {
            if (txtQuarto.Text == "Por número do quarto...")
            {
                txtQuarto.Text = "";
                txtQuarto.ForeColor = Color.FromArgb(230, 180, 83);
                linhaQuarto.BackColor = Color.Silver;
            }
        }

        private void txtQuarto_Leave(object sender, EventArgs e)
        {
            if (txtQuarto.Text == "")
            {
                txtQuarto.Text = "Por número do quarto...";
                txtQuarto.ForeColor = Color.Silver;
                linhaQuarto.BackColor = Color.FromArgb(230, 180, 83);
            }

        }
    }
}

