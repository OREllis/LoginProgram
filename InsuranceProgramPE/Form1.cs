﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceProgramPE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e){
            if (txtFullName.Text == "") MessageBox.Show("Text Box is empty", "Error.");
            else createUserName(txtFullName.Text);
        }

        private void createUserName(string nameIn) {

        }
    }
}
