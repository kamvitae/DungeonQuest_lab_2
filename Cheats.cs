using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_DungeonQuest_lab_2
{
    class Cheats
    {
        private Game _game;
        private Form1 _form;
        private Player _player;
        public bool enabled = false;
        public Cheats(Game game, Form1 form)
        {
            _game = game;
            _form = form;
        }
    }
}
