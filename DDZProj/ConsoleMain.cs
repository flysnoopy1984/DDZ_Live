using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDZProj
{
    public partial class ConsoleMain : Form
    {
        private Main _mainForm;
        public ConsoleMain()
        {
            InitializeComponent();
        }

        public ConsoleMain(Main mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();
        }

        private void Bn_Begin_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.StartDealt();
        }

        private void bn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void bn_CallBoss_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.CallingBoss();
        }

        private void bn_One_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.TestSetScore(1);
        }

        private void bn_Two_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.TestSetScore(2);
        }

        private void bn_Three_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.TestSetScore(3);
        }


    }
}
