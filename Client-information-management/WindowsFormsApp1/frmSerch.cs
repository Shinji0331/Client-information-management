﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSerch : Form
    {
        public frmSerch()
        {
            InitializeComponent();
        }



        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //
            DateTime start = e.Start;
            DateTime end = e.End;
            Console.WriteLine("Changed: " + start.ToString() + " " + end.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
