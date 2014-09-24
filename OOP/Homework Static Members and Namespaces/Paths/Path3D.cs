using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paths
{
    class Path3D
    {
        private List<string> points = new List<string>() {"x = 2, y = 3, z = 5",
                                                          "x = 2.4, y = 3.3, z = 1.5",
                                                          "x = 15.4, y = 4.3, z = 13.2",
                                                          "x = 11.2, y = 3, z = 5.54",
                                                          "x = 12, y = 23.2, z = 2.5",
                                                          "x = 123, y = 33, z = 12135"
                                                          
        };
        public List<string> Points
        {
            get
            { return this.points; }
        }

    }
}
