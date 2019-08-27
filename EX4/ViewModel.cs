using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    public class ViewModel
    {
        public int VNum { get; set; }
        public int BNum { get; set; }
        public int ANum { get; set; }
        public int Ave { get; set; }

        public void CalcAve ()
        {
            Ave = VNum + BNum + ANum / 3;
        }

        public ViewModel ()
        {
            CalcAve();
        }
    }
}
