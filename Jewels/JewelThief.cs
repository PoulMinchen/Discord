using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewel
{
    class JewelThief:LockSmith
    {
        private Jewel stolenJewels=null;
        public override void ReturnContents(Jewel safeContents,Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I'm stealing the contents! "+stolenJewels.Sparkle());
        }
    }
}
