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
            //サイ振り用ランダム
            System.Random r = new System.Random();

            //サイコロ2個の値を取得
            var sai1 = r.Next(5) + 1;
            var sai2 = r.Next(5) + 1;

            //サイコロの値を足して,計算(途中
            var saiValue = sai1 + sai2;
            
            throw new NotImplementedException();

        }
    }
}
