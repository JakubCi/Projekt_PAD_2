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
    public partial class nauczycielMain : Form
    {
        public nauczycielMain()
        {
            InitializeComponent();
        }

        private void btnKlasy_Click(object sender, EventArgs e)
        {
            Apanel1.Visible = false;
            Apanel2.Visible = false;
            Apanel3.Visible = true;
            nauczycielKlasy nauczycielKlasy = new nauczycielKlasy();
            panel4.Controls.Add(nauczycielKlasy);
            nauczycielKlasy.Visible = true;
            nauczycielKlasy.Dock = DockStyle.Fill;
            nauczycielKlasy.BringToFront();
        }

        private void btnTerminarz_Click(object sender, EventArgs e)
        {
            Apanel1.Visible = true;
            Apanel2.Visible = false;
            Apanel3.Visible = false;
            nauczycielTerminarzWaga nauczycielTerminarz = new nauczycielTerminarzWaga();
            panel4.Controls.Add(nauczycielTerminarz);
            nauczycielTerminarz.Visible = true;
            nauczycielTerminarz.Dock = DockStyle.Fill;
            nauczycielTerminarz.BringToFront();
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogowanieiRejstracja logowanieiRejstracja = new LogowanieiRejstracja();
            logowanieiRejstracja.Show();
        }
    }
}
