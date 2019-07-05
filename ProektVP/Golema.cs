using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektVP
{
    public class Golema
    {
        private Bitmap enemyPlaneImg;
        public int X;
        public int Y;
        private int speed;
        private int life;
        private int T;


        public void DrawN(int x, int y)
        {
            X = x;
            Y = y;
        }


        public void Move()
        {
            X += 5;

        }
        public Golema(int x, int y)
        {
            enemyPlaneImg = new Bitmap(Properties.Resources.golemaplava);
            X = x;
            Y = y;
            speed = 6;  // Old Value 5
            life = 30;
        }
        // Move the Plain
        public bool enemyPlaneOnTheMove(int maxHeight)
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
            if (T == 1) enemyPlaneImg = new Bitmap(Properties.Resources.golemaplava);
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(enemyPlaneImg, X, Y);
        }

        //Getters and Setters

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
            return enemyPlaneImg;
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
