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
    public partial class GameWindow : Form
    {
        int golema = 1;
        int prv = 1;
        int levo = 1;
        int desno = 0;
        public List<Golema> g;
        public PlayerPlane avionce;
        public List<Kokoski> kok;
        public List<KokoskiM> kokM;
        public List<Zolto> zolto;
        public List<Kopani> kop;
        public Sounds sounds;
        public List<Kursum> k;
        public int s = 0;
        int points=0;
        int nema = 9;
        int daVlezi = 0;
        public GameWindow()
        {
            InitializeComponent();
            Run();

        }
        public void Run()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Hide();
                }
            }

            g = new List<Golema>();
            zolto = new List<Zolto>();
            kokM = new List<KokoskiM>();
            kop = new List<Kopani>();
            avionce = new PlayerPlane(900, 550);
            kok = new List<Kokoski>();
            this.Width = 900;
            this.Height = 600;
            sounds = new Sounds();
            sounds.playMissionComplete();
            this.DoubleBuffered = true;
            k = new List<Kursum>();
            fillList();
        }


        public void fillList()
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                kok.Add(new Kokoski(random.Next(750), -random.Next(1000), random.Next(2)));
            }   
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                avionce.moveRight();
            if (e.KeyCode == Keys.Left)
                avionce.moveLeft();
            if (e.KeyCode == Keys.Space)
            {
                avionce.fireBullet();
            }
        }
        

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            sounds.playPocetok();
        }

        

        private void GameWindow_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < avionce.getFiredBullets().Count; i++)
            {
                avionce.getFiredBullets()[i].Draw(e.Graphics);
            }
            for (int i = 0; i < avionce.getFiredRocekts().Count; i++)
            {
                avionce.getFiredRocekts()[i].Draw(e.Graphics);
            }

            if (avionce.getPlayerLife() != 0)
            {
                avionce.Draw(e.Graphics);
            }
            for (int i = 0; i < kok.Count; i++)
            {
                kok[i].Draw(e.Graphics);
            }

            for (int i = 0; i < kokM.Count; i++)
            {
                kokM[i].Draw(e.Graphics);
            }
            for (int i = 0; i < kop.Count; i++)
            {
                kop[i].Draw(e.Graphics);
            }
            for (int i = 0; i < zolto.Count; i++)
            {
                zolto[i].Draw(e.Graphics);
            }
            for (int i = 0; i < g.Count; i++)
           {
                g[i].Draw(e.Graphics);
           }

        }



        private void EnemyPlaneMove()
        {
            for (int i = 0; i < kok.Count; i++)
            {
                Rectangle r1 = new Rectangle(avionce.getX(), avionce.getY(), avionce.getImage().Width, avionce.getImage().Height);
                Rectangle r2 = new Rectangle(kok[i].getX(), kok[i].getY(), kok[i].getImg().Width, kok[i].getImg().Height);

                if (!kok[i].enemyOnTheMove(900))
                {
                }
                if (r1.IntersectsWith(r2))
                {
                    kok.Remove(kok[i]);
                    avionce.setPlayerLife(avionce.getPlayerLife() - 1);
                    if (avionce.getPlayerLife() == 0)
                    {
                        level.Text = "GAME OVER";
                        timer1.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        timer4.Stop();
                        lifes.Text = string.Format("Player Lifes: {0}", avionce.getPlayerLife());
                        sounds.playGameOver();

                    }
                }

            }
        }

        public void moveTheBullets()
        {
            for (int i = 0; i < avionce.getFiredBullets().Count; i++)
            {
                avionce.moveUpBullets(i);


                if (avionce.getFiredBullets()[i].getY() < 0)
                {
                    avionce.removeBullet(i);
                }
                else
                {
                    for (int y = 0; y < kok.Count; y++)
                    {
                        Rectangle r1 = new Rectangle(avionce.getFiredBullets()[i].getX(), avionce.getFiredBullets()[i].getY(), avionce.getFiredBullets()[i].getImage().Width, avionce.getFiredBullets()[i].getImage().Height);
                        Rectangle r2 = new Rectangle(kok[y].getX(), kok[y].getY(), kok[y].getImg().Width, kok[y].getImg().Height);

                        if (r1.IntersectsWith(r2))
                        {
                            avionce.removeBullet(i);
                            kok[y].LoseLife();
                            if (kok[y].LIFE() <= 0)
                            {
                                kok.Remove(kok[y]);
                                points += 5;
                            }
                            break;
                        }
                    }

                }

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            moveTheBullets();
            EnemyPlaneMove();
            score.Text = string.Format("Score: {0}", points);
            lifes.Text = string.Format("Player Lifes: {0}", avionce.getPlayerLife());
        }
      
      

        private void timer2_Tick(object sender, EventArgs e)
        {
            score.Text = string.Format("Score: {0}", points);
            lifes.Text = string.Format("Player Lifes: {0}", avionce.getPlayerLife());
            if (prv==1)
            {
                fillListL2();
                timer1.Stop();
                prv = 0;
            }
            level.Text = "LEVEL 2";
            timer2.Interval = 45;
            Invalidate();
            MoveBull();
            EnemyMove();
            score.Text = string.Format("Score: {0}", points);
            lifes.Text = string.Format("Player Lifes: {0}", avionce.getPlayerLife());


        }

        public void MoveBull()
        {
            for (int i = 0; i < avionce.getFiredBullets().Count; i++)
            {
                avionce.moveUpBullets(i);


                if (avionce.getFiredBullets()[i].getY() < 0)
                {
                    avionce.removeBullet(i);
                }
                else
                {
                    for (int y = 0; y < kokM.Count; y++)
                    {
                        Rectangle r1 = new Rectangle(avionce.getFiredBullets()[i].getX(), avionce.getFiredBullets()[i].getY(), avionce.getFiredBullets()[i].getImage().Width, avionce.getFiredBullets()[i].getImage().Height);
                        Rectangle r2 = new Rectangle(kokM[y].getX(), kokM[y].getY(), kokM[y].getImg().Width, kokM[y].getImg().Height);

                        if (r1.IntersectsWith(r2))
                        {
                            avionce.removeBullet(i);
                            kokM[y].LoseLife();
                            if (kokM[y].LIFE() <= 0)
                            {
                                kokM.Remove(kokM[y]);
                                points += 5;
                            }
                            break;
                        }
                    }

                }

            }
        }
        public void EnemyMove()
        {
            for (int i = 0; i < kokM.Count; i++)
            {
                Rectangle r1 = new Rectangle(avionce.getX(), avionce.getY(), avionce.getImage().Width, avionce.getImage().Height);
                Rectangle r2 = new Rectangle(kokM[i].getX(), kokM[i].getY(), kokM[i].getImg().Width, kokM[i].getImg().Height);

                if (!kokM[i].enemyOnTheMove(900))
                {
                }
                if (r1.IntersectsWith(r2))
                {
                    kokM.Remove(kokM[i]);
                    avionce.setPlayerLife(avionce.getPlayerLife() - 1);
                    if (avionce.getPlayerLife() == 0)
                    {
                        level.Text = "GAME OVER";
                        timer1.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        timer4.Stop();
                        lifes.Text = string.Format("Player Lifes: {0}", avionce.getPlayerLife());
                        sounds.playGameOver();

                    }
                }

            }
        }

        public void fillListL2()
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                kokM.Add(new KokoskiM(random.Next(750), -random.Next(1000), random.Next(2)));

            }
        }
        public void moveLil()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Location = new Point(x.Location.X + 5, x.Location.Y);
                    if(x.Location.X>Width)
                    {
                        this.Controls.Remove(x);
                        nema--;
                    }
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            score.Text = string.Format("Score: {0}", points);
            lifes.Text = string.Format("Player Lifes: {0}", avionce.getPlayerLife());
            if (nema==0)
            {
                timer2.Stop();
                timer3.Interval = 50;
                KopMove();
                daVlezi = 1;
                fillListZ();
                Invalidate(true);
            }
            else
            {
                moveLil();
                timer2.Stop();
                level.Text = "LEVEL 3";
                Invalidate();
                MB();
                score.Text = string.Format("Score: {0}", points);
                lifes.Text = string.Format("Player Lifes: {0}", avionce.getPlayerLife());
                timer3.Interval = 45;
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "lil")
                    {
                        x.Show();
                    }
                }
                KopMove();
                Invalidate();    
            }
            if(daVlezi == 1)
            {
                MovezaZoltoB();
                MoveZolti();
                Invalidate();
            }
        }

        public void KopMove()
        {
            for (int i = 0; i < kop.Count; i++)
            {
                Rectangle r1 = new Rectangle(avionce.getX(), avionce.getY(), avionce.getImage().Width, avionce.getImage().Height);
                Rectangle r2 = new Rectangle(kop[i].getX(), kop[i].getY(), kop[i].getImg().Width, kop[i].getImg().Height);

                kop[i].moveBullets();
                if (r1.IntersectsWith(r2))
                {
                    kop.Remove(kop[i]);
                    points += 3;
                }
            }
        }

        public void frliKopance(int x, int y)
        {
            nema--;
            kop.Add(new Kopani(x, y));
            kop.Add(new Kopani(x+15, y+60));
            kop.Add(new Kopani(x+40, y+45));
        }


        public void MB()
        {
            for (int i = 0; i < avionce.getFiredBullets().Count; i++)
            {
                avionce.moveUpBullets(i);


                if (avionce.getFiredBullets()[i].getY() < 0)
                {
                    avionce.removeBullet(i);
                }
                else
                {
                    foreach (Control x in this.Controls)
                    {
                        if(x is PictureBox && x.Tag=="lil")
                        {
                            Rectangle r1 = new Rectangle(avionce.getFiredBullets()[i].getX(), avionce.getFiredBullets()[i].getY(), avionce.getFiredBullets()[i].getImage().Width, avionce.getFiredBullets()[i].getImage().Height);
                            Rectangle r2 = new Rectangle(x.Location.X, x.Location.Y, x.Width, x.Height);

                            if (r1.IntersectsWith(r2))
                            {
                                avionce.removeBullet(i);
                                frliKopance(x.Location.X, x.Location.Y);
                                points += 5;
                                this.Controls.Remove(x);
                                break;
                            }

                        }
                       
                    }

                }

            }
        }
        public void fillListZ()
        {
            Random random = new Random();
            for (int i = zolto.Count; i < 20; i++)
            {
                zolto.Add(new Zolto(random.Next(750), -random.Next(1000), random.Next(2)));
            }

        }



        public void MoveZolti()
        {
            for (int i = 0; i < zolto.Count; i++)
            {
                Rectangle r1 = new Rectangle(avionce.getX(), avionce.getY(), avionce.getImage().Width, avionce.getImage().Height);
                Rectangle r2 = new Rectangle(zolto[i].getX(), zolto[i].getY(), zolto[i].getImg().Width, zolto[i].getImg().Height);

                if (!zolto[i].enemyOnTheMove(900))
                {
                    
                }
                if (r1.IntersectsWith(r2))
                {
                    zolto.Remove(zolto[i]);
                    avionce.setPlayerLife(avionce.getPlayerLife() - 1);
                    if (avionce.getPlayerLife() == 0)
                    {
                        level.Text = "GAME OVER";
                        timer1.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        timer4.Stop();
                        lifes.Text = string.Format("Player Lifes: {0}", avionce.getPlayerLife());
                        sounds.playGameOver();

                    }
                }
            }
        }
        public void MovezaZoltoB()
        {
            for (int i = 0; i < avionce.getFiredBullets().Count; i++)
            {
                avionce.moveUpBullets(i);


                if (avionce.getFiredBullets()[i].getY() < 0)
                {
                    avionce.removeBullet(i);
                }
                else
                {
                    for (int y = 0; y < zolto.Count; y++)
                    {
                        Rectangle r1 = new Rectangle(avionce.getFiredBullets()[i].getX(), avionce.getFiredBullets()[i].getY(), avionce.getFiredBullets()[i].getImage().Width, avionce.getFiredBullets()[i].getImage().Height);
                        Rectangle r2 = new Rectangle(zolto[y].getX(), zolto[y].getY(), zolto[y].getImg().Width, zolto[y].getImg().Height);

                        if (r1.IntersectsWith(r2))
                        {
                            avionce.removeBullet(i);
                            zolto[y].LoseLife();
                            if (zolto[y].LIFE() <= 0)
                            {
                                zolto.Remove(zolto[y]);
                                points += 5;
                            }
                            break;
                        }
                    }
                }
            }
        }


        public void fill()
        {
            g.Add(new Golema(0, 10));
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            level.Text = "LEVEL 4";
            score.Text = string.Format("Score: {0}", points);
            lifes.Text = string.Format("Player Lifes: {0}", avionce.getPlayerLife());
            timer2.Stop();
            if(golema==1)
            {
                fill();
                golema = 0;
            }
            timer4.Interval = 45;
            for(int i=0; i<g.Count; i++)
            {
                
                g[i].X += 5;
                if (g[i].X > Width)
                    g.RemoveAt(i);
            }
            bulG();
            Invalidate();
        }

        public void bulG()
        {
            for (int i = 0; i < avionce.getFiredBullets().Count; i++)
            {
                avionce.moveUpBullets(i);

                if (avionce.getFiredBullets()[i].getY() < 0)
                {
                    avionce.removeBullet(i);
                }
                else
                {
                    for (int y = 0; y < g.Count; y++)
                    {
                        Rectangle r1 = new Rectangle(avionce.getFiredBullets()[i].getX(), avionce.getFiredBullets()[i].getY(), avionce.getFiredBullets()[i].getImage().Width, avionce.getFiredBullets()[i].getImage().Height);
                        Rectangle r2 = new Rectangle(g[y].getX(), g[y].getY(), g[y].getImg().Width, g[y].getImg().Height);

                        if (r1.IntersectsWith(r2))
                        {
                            avionce.removeBullet(i);
                            g[y].LoseLife();
                            if (g[y].LIFE() <= 0)
                            {

                                sounds.playPocetok();
                                level.Text = "YOU WON";
                                g.Clear();
                                k.Clear();
                                l.Show();

                                timer1.Stop();
                                timer2.Stop();
                                timer3.Stop();
                                timer4.Stop();
                                points += 20;
                                break;
                            }
                            
                        }
                    }

                }

            }
        }
    }
}




