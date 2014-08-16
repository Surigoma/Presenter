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
    public partial class Viewer : Form
    {
        public Viewer(int ScreenNum)
        {
            InitializeComponent();
            var r = Screen.AllScreens[ScreenNum].Bounds;
            this.Location = new Point(r.X, r.Y);
            this.Width = r.Width;
            this.Height = r.Height;
        }
    }
}
