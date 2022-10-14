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
    public partial class Logowanie1 : UserControl
    {
        public Logowanie1()
        {
            InitializeComponent();
        }

        private void Lpokazhaslo_CheckedChanged(object sender, EventArgs e)
        {
            if (Lpokazhaslo.Checked == true)
            {
                Lhaslo.UseSystemPasswordChar = true;
            }
            else if (Lpokazhaslo.Checked == false)
            {
                Lhaslo.UseSystemPasswordChar = false;
            }
        }
    }
}
