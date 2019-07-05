using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektVP
{
    public class Kolizija
    {
        public static bool Detect(Kokoski enemyPlane, PlayerPlane playerPlane)
        {
            Point p1 = new Point(playerPlane.getX(), playerPlane.getY());
            Point p2 = new Point(playerPlane.getX() + playerPlane.getImage().Width, playerPlane.getY());
            Point p3 = new Point(playerPlane.getX() + playerPlane.getImage().Width, playerPlane.getY() + playerPlane.getImage().Height);
            Point p4 = new Point(playerPlane.getX(), playerPlane.getY() + playerPlane.getImage().Height);

            Point e1 = new Point(enemyPlane.getX(), enemyPlane.getY());
            Point e2 = new Point(enemyPlane.getX() + enemyPlane.getImg().Width, enemyPlane.getY());
            Point e3 = new Point(enemyPlane.getX() + enemyPlane.getImg().Width, enemyPlane.getY() + enemyPlane.getImg().Height);
            Point e4 = new Point(enemyPlane.getX(), enemyPlane.getY() + enemyPlane.getImg().Height);

            Rectangle r1 = new Rectangle(playerPlane.getX(), playerPlane.getY(), playerPlane.getImage().Width, playerPlane.getImage().Height);
            return false;
        }
    }
}

 