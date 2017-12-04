using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rogue_cui_cs_git
{
    class GameManager
    {
        private State state;
        private Player player;
        private Rule rule;

        public GameManager() {
            state = new State();
            player = new Player();
            rule = new Rule();
        }

        public void init() {
            
        }

        public void run() {
            while (true) {
                player.setState();
                int act = player.getAction();
                state.update(act);

                if (state.getGameTurn() == 10) break;
            }

            System.Console.WriteLine("end");
        }
    }
}
