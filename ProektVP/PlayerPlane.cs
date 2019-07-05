using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektVP
{
    public class PlayerPlane
    {
        private Bitmap playerImg;
        private int playerLife;
        private int playerSpeed;
        private List<Kokoski> kokoskiE;
        private List<Kursum> kursumi;
        private int X;
        private int Y;
        private int maxWidth;
        private int maxHeight;

        public PlayerPlane(int formWidth, int formHeight)
        {
            playerImg = new Bitmap(Properties.Resources.pl);
            playerLife = 3;
            playerSpeed = 10;
            kokoskiE = new List<Kokoski>();
            kursumi = new List<Kursum>();
            X = formWidth / 2;
            Y = formHeight - playerImg.Size.Height - 15;
            maxWidth = formWidth - playerImg.Width - 5;
            maxHeight = formHeight - playerImg.Height;
        }
        public void loseLife()
        {
            playerLife--;
        }

        public void moveLeft()
        {
            int t = X - playerSpeed;
            if (t > 0) X = t;
        }
        public void moveRight()
        {
            int t = X + playerSpeed;
            if (t < maxWidth - 10) X = t;
        }
        public void removeRocket(int i)
        {
            kokoskiE.Remove(kokoskiE[i]);
        }

        public void fireBullet()
        {
            kursumi.Add(new Kursum(X + 30, Y));
        }
        public void removeBullet(int i)
        {
            kursumi.Remove(kursumi[i]);
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(playerImg, X, Y);
        }

        public int getX()
        {
            return X;
        }
        public void setX(int x)
        {
            X = x;
        }

        public int getY()
        {
            return Y;
        }
        public void setY(int y)
        {
            Y = y;
        }
        
        public Bitmap getImage()
        {
            return playerImg;
        }
        public int getPlayerLife()
        {
            return playerLife;
        }
        public void setPlayerLife(int life)
        {
            playerLife = life;
        }
       
        public List<Kokoski> getFiredRocekts()
        {
            return kokoskiE;
        }
        public List<Kursum> getFiredBullets()
        {
            return kursumi;
        }
        public void moveUpBullets(int i)
        {
            kursumi[i].moveBullets();
        }
    }
}
