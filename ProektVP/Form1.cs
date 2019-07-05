using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using ProektVP.Properties;

namespace ProektVP
{
    public partial class Form1 : Form
    {
        public Sounds sounds;
        Image image;
        public Form1()
        {
            InitializeComponent();
            this.Width = 960;
            this.Height = 540;
            play.BackColor = Color.Transparent;
            naslov1.BackColor = Color.Transparent;
            naslov2.BackColor = Color.Transparent;
            image = Resources.slika;
            quit.BackColor = Color.Transparent;
            gameRules.BackColor = Color.Transparent;
            sounds = new Sounds();
            sounds.playPocetok();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.DoubleBuffered = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(image, 540, 65);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void quit_Click(object sender, EventArgs e)
        {
            string message = "Дали сте сигурни?";
            string title = "Исклучи игра!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void gameRules_Click(object sender, EventArgs e)
        {
            Rules form = new Rules();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
             GameWindow game = new GameWindow();
            // game.ShowDialog();
            // game.freez();
            // sounds.playPocetok();


            if (game.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sounds.playPocetok();
                this.Close();
            } 
        }
    }
}
