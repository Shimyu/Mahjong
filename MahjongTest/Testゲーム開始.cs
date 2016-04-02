using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Mahjong;

namespace MahjongTest
{
    [TestClass]
    public class Testゲーム開始
    {
        [TestMethod]
        public void Test親を決める()
        {
            var p1 = new Player("Aさん", Fields.East);
            var p2 = new Player("Bさん", Fields.North);
            var p3 = new Player("Cさん", Fields.West);
            var p4 = new Player("Dさん", Fields.South);

            var game = new MahjongGame(p1,p2,p3,p4);
            Player kariParent = game.DecideParent(6);

            Assert.AreEqual(kariParent, p3);

            var parent = game.DecideParent(7);

            Assert.AreEqual(parent, p2);
            Assert.AreEqual(parent.Field, Fields.East);
        }

        [TestMethod]
        public void Test卓が山を作成する()
        {
            IEnumerable<Hai> hai  = Hai.DefaultSet();
            Taku taku = new Taku();
            taku.SetHai(hai);
            taku.CreateYama();
            Yama yama = taku.Yama;

            Assert.IsFalse(hai.SequenceEqual(yama));

            //↓最初の手牌をとる↓
            //山に(ダイス値)をセット
            yama.SetWakeme(7);
            //ドラがひとつ入っているよね？
            Assert.AreEqual(1, yama.Dora.Count());
            
            //手牌がちゃんと配られているよね？
            for(int i = 0; i < 12; i++){
                IEnumerable<Hai> taken = yama.TakeFour();
            }

            yama.TakeChonChon();
            yama.TakeOne();
            yama.TakeOne();
            yama.TakeOne();
            //136-(13*3+14)
            Assert.AreEqual(yama.Count, 83);
        }       
    }
}
