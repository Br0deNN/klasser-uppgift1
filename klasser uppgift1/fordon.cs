using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_uppgift1
{
    class fordon
    {
        public string? märke;
        public string? modell;
        public string? färg;
        public int? årsmodell;
        public int? mil;

        public fordon(string Mä, string mo, string fä, int år, int mi)
        {
            märke = Mä;
            modell = mo;
            färg = fä;
            årsmodell = år;
            mil = mi;
        }

    }
}
