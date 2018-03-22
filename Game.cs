using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//part 7 making comments

namespace GameListLibrary
{
    public class Game
    {
        public String Team1 { get; set; }
        public String Team2 { get; set; }
        public int Team1score { get; set; }
        public int Team2score { get; set; }

        public Game()
        {

        }

        public Game(String Team1, String Team2, int Team1score, int Team2score)
        {
            this.Team1 = Team1;
            this.Team2 = Team2;
            this.Team1score = Team1score;
            this.Team2score = Team2score;
        }

        public override string ToString()
        {
            return string.Format("{0} ({2}) - {1} ({3})", Team1, Team2, Team1score, Team2score);
        }
    }
}
