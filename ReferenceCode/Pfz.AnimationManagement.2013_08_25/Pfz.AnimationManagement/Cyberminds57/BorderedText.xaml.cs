using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Cyberminds57
{
    public partial class BorderedText : UserControl
    {
        public BorderedText()
        {
            InitializeComponent();
        }

        private string _text;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;

                foreach (TextBlock textBlock in grid.Children)
                    textBlock.Text = value;
            }
        }
    }
}
