﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dzagar_SE3314_Assignment
{
    public partial class MainView : Form
    {
        Controller servControl;
        public MainView()
        {
            InitializeComponent();
            servControl = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servControl.SpawnRTSPThread();
        }
    }
}
