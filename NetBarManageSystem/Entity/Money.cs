using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Money
    {
        public string cardno { get; set; }
        public DateTime logintime { get; set; }
        public DateTime offtime { get; set; }
        public int consumetime { get; set; }
        public int consume { get; set; }
        public int remaindermoney { get; set; }
    }
}
