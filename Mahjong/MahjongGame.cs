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
            //決定した親を格納.
            Player decideParent;

            //サイ振り用ランダム.
            System.Random r = new System.Random();

            //サイコロ2個の値を取得.
            var sai1 = r.Next(5) + 1;
            var sai2 = r.Next(5) + 1;

            //サイコロの値を足して,計算
            var saiValue = sai1 + sai2;

           while(saiValue < 5)
            {
                saiValue = saiValue - 4;
            }
            switch (saiValue)
            {
                case 1:
                    decideParent = p1;
                    break;
                case 2:
                    decideParent = p2;
                    break;
                case 3:
                    decideParent = p3;
                    break;
                case 4:
                    decideParent = p4;
                    break;
            }
            //未割当のローカル変数'decideParent'が使用されました？
            return decideParent;
        }
    }
}
