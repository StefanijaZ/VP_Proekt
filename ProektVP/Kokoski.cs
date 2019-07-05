using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektVP
{
    public class Kokoski
    {
   
        private Bitmap enemyImg;
        private int X;
        private int Y;
        private int speed;
        private int life;
        private int T;
        public Kokoski(int x, int y, int t)
        {
            T = t;
            if (t == 1)
                enemyImg = new Bitmap(Properties.Resources.meteorvioletov);
            else
                enemyImg = new Bitmap(Properties.Resources.meteor2);
            X = x;
            Y = y;
            speed = 6; 
            life = 2;
        }
        public bool enemyOnTheMove(int maxHeight)
        {
            if (Y + speed < maxHeight)
            {
                Y = Y + speed;
                return true;
            }
            return false;
        }
        //Plain lose life
        public void LoseLife()
        {
            life = life - 1;
            if (T == 1) enemyImg = new Bitmap(Properties.Resources.meteorvioletov);
            else enemyImg = new Bitmap(Properties.Resources.meteor2);
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(enemyImg, X, Y);
        }

        public int getX()
        {
            return X;
        }

        public int getY()
        {
            return Y;
        }

        public void setY(int y)
        {
            Y = y;
        }

        public Bitmap getImg()
        {
            return enemyImg;
        }
        public int getSpeed()
        {
            return speed;
        }
        public int LIFE()
        {
            return life;
        }
    }
}
