using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter
{
    public partial class Form1 : Form
    {
        Viewer v;
        int ScreenViewNum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v = new Viewer(ScreenViewNum);
            v.Show();
            v.FormClosed += v_FormClosed;
        }

        void v_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (v != null)
                v.Dispose();
            v = new Viewer(ScreenViewNum);
            v.Show();
            v.FormClosed += v_FormClosed;
        }
    }
}
