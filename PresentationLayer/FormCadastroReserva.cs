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
        User user = new User();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            if (customerBLL.GetCustomerByCPF(textBox1.Text).Success)
            {
                customer = customerBLL.GetCustomerByCPF(textBox1.Text).Data;
                labelNome.Text = customer.Nome;
            }
            else
            {
                labelNome.Text = "Não encontrado";
            }
                
        }
    }
}
