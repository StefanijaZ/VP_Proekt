using ProektVP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektVP
{
    public partial class Rules : Form
    {
        Image image;
        public Rules()
        {
            InitializeComponent();
            image = Resources.pl;
        }

        private void Rules_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(image, 100, 50);
            e.Graphics.Clear(Color.White);
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            
        }
    }
}
