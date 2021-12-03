using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Checkpoint
    {
        public int Masks { get; set; } = 1;
        public int Desinfects { get; set; } = 6;

        public List<IVisitor> VisitorsWantToISIT { get; set; } = new List<IVisitor>();
        public List<IVisitor> VisitorsCanToISIT { get; set; } = new List<IVisitor>();
        public void Check()
        {

            foreach (IVisitor visitor in VisitorsWantToISIT)
            {

                if (visitor is ICanDisenfectHand && visitor is ICanPutOnMask && visitor is ICanHaveQR)
                {
                    if (((ICanHaveQR)visitor).IsHaveQR)
                    {
                        if (((ICanPutOnMask)visitor).IsHaveMask)
                        {
                            VisitorsCanToISIT.Add(visitor);
                            Desinfects = Desinfects - 1;
                        }
                        else if (Masks > 0 && Desinfects > 0)
                        {
                            VisitorsCanToISIT.Add(visitor);
                            Desinfects = Desinfects - 1;
                            Masks = Masks - 1;
                        }
                    }

                }

            }
        }
    }
}
