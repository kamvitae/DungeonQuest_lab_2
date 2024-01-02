using System;
using System.Drawing;

namespace HF_DungeonQuest_lab_2
{
    internal class BluePotion : Weapon, IPotion
    {

        public BluePotion(Game game, Point location)
            : base(game, location) { }

        public override string Name { get { return "Blue potion"; } }

        public bool Used { get; private set; } = false; //brak praktycznych odniesień

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(6, random);
            Used = true;
        }
    }
}