﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjveterinario
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "admin") && (txtSenha.Text == "123456"))
            {
                frmprincipal frm = new frmprincipal();
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalido!");

            }
        }
    }
}
