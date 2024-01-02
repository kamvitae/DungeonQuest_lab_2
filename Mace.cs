using System;
using System.Drawing;

namespace HF_DungeonQuest_lab_2
{
    internal class Mace : Weapon
    {

        public Mace(Game game, Point location)
            : base(game, location)
        {
            _range = 35;
        }

        public override string Name { get =>"Mace"; }

        public override void Attack(Direction direction, Random random)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (DamageEnemy(direction,_range, 7, random))
                    break;
               
                else if (direction == Direction.Up)
                    direction = Direction.Right;                
                else if (direction == Direction.Right)
                    direction = Direction.Down;
                else if (direction == Direction.Down)
                    direction = Direction.Left;
                else
                    direction = Direction.Up;
            }
        }
    }
}