namespace OOP_Ukol4
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vytvorit = new System.Windows.Forms.Button();
            this.textBox_nazev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cena = new System.Windows.Forms.TextBox();
            this.dateTimePicker_vyroba = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_trvanlivost = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vytvorit
            // 
            this.vytvorit.Location = new System.Drawing.Point(322, 32);
            this.vytvorit.Name = "vytvorit";
            this.vytvorit.Size = new System.Drawing.Size(75, 23);
            this.vytvorit.TabIndex = 0;
            this.vytvorit.Text = "Vytvořit";
            this.vytvorit.UseVisualStyleBackColor = true;
            this.vytvorit.Click += new System.EventHandler(this.vytvorit_Click);
            // 
            // textBox_nazev
            // 
            this.textBox_nazev.Location = new System.Drawing.Point(99, 12);
            this.textBox_nazev.Name = "textBox_nazev";
            this.textBox_nazev.Size = new System.Drawing.Size(100, 20);
            this.textBox_nazev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Název:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cena:";
            // 
            // textBox_cena
            // 
            this.textBox_cena.Location = new System.Drawing.Point(99, 38);
            this.textBox_cena.Name = "textBox_cena";
            this.textBox_cena.Size = new System.Drawing.Size(100, 20);
            this.textBox_cena.TabIndex = 3;
            // 
            // dateTimePicker_vyroba
            // 
            this.dateTimePicker_vyroba.Location = new System.Drawing.Point(99, 64);
            this.dateTimePicker_vyroba.Name = "dateTimePicker_vyroba";
            this.dateTimePicker_vyroba.Size = new System.Drawing.Size(166, 20);
            this.dateTimePicker_vyroba.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum výroby:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Min. trvanlivost:";
            // 
            // textBox_trvanlivost
            // 
            this.textBox_trvanlivost.Location = new System.Drawing.Point(99, 90);
            this.textBox_trvanlivost.Name = "textBox_trvanlivost";
            this.textBox_trvanlivost.Size = new System.Drawing.Size(100, 20);
            this.textBox_trvanlivost.TabIndex = 8;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(322, 61);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(75, 23);
            this.info.TabIndex = 10;
            this.info.Text = "Zobrazit info";
            this.info.UseVisualStyleBackColor = true;
            this.info.Visible = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 121);
            this.Controls.Add(this.info);
            this.Controls.Add(this.textBox_trvanlivost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_vyroba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_cena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nazev);
            this.Controls.Add(this.vytvorit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OOP Úkol 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vytvorit;
        private System.Windows.Forms.TextBox textBox_nazev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cena;
        private System.Windows.Forms.DateTimePicker dateTimePicker_vyroba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_trvanlivost;
        private System.Windows.Forms.Button info;
    }
}

