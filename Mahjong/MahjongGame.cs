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
        /// <summary>
        /// 仮親決め
        /// </summary>
        /// <returns></returns>
        public Player DecideParent()
        {
            //決定した親を格納.
            Player parent = null;

            //サイ振り用ランダム.
            System.Random r = new System.Random();

            //サイコロ2個の値を取得.
            var sai1 = r.Next(5) + 1;
            var sai2 = r.Next(5) + 1;

            //サイコロの値を足して,計算
            var saiValue = sai1 + sai2;

           while(saiValue > 5)
            {
                saiValue = saiValue - 4;
            }
            switch (saiValue)
            {
                case 1:
                    parent = p1;
                    break;
                case 2:
                    parent = p2;
                    break;
                case 3:
                    parent = p3;
                    break;
                case 4:
                    parent = p4;
                    break;
            }
            //親を返すよ
            return parent;
        }

        /// <summary>
        /// 仮親が決まっている場合
        /// 仮親の位置分プラスして回すよ
        /// </summary>
        /// <param name="p">p:受け取った仮親だよ！</param>
        /// <returns>仮親から決定した親を返すよ！</returns>
        public Player DecideParent(Player p)
        {
            //決定する親を格納.
            Player parent = null;

            //サイ振り用ランダム.
            System.Random r = new System.Random();

            //サイコロ2個の値を取得.
            var sai1 = r.Next(5) + 1;
            var sai2 = r.Next(5) + 1;

            //サイコロの値を足して,計算
            var saiValue = sai1 + sai2;

            //**怒られた・・・型がPlayerだから・・・かな？**
            //switch (p.value)
            //{
            //    case p1:
            //        saiValue = saiValue + 1;
            //    break;
            //    case p2:
            //        saiValue = saiValue + 2;
            //    break;
            //}

            //仮親の席分足す.
            //         p3←3.
            //  4→p4     p2←2.
            //        p1←ここを1.
            if (p == p1)
            {
                saiValue = saiValue + 1;
            }
            else if(p == p2)
            {
                saiValue = saiValue + 2;
            }
            else if (p == p3)
            {
                saiValue = saiValue + 3;
            }
            else if (p == p4)
            {
                saiValue = saiValue + 4;
            }

            while (saiValue > 5)
            {
                saiValue = saiValue - 4;
            }
            switch (saiValue)
            {
                case 1:
                    parent = p1;
                    break;
                case 2:
                    parent = p2;
                    break;
                case 3:
                    parent = p3;
                    break;
                case 4:
                    parent = p4;
                    break;
            }
            //親を返すよ
            return parent;
        }
    }
}
