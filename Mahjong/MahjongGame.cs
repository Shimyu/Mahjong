using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mahjong
{
    public class MahjongGame
    {
        private Player p1;
        private Player p2;
        private Player p3;
        private Player p4;

        public MahjongGame(Player p1, Player p2, Player p3, Player p4)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        public Player DecideParent(int p)
        {
            throw new NotImplementedException();
        }
    }
}
