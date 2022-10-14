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
    public partial class adminUczniowie : UserControl
    {
        public adminUczniowie()
        {
            InitializeComponent();
        }

        private void btnDodaucznia_Click(object sender, EventArgs e)
        {
            dodajUcznia dodajUcznia = new dodajUcznia();
            this.Hide();
            dodajUcznia.Show();
        }
    }
}
