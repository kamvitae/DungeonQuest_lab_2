using System;
using System.Drawing;

namespace HF_DungeonQuest_lab_2
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
           : base(game, location, 6)
        {
            NearPlayerDistance += game.Level * 2;
        }
        public override void Move(Random random)
        {
            if (HitPoints >= 1)
            {
                Direction directionToMove;

                if (random.Next(0, 2) == 0)
                    directionToMove = (Direction)random.Next(0, 4);
                else
                    directionToMove = FindPlayerDirection(game.PlayerLocation);

                location = Move(directionToMove, game.Boundaries);

                if (NearPlayer())
                    game.HitPlayer(3, random);
            }
        }
    }
}