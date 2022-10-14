namespace Projekt_PAD_1
{
    partial class nauczycielKlasy
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUczniowie = new System.Windows.Forms.Button();
            this.Apanel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(29, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 343);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnUczniowie
            // 
            this.btnUczniowie.BackColor = System.Drawing.Color.Transparent;
            this.btnUczniowie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUczniowie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUczniowie.FlatAppearance.BorderSize = 0;
            this.btnUczniowie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUczniowie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUczniowie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUczniowie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUczniowie.Location = new System.Drawing.Point(493, 31);
            this.btnUczniowie.Margin = new System.Windows.Forms.Padding(4);
            this.btnUczniowie.Name = "btnUczniowie";
            this.btnUczniowie.Size = new System.Drawing.Size(154, 47);
            this.btnUczniowie.TabIndex = 31;
            this.btnUczniowie.Text = "Zmień";
            this.btnUczniowie.UseVisualStyleBackColor = false;
            // 
            // Apanel3
            // 
            this.Apanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.Apanel3.Location = new System.Drawing.Point(493, 71);
            this.Apanel3.Margin = new System.Windows.Forms.Padding(4);
            this.Apanel3.Name = "Apanel3";
            this.Apanel3.Size = new System.Drawing.Size(154, 7);
            this.Apanel3.TabIndex = 34;
            this.Apanel3.Visible = false;
            // 
            // nauczycielKlasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Apanel3);
            this.Controls.Add(this.btnUczniowie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "nauczycielKlasy";
            this.Size = new System.Drawing.Size(662, 447);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUczniowie;
        private System.Windows.Forms.Panel Apanel3;
    }
}
