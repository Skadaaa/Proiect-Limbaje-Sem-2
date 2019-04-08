using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimbajeProiect
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            panelUserE.Visible = false;
            panelUserN.Visible = false;
            progressBar1.Visible = false;
            label13.Visible = false;
            label19.Text = DateTime.Now.ToLongTimeString();
            label20.Text = DateTime.Now.ToLongDateString();
        }


        //CARACTERISTICA APLICATIE (ORA + DATA)
        private void Timer2_Tick(object sender, EventArgs e)
        {
            label19.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
        }


        //CONDITII INTRODUCERE INFORMATII CONT EXISTENT (VARIANTA 1, PASUL 0)
        private void TbUsernameUserE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbParolaUserE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //ACCESARE CONT EXISTENT (VARIANTA 1, PASUL 1)
        private void BtnEUser_Click(object sender, EventArgs e)
        {
            panelUserE.Visible = true;

            btnUserN.Visible = false;

            tbUsernameUserE.Visible = true;
            tbParolaUserE.Visible = true;
        }


        //OPTIUNEA 1 DE MODIFICARE A TIPULUI DE CONT
        private void BtnReturnUserE_Click(object sender, EventArgs e)
        {
            btnUserN.Visible = true;
            panelUserE.Dispose();
        }


        //VERIFICARE INFORMATII CONT EXISTENT SI CONECTARE LA SERVER (VARIANTA 1, PASUL 2)
        private void BtnLoginUserE_Click(object sender, EventArgs e)
        {
            if (tbUsernameUserE.Text == "" && tbParolaUserE.Text == "")
                MessageBox.Show("Nu ati completat niciun camp. Revizuiti informatiile ! ");
            else if (tbUsernameUserE.Text == "")
                MessageBox.Show("Nu ati introdus username-ul. Revizuiti informatiile ! ");
            else if (tbParolaUserE.Text == "")
                MessageBox.Show("Nu ati introdus parola. Revizuiti informatiile ! ");
            else if (tbUsernameUserE.Text == "Admin" && tbParolaUserE.Text == "admin")
            {
                progressBar1.Visible = true;
                timer1.Enabled = true;
                label13.Visible = true;
            }
            else
                MessageBox.Show("Username-ul sau parola introduse incorect.");
        }


        //CONDITII INTRODUCERE INFORMATII PERSONALE CONT NOU (VARIANTA 2, PASUL 0)
        private void TbNumeUserN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbPrenumeUserN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbCNPUserN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbAdresaUserN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbTelefonUserN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //CREARE CONT NOU (VARIANTA 2, PASUL 1)
        private void BtnNUser_Click(object sender, EventArgs e)
        {
            panelUserN.Visible = true;

            btnUserE.Visible = false;

            tbNumeUserN.Visible = true;
            tbPrenumeUserN.Visible = true;
            tbCNPUserN.Visible = true; tbCNPUserN.MaxLength = 13;
            tbAdresaUserN.Visible = true;
            tbTelefonUserN.Visible = true; tbTelefonUserN.MaxLength = 10;

            tbUsernameUserN.Visible = false; 
            tbParolaUserN.Visible = false; 
            tbParola2UserN.Visible = false; 
            tbEmailUserN.Visible = false; 
            radioButton1.Visible = false; 
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            pictureBox2.Visible = false;
            pictureBox4.Visible = false;

            btnLoginUserN.Visible = false; 
        }


        //OPTIUNEA 2 DE MODIFICARE A TIPULUI DE CONT
        private void BtnReturnUserN_Click(object sender, EventArgs e)
        {
            btnUserE.Visible = true;
            panelUserN.Dispose();
        }


        //INTRODUCERE SI VERIFICARE INFORMATII PERSONALE CONT NOU (VARIANTA 2, PASUL 2)
        private void BtnContLoginUserN_Click(object sender, EventArgs e)
        {
            if (tbNumeUserN.Text == "" && tbPrenumeUserN.Text == "" && tbCNPUserN.Text == "" && tbAdresaUserN.Text == "" && tbTelefonUserN.Text == "")
                MessageBox.Show("Nu ati completat niciun camp. Revizuiti informatiile ! ");
            else if (tbNumeUserN.Text == "")
                MessageBox.Show("Nu ati introdus numele. Revizuiti informatiile !");
            else if (tbPrenumeUserN.Text == "")
                MessageBox.Show("Nu ati introdus prenumele. Revizuiti informatiile !");
            else if (tbCNPUserN.Text == "")
                MessageBox.Show("Nu ati introdus CNP-ul. Revizuiti informatiile !");
            else if (tbAdresaUserN.Text == "")
                MessageBox.Show("Nu ati introdus adresa. Revizuiti informatiile !");
            else if (tbTelefonUserN.Text == "")
                MessageBox.Show("Nu ati introdus numarul de telefon. Revizuiti informatiile !");
            else
            {
                tbUsernameUserN.Visible = true;
                tbParolaUserN.Visible = true;
                tbParola2UserN.Visible = true;
                tbEmailUserN.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;

                pictureBox2.Visible = true;
                pictureBox4.Visible = true;

                btnLoginUserN.Visible = true;
            }
        }


        //CONDITII INTRODUCERE INFORMATII CONT NOU (VARIANTA 2, PASUL 3)
        private void TbUsernameUserN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbParolaUserN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbParola2UserN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbEmailUserN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //VERIFICARE INFORMATII FINALE CONT NOU SI CONECTARE LA SERVER (VARIANTA 2, PASUL 4)
        private void BtnLoginUserN_Click(object sender, EventArgs e)
        {
            if (tbUsernameUserN.Text == "" && tbParolaUserN.Text == "" && tbParola2UserN.Text == "" && tbEmailUserN.Text == "")
                MessageBox.Show("Nu ati completat niciun camp. Revizuiti informatiile ! ");
            else if (tbUsernameUserN.Text == "")
                MessageBox.Show("Nu ati introdus username-ul. Revizuiti informatiile ! ");
            else if (tbParolaUserN.Text == "")
                MessageBox.Show("Nu ati introdus parola. Revizuiti informatiile ! ");
            else if (tbParola2UserN.Text == "")
                MessageBox.Show("Nu ati introdus parola repetata. Revizuiti informatiile ! ");
            else if (tbEmailUserN.Text == "")
                MessageBox.Show("Nu ati introdus email-ul. Revizuiti informatiile ! ");
            else if (tbParola2UserN.Text != tbParolaUserN.Text)
                MessageBox.Show("Cele doua parole introduse nu corespund. Revizuiti acest aspect ! ");
            else if (radioButton1.Checked != true && radioButton2.Checked != true && radioButton3.Checked != true)
                MessageBox.Show("Alegeti o terminatie a email-ului. ");
            else if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                progressBar1.Visible = true;
                timer1.Enabled = true;
                label13.Visible = true;
            }
        }


        //PROGRES CONECTARE LA SERVER
        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5;
            if (progressBar1.Value == 100)
            {
                UsernameForm.uname = tbUsernameUserE.Text;
                this.Hide();
                ContForm f = new ContForm();
                f.Show();
                timer1.Enabled = false;
                label13.Text = "CONECTARE REUSITA !";
                timer1.Stop();
            }
        }


        //INCHIDERE APLICATIE
        private void BtnExit_Click(object sender, EventArgs e)
        {
            ContForm x = new ContForm();
            x.Close();
            this.Close();
        }

    }
}
