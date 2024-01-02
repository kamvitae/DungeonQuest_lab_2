using System;
using System.Drawing;

namespace HF_DungeonQuest_lab_2
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location)
            : base(game, location) {
            _range = 20;
        }

        public override string Name { get =>"Sword"; } 

        public override void Attack(Direction direction, Random random)
        {
            for (int i = 0; i <= 2; i++)
            {
                //jeśli trafi przeciwnika - przerywa
                if (DamageEnemy(direction, _range, 1, random))
                {
                    DamageEnemy(direction, _range, 1, random);
                    DamageEnemy(direction, _range, 1, random);
                    break;
                }
                //jeśli nie - zmienia kierunek ataku
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