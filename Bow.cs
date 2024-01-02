using System;
using System.Drawing;

namespace HF_DungeonQuest_lab_2
{
    class Bow : Weapon
    {

        public Bow(Game game, Point location)
            : base(game, location) {
            _range = 55;
        }

        public override string Name { get =>"Bow"; } 

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, _range, 1, random); //just like that. Simple.
        }
    }
}