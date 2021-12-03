using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Teacher : Human, ICanHaveQR, ICanDisenfectHand, ICanPutOnMask
    {
        public bool IsHaveQR { get; set; }
        public bool IsHaveMask { get; set; }
    }
}
