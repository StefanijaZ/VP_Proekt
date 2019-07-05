using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektVP
{
    public class Kopani
    {
        private Bitmap Bullet;
        private int speed;
        private int X;
        private int Y;

        public Kopani(int x, int y)
        {
            Bullet = new Bitmap(Properties.Resources.kopance);
            X = x;
            Y = y;
            speed = 30;
        }

        public void moveBullets()
        {
            Y = Y + speed;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(Bullet, X, Y);
        }
        public Bitmap getImg()
        {
            return Bullet;
        }
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
    }
}
