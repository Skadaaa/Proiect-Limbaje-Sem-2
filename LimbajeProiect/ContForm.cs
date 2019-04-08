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
    public partial class ContForm : Form
    {
        public ContForm()
        {
            InitializeComponent();
        }

        private void ContForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = UsernameForm.uname;
        }

        private void BtnDeconectUser_Click(object sender, EventArgs e)
        {
           Close();
            LoginForm g = new LoginForm();
            g.Show();
        }
    }
}
