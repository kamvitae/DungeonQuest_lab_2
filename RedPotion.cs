using System;
using System.Drawing;

namespace HF_DungeonQuest_lab_2
{
    internal class RedPotion : Weapon, IPotion
    {

        public RedPotion(Game game, Point location)
            : base(game, location) { }

        public override string Name { get => "Red potion"; } 
        public bool Used { get; private set; } = false;

        public override void Attack(Direction direction, Random random)
        {
            for (int i = 0; i < 10; i++)
                game.IncreasePlayerHealth(1, random);
           
            Used = true;
        }
    }
}