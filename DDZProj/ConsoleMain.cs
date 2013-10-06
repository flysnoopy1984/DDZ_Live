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


    }
}
