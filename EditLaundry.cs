﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem
{
    public partial class EditLaundry : Form
    {
        public EditLaundry()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditLaundry_Load(object sender, EventArgs e)
        {
            cbMachine.Text = "Washing Machine";
            pickupDate.Text = "10/16/2024";
            cbService.SelectedIndex = 0;
            cbCust.SelectedIndex = 1;
            txtWeight.Text = "5.00";
            cbItem1.SelectedIndex = 0;
            cbItem2.SelectedIndex = 2;
            quantity1.Text = "2g";
            quantity2.Text = "1mL";
            rb2hrs.Checked = true;

        }
    }
}