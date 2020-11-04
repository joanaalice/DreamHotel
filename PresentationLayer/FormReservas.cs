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
    public partial class FormReservas : Form
    {
        public FormReservas()
        {
            InitializeComponent();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            var startDate = monthCalendar.SelectionRange.Start.ToString("dd MMM yyyy");
            var endDate = monthCalendar.SelectionRange.End.ToString("dd MMM yyyy");
            var data = monthCalendar.GetDisplayRange(true);
            MessageBox.Show(data.Start.DayOfWeek.ToString());
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startDate = "16 out 2020";
            //monthCalendar. = startDate;
        }
    }
}

