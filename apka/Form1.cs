using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace apka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        void prank()
        {
             double opacity = 0.01;
            while (true)
            {
                this.ShowInTaskbar = false;

                this.TopMost = true;
                Thread.Sleep(4000);
                this.Visible = false;
                this.Opacity = opacity;
                Thread.Sleep(4000);
                this.Visible = true;
                opacity+=0.01;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            prank();
        }
    }
}
