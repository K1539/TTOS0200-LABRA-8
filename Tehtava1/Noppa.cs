using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{

    class Noppa
    {
        public Random rnd = new Random();

        float noppaluku;
        public float NoppaLuku
        {
            get
            {
                noppaluku = rnd.Next(1, 7);
                return noppaluku;
            }
            set
            { }
        }
    }
}
