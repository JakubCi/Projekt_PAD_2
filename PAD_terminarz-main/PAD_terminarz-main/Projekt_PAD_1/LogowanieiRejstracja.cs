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
    public partial class LogowanieiRejstracja : Form
    {
        public LogowanieiRejstracja()
        {
            InitializeComponent();
        }

        private void btnLogowanie_Click(object sender, EventArgs e)
        {
            Lpanel1.Visible = true;
            Lpanel2.Visible = false;
            Logowanie1 logowanie1 = new Logowanie1();
            panel1.Controls.Add(logowanie1);
            logowanie1.Visible = true;
            logowanie1.Dock = DockStyle.Fill;
            logowanie1.BringToFront();
        }

        private void btnRejestracja_Click(object sender, EventArgs e)
        {
            Lpanel1.Visible = false;
            Lpanel2.Visible = true;
            Rejestracja1 rejestracja1 = new Rejestracja1();
            panel1.Controls.Add(rejestracja1);
            rejestracja1.Visible = true;
            rejestracja1.Dock = DockStyle.Fill;
            rejestracja1.BringToFront();
        }
    }
}
