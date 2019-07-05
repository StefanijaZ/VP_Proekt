using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektVP
{
    public class Kursum
    {
        private Bitmap Bullet;
        private int speed;
        private int X;
        private int Y;

        public Kursum(int x, int y)
        {
            Bullet = new Bitmap(Properties.Resources.kursum);
            X = x;
            Y = y;
            speed = 30;
        }

        public void moveBullets()
        {
            Y = Y - speed;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(Bullet, X, Y);
        }
        public int getSpeed()
        {
            return speed;
        }
        public Bitmap getImage()
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

