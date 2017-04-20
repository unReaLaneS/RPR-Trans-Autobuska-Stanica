using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca3RPR
{
    public partial class Uredi : Form
    {
        private PutnikKontrola k;

        public Uredi()
        {
            InitializeComponent();
        }

        public Uredi(PutnikKontrola k)
        {
            InitializeComponent();
            this.k = k;
        }

        private void Uredi_Load(object sender, EventArgs e)
        {
            textBox1.Text = k.dajIme();
            textBox2.Text = k.dajPrezime();
            DateTime d = Convert.ToDateTime(k.Pomocni.D);
            dateTimePicker1.Value = d;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (errorProvider1.GetError(c) != "") return;
            }
            k.Imenica = textBox1.Text;
            k.Prezimenica = textBox2.Text;
            k.Pomocni.D = dateTimePicker1.Value.ToString();
            k.izmijeni();
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                errorProvider1.SetError(textBox1, "Greska!");
                toolStripStatusLabel1.Text = "Niste unijeli ime!";
                toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                toolStripStatusLabel1.Text = "Waiting...";
                toolStripStatusLabel1.ForeColor = SystemColors.ControlText;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                errorProvider1.SetError(textBox2, "Greska!");
                toolStripStatusLabel1.Text = "Niste unijeli prezime!";
                toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
                toolStripStatusLabel1.Text = "Waiting...";
                toolStripStatusLabel1.ForeColor = SystemColors.ControlText;
            }
        }

        private void dateTimePicker1_Enter_1(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }



    }
}
