using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ukol4
{
    public partial class Form1 : Form
    {
        Produkt produkt;

        public Form1()
        {
            InitializeComponent();
        }

        private void vytvorit_Click(object sender, EventArgs e)
        {
            try
            {
                bool sleva;

                if ((DateTime.Now.DayOfYear - dateTimePicker_vyroba.Value.DayOfYear) > Convert.ToInt32(textBox_trvanlivost.Text))
                {
                    sleva = true;
                }
                else
                {
                    sleva = false;
                }

                produkt = new Produkt(textBox_nazev.Text, Convert.ToInt32(textBox_cena.Text), dateTimePicker_vyroba.Value, Convert.ToInt32(textBox_trvanlivost.Text), sleva);
                MessageBox.Show("Produkt byl úspěšně vytvořen!");

                info.Visible = true;
            }
            catch
            {
                MessageBox.Show("Zadej správné hodnoty!", "Error");
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(produkt.ToString());
        }
    }
}