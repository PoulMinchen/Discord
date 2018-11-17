using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewel
{
    class Safe
    {
        private Jewel contents = new Jewel();
        private string SafeCombination = "12345";
        public Jewel Open(string safecombination)
        {
            if(safecombination==SafeCombination)
            {
                return contents;
            }
            else
            {
                return null;
            }
        }
        public void PickLock(LockSmith lockpicker)
        {
            lockpicker.WriteDownCombination(SafeCombination);
        }
    }
}
