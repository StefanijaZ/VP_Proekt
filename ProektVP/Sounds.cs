using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProektVP
{
    public class Sounds
    {
        private SoundPlayer Pocetok;
        private SoundPlayer MainMusic;
        private SoundPlayer GameOver;
        private SoundPlayer MissionComplete;

        public Sounds()
        {
            Pocetok = new SoundPlayer(Properties.Resources.pocetok);
            GameOver = new SoundPlayer(Properties.Resources.gameover);
            MissionComplete = new SoundPlayer(Properties.Resources.missioncomplete);
        }
        public void playPocetok()
        {
            Pocetok.PlayLooping();
        }
        public void playGameOver()
        {
            GameOver.Play();
        }
        public void playMissionComplete()
        {
            MissionComplete.PlayLooping();
        }
    }
}
