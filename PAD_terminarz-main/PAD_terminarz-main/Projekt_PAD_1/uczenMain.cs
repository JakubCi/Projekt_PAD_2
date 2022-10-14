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
    public partial class uczenMain : Form
    {
        public uczenMain()
        {
            InitializeComponent();
        }

        private void btnPlanlekcji_Click(object sender, EventArgs e)
        {
            Apanel1.Visible = false;
            Apanel2.Visible = true;
            uczenPlanlekcji uczenPlanlekcji = new uczenPlanlekcji();
            panel4.Controls.Add(uczenPlanlekcji);
            uczenPlanlekcji.Visible = true;
            uczenPlanlekcji.Dock = DockStyle.Fill;
            uczenPlanlekcji.BringToFront();
        }

        private void btnTerminarz_Click(object sender, EventArgs e)
        {
            Apanel1.Visible = true;
            Apanel2.Visible = false;
            uczenTerminarz uczenTerminarz = new uczenTerminarz();
            panel4.Controls.Add(uczenTerminarz);
            uczenTerminarz.Visible = true;
            uczenTerminarz.Dock = DockStyle.Fill;
            uczenTerminarz.BringToFront();
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogowanieiRejstracja logowanieiRejstracja = new LogowanieiRejstracja();
            logowanieiRejstracja.Show();
        }
    }
}
