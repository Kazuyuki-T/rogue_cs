using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rogue_cui_cs_git
{
    class State
    {
        // all OK
        private int gameTurn;
        private int flr;
        private int hp, mhp, stm, lv, exp;
        private int pt, fd, ar, st, itemNumber;
        private int x, y;
        // NG or part
        private int[,] map;
        private bool[,] seem;
        private List<int> enemies;
        private List<int> killedEnemyTurn;



        public State() {
            gameTurn = 0;
        }

        public void update(int act) {
            gameTurn++;
        }

        public int getGameTurn() {
            return gameTurn;
        }
    }
}
