using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JMS_Explorer
{

    public partial class Selector : Form
    {
        public Selector()
        {
            InitializeComponent();
        }

        private void b_Explorer_Click(object sender, EventArgs e)
        {
            frm_Main _main = new frm_Main(true);
            _main.ShowDialog();
        }

        private void b_Creator_Click(object sender, EventArgs e)
        {
        frm_Main _main =    new frm_Main(false);
        _main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JMS_Explorer.JMSMergeTesting t_main = new JMSMergeTesting();
           
            t_main.ShowDialog();
        }
    }
}
