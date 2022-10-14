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
    public partial class adminMain : Form
    {
        public adminMain()
        {
            InitializeComponent();
        }

        private void btnKlasy_Click(object sender, EventArgs e)
        {
            Apanel1.Visible = true;
            Apanel2.Visible = false;
            Apanel3.Visible = false;
            adminKlasy adminklasy = new adminKlasy();
            panel4.Controls.Add(adminklasy);
            adminklasy.Visible = true;
            adminklasy.Dock = DockStyle.Fill;
            adminklasy.BringToFront();
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogowanieiRejstracja logowanieiRejstracja = new LogowanieiRejstracja();
            logowanieiRejstracja.Show();
        }

        private void btnNauczyciele_Click(object sender, EventArgs e)
        {
            Apanel1.Visible = false;
            Apanel2.Visible = true;
            Apanel3.Visible = false;
            adminNauczyciele adminNauczyciele = new adminNauczyciele();
            panel4.Controls.Add(adminNauczyciele);
            adminNauczyciele.Visible = true;
            adminNauczyciele.Dock = DockStyle.Fill;
            adminNauczyciele.BringToFront();
        }

        private void btnUczniowie_Click(object sender, EventArgs e)
        {
            Apanel1.Visible = false;
            Apanel2.Visible = false;
            Apanel3.Visible = true;
            adminUczniowie adminUczniowie = new adminUczniowie();
            panel4.Controls.Add(adminUczniowie);
            adminUczniowie.Visible = true;
            adminUczniowie.Dock = DockStyle.Fill;
            adminUczniowie.BringToFront();
        }

        private void adminMain_Load(object sender, EventArgs e)
        {

        }
    }
}
