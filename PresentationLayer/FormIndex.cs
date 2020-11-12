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
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
            hideSubMenu();
        }

        #region Sub Menus

        private void hideSubMenu()
        {
            panelQuartos.Visible = false;
            panelClientes.Visible = false;
            panelReservas.Visible = false;
            panelProdutos.Visible = false;
            panelFuncionarios.Visible = false;
            panelUsuarios.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            panelMenu.Size = new Size(250, this.Size.Height);
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion

        #region Forms

        private Form activeForm = null;
        private void openFormMenu(Form formMenu)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = formMenu;
            formMenu.TopLevel = false;
            formMenu.FormBorderStyle = FormBorderStyle.None;
            formMenu.Dock = DockStyle.Fill;
            panelFormMenu.Controls.Add(formMenu);
            panelFormMenu.Tag = formMenu;
            formMenu.BringToFront();
            formMenu.Show();
        }

        #endregion

        #region maximizar e minimizar menu

        private void MaximazeMenu()
        {
            panelMenu.Visible = true;
            panelMenuMinimizado.Visible = false;
        }

        private void MinimizeMenu()
        {
            panelMenu.Visible = false;
            panelMenuMinimizado.Visible = true;
        }

        #endregion

        #region Quartos Menu

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQuartos);
        }

        private void btnCadastrarQuarto_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            openFormMenu(new FormCadastroQuarto());
            hideSubMenu();
        }

        private void btnVerTodosQuartos_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            //openFormMenu(new Form());
            hideSubMenu();
        }

        #endregion

        #region Clientes Menu

        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientes);
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            openFormMenu(new FormCadastroCliente());
            hideSubMenu();
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            openFormMenu(new FormClientes());
            hideSubMenu();
        }

        #endregion

        #region Reservas Menu

        private void btnReservas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReservas);
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            openFormMenu(new FormCadastroReserva());
            hideSubMenu();
        }

        private void btnVerTodasReservas_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            openFormMenu(new FormReservas());
            hideSubMenu();
        }

        #endregion

        #region Check In Menu

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            //openFormMenu(new Form());
            hideSubMenu();
        }

        #endregion

        #region Check Out Menu

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            //openFormMenu(new Form());
            hideSubMenu();
        }
        #endregion

        #region Produtos Menu

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProdutos);
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            //openFormMenu(new Form());
            hideSubMenu();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            //openFormMenu(new Form());
            hideSubMenu();
        }

        private void btnEntradaProduto_Click(object sender, EventArgs e)
        {
            //openFormMenu(new Form());
            hideSubMenu();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            //openFormMenu(new Form());
            hideSubMenu();
        }

        #endregion

        #region Fornecedores Menu
        private void btnFornecedores_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelFornecedores);
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            openFormMenu(new FormCadastroFornecedor());
            hideSubMenu();
        }

        private void btnVerTodosFornecedores_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            //openFormMenu(new FormFornecedores());
            hideSubMenu();
        }

        #endregion

        #region Funcionarios Menu

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFuncionarios);
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            openFormMenu(new FormCadastroUsuario());
            hideSubMenu();
        }

        private void btnVerTodosFuncionarios_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            openFormMenu(new FormUsuarios());
            hideSubMenu();
        }

        #endregion

        #region Chamado de Serviço Menu

        private void btnChamadoServico_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            //openFormMenu(new Form());
            hideSubMenu();
        }

        #endregion

        #region Usuário Menu

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUsuarios);
        }

        private void btnDadosContaUsuario_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            //openFormMenu(new Form());
            hideSubMenu();
        }

        private void btnTrocarUsuário_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
            //openFormMenu(new Form());
            hideSubMenu();
        }

        #endregion

        #region Sair Menu

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Logo Menu
        private void panelLogo_MouseLeave(object sender, EventArgs e)
        {
            pbLogoMenu.Size = new Size(159, 60);
            pbLogoMenu.Location = new Point(36, 15);
        }

        private void panelLogo_MouseEnter(object sender, EventArgs e)
        {
            pbLogoMenu.Size = new Size(180, 80);
            pbLogoMenu.Location = new Point(30, 10);
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            MinimizeMenu();
        }

        private void panelLogoMinimizado_MouseEnter(object sender, EventArgs e)
        {
            pbLogoMinimizada.Size = new Size(50, 50);
            pbLogoMinimizada.Location = new Point(20, 20);
        }

        private void panelLogoMinimizado_MouseLeave(object sender, EventArgs e)
        {
            pbLogoMinimizada.Size = new Size(60, 60);
            pbLogoMinimizada.Location = new Point(15, 15);
        }

        private void panelLogoMinimizado_Click(object sender, EventArgs e)
        {
            MaximazeMenu();
        }

        #endregion

        #region Botões minimizados
        private void btnQuartoMinimizado_Click(object sender, EventArgs e)
        {
            MaximazeMenu();
            showSubMenu(panelQuartos);
        }

        private void btnClientesMinimizado_Click(object sender, EventArgs e)
        {
            MaximazeMenu();
            showSubMenu(panelClientes);
        }

        private void btnResrvasMinimizado_Click(object sender, EventArgs e)
        {
            MaximazeMenu();
            showSubMenu(panelReservas);
        }

        private void btnCheckInMinimizado_Click(object sender, EventArgs e)
        {
            MaximazeMenu();
            //openFormMenu(new Form());
            hideSubMenu();

        }

        private void btnCheckOutMinimizado_Click(object sender, EventArgs e)
        {
            MaximazeMenu();
            //openFormMenu(new Form());
            hideSubMenu();
        }

        private void btnProdutosMinimizado_Click(object sender, EventArgs e)
        {
            MaximazeMenu();
            showSubMenu(panelProdutos);
        }

        private void btnFuncionariosMinimizado_Click(object sender, EventArgs e)
        {
            MaximazeMenu();
            showSubMenu(panelFuncionarios);
        }

        private void btnLimpezaMinimizado_Click(object sender, EventArgs e)
        {
            MaximazeMenu();
        }

        private void btnUsuarioMinimizado_Click(object sender, EventArgs e)
        {
            MaximazeMenu();
            showSubMenu(panelUsuarios);
        }

        private void btnFornecedoresMinimizado_Click(object sender, EventArgs e)
        {
            MaximazeMenu();
            showSubMenu(panelFornecedores);
        }

        private void btnSairMinimizado_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        #endregion

    }
}
