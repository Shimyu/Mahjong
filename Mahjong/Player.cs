using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mahjong
{
    public class Player
    {
        private string p;
        private Mahjong.Fields fields;

        public Player(string p, Mahjong.Fields fields)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.fields = fields;
        }

        public object Field { get; set; }
    }
}
