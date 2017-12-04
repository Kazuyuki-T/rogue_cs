using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rogue_cui_cs_git
{
    class GameManager
    {
        State state;
        Player player;
        Rule rule;

        public GameManager() {

        }

        public void init() {
            state = new State();
            player = new Player();
            rule = new Rule();
        }

        public void run() {

        }
    }
}
