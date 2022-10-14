using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projekt_PAD_1
{
    public partial class Rejestracja1 : UserControl
    {
        private string Login;
        private string Email;
        private string Haslo;
        private string Imie;
        private string Nazwisko;
        public Rejestracja1()
        {
            InitializeComponent();
        }
        public int IloscPoprawnychElementów;
        private void btnZarejestruj_Click(object sender, EventArgs e)
        {
            Imie = Rimie.Text;
            Nazwisko = Rnazwisko.Text;
            if (Remail.Text.Contains('@') == true && Remail.Text.Contains('.') == true)
            {
                IloscPoprawnychElementów = IloscPoprawnychElementów + 1;
                Email = Remail.Text;
            }
            else
            {
                MessageBox.Show("Wpisano Błędny Mail");
            }

            if (Rhaslo.Text != "" && Rhaslo.Text.Length >= 8)
            {
                if (Rpowhaslo.Text == Rhaslo.Text)
                {
                    IloscPoprawnychElementów++;
                    Haslo = Rhaslo.Text;
                }
                else if (Rpowhaslo.Text != Rhaslo.Text)
                {
                    MessageBox.Show("Błędne hasła");
                    Rhaslo.Text = "";
                }
            }
            else if (Rhaslo.Text.Length < 8)
            {
                MessageBox.Show("Hasło ma za mało znaków; Potrzebna ilość znaków : 8");
                Rhaslo.Text = "";
            }
            if (IloscPoprawnychElementów > 3)
            {
                MessageBox.Show("Zarejestrowałeś się!");
               
            }
            else
            {
                MessageBox.Show("Błąd");
            }
        }

        private void Rpokazhaslo_CheckedChanged(object sender, EventArgs e)
        {
            if (Rpokazhaslo.Checked == true)
            {
                Rhaslo.UseSystemPasswordChar = true;
                Rpowhaslo.UseSystemPasswordChar = true;
            }
            else if (Rpokazhaslo.Checked == false)
            {
                Rhaslo.UseSystemPasswordChar = false;
                Rpowhaslo.UseSystemPasswordChar = false;
            }
        }
    }
}
