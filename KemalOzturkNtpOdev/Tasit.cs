using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemalOzturkNtpOdev
{
    public class Tasit
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
    }
    public class Araba : Tasit
    {
        public string Motor { get; set; }
        public string Km { get; set; }
        public string Yıl { get; set; }

        

    }
}
