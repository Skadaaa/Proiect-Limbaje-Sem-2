using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Limbaje
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            panel1.Visible = false;
        }

        //Accesare cont existent folosind username si parola
        private void BtnOld_Click(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = false;
            label11.Enabled = true;
            btnNew.Enabled = false;
        }

        //Creare cont nou folosind date personale
        private void BtnNew_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = false;
            label9.Enabled = false;
            label10.Enabled = true;
            label11.Enabled = false;
            btnOld.Enabled = false;
        }

        //Inchidere aplicatie
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
