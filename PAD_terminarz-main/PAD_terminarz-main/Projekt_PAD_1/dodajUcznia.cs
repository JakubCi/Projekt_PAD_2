using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_PAD_1
{
    public partial class dodajUcznia : Form
    {
        public dodajUcznia()
        {
            InitializeComponent();
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            adminMain adminMain = new adminMain();
            this.Hide();
            adminMain.Show();

        }

        private void btnUtworz_Click(object sender, EventArgs e)
        {

        }
    }
}
