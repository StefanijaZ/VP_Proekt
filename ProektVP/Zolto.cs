using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektVP
{
    public class Zolto
    {
        private Bitmap enemy;
        private int X;
        private int Y;
        private int speed;
        private int life;
        private int T;
        public Zolto(int x, int y, int t)
        {
            T = t;
            if (t == 1)
                enemy = new Bitmap(Properties.Resources.jajce);
            else
                enemy = new Bitmap(Properties.Resources.jajce);
            X = x;
            Y = y;
            speed = 8;  
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

        public void LoseLife()
        {
            life = life - 1;
            if (T == 1) enemy = new Bitmap(Properties.Resources.jajce);
            else enemy = new Bitmap(Properties.Resources.jajce);
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(enemy, X, Y);
        }



        public int getX()
        {
            return X;
        }

        public int getY()
        {
            return Y;
        }

        public Bitmap getImg()
        {
            return enemy;
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
