using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rogue_cui_cs_git
{
    class Rule
    {
        public const int MAPX = 10;
        public const int MAPY = 10;

        public int[,] map = new int[,] { { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                                                 { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                                 { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                                 { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                                 { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                                 { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                                 { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                                 { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                                 { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                                                 { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } };

        public Rule() {

        }
    }
}
