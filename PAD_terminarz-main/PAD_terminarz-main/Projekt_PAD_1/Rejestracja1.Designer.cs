namespace Projekt_PAD_1
{
    partial class Rejestracja1
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rejestracja1));
            this.btnZarejestruj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rhaslo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rlogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rpowhaslo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Remail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Rimie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Rnazwisko = new System.Windows.Forms.TextBox();
            this.Rpokazhaslo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnZarejestruj
            // 
            this.btnZarejestruj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.btnZarejestruj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnZarejestruj.FlatAppearance.BorderSize = 0;
            this.btnZarejestruj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnZarejestruj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnZarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZarejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZarejestruj.Location = new System.Drawing.Point(58, 447);
            this.btnZarejestruj.Margin = new System.Windows.Forms.Padding(4);
            this.btnZarejestruj.Name = "btnZarejestruj";
            this.btnZarejestruj.Size = new System.Drawing.Size(325, 47);
            this.btnZarejestruj.TabIndex = 20;
            this.btnZarejestruj.Text = "Zarejestruj się";
            this.btnZarejestruj.UseVisualStyleBackColor = false;
            this.btnZarejestruj.Click += new System.EventHandler(this.btnZarejestruj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(14, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hasło:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Login:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(18, 253);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 36);
            this.panel3.TabIndex = 25;
            // 
            // Rhaslo
            // 
            this.Rhaslo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rhaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rhaslo.ForeColor = System.Drawing.Color.Gray;
            this.Rhaslo.Location = new System.Drawing.Point(57, 253);
            this.Rhaslo.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.Rhaslo.Multiline = true;
            this.Rhaslo.Name = "Rhaslo";
            this.Rhaslo.PasswordChar = '*';
            this.Rhaslo.Size = new System.Drawing.Size(377, 37);
            this.Rhaslo.TabIndex = 23;
            this.Rhaslo.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(18, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 36);
            this.panel2.TabIndex = 24;
            // 
            // Rlogin
            // 
            this.Rlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rlogin.ForeColor = System.Drawing.Color.Gray;
            this.Rlogin.Location = new System.Drawing.Point(58, 103);
            this.Rlogin.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.Rlogin.Multiline = true;
            this.Rlogin.Name = "Rlogin";
            this.Rlogin.Size = new System.Drawing.Size(376, 37);
            this.Rlogin.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(14, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Powtórz hasło:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(18, 329);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 36);
            this.panel1.TabIndex = 29;
            // 
            // Rpowhaslo
            // 
            this.Rpowhaslo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rpowhaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rpowhaslo.ForeColor = System.Drawing.Color.Gray;
            this.Rpowhaslo.Location = new System.Drawing.Point(58, 329);
            this.Rpowhaslo.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.Rpowhaslo.Multiline = true;
            this.Rpowhaslo.Name = "Rpowhaslo";
            this.Rpowhaslo.PasswordChar = '*';
            this.Rpowhaslo.Size = new System.Drawing.Size(376, 37);
            this.Rpowhaslo.TabIndex = 28;
            this.Rpowhaslo.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(18, 176);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(39, 36);
            this.panel4.TabIndex = 32;
            // 
            // Remail
            // 
            this.Remail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Remail.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Remail.ForeColor = System.Drawing.Color.Gray;
            this.Remail.Location = new System.Drawing.Point(58, 176);
            this.Remail.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.Remail.Multiline = true;
            this.Remail.Name = "Remail";
            this.Remail.Size = new System.Drawing.Size(376, 37);
            this.Remail.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Imię:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.ForeColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(18, 31);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(39, 36);
            this.panel5.TabIndex = 35;
            // 
            // Rimie
            // 
            this.Rimie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rimie.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rimie.ForeColor = System.Drawing.Color.Gray;
            this.Rimie.Location = new System.Drawing.Point(58, 31);
            this.Rimie.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.Rimie.Multiline = true;
            this.Rimie.Name = "Rimie";
            this.Rimie.Size = new System.Drawing.Size(167, 37);
            this.Rimie.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(222, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nazwisko:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.ForeColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(226, 30);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(39, 36);
            this.panel6.TabIndex = 38;
            // 
            // Rnazwisko
            // 
            this.Rnazwisko.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rnazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rnazwisko.ForeColor = System.Drawing.Color.Gray;
            this.Rnazwisko.Location = new System.Drawing.Point(265, 30);
            this.Rnazwisko.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.Rnazwisko.Multiline = true;
            this.Rnazwisko.Name = "Rnazwisko";
            this.Rnazwisko.Size = new System.Drawing.Size(169, 37);
            this.Rnazwisko.TabIndex = 37;
            // 
            // Rpokazhaslo
            // 
            this.Rpokazhaslo.AutoSize = true;
            this.Rpokazhaslo.Checked = true;
            this.Rpokazhaslo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Rpokazhaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rpokazhaslo.ForeColor = System.Drawing.Color.Gray;
            this.Rpokazhaslo.Location = new System.Drawing.Point(18, 387);
            this.Rpokazhaslo.Margin = new System.Windows.Forms.Padding(4);
            this.Rpokazhaslo.Name = "Rpokazhaslo";
            this.Rpokazhaslo.Size = new System.Drawing.Size(141, 29);
            this.Rpokazhaslo.TabIndex = 40;
            this.Rpokazhaslo.Text = "Pokaż hasło";
            this.Rpokazhaslo.UseVisualStyleBackColor = true;
            this.Rpokazhaslo.CheckedChanged += new System.EventHandler(this.Rpokazhaslo_CheckedChanged);
            // 
            // Rejestracja1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.Rpokazhaslo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Rnazwisko);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Rimie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Remail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Rpowhaslo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Rhaslo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Rlogin);
            this.Controls.Add(this.btnZarejestruj);
            this.Name = "Rejestracja1";
            this.Size = new System.Drawing.Size(450, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZarejestruj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox Rhaslo;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox Rlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox Rpowhaslo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox Remail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox Rimie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox Rnazwisko;
        private System.Windows.Forms.CheckBox Rpokazhaslo;
    }
}
