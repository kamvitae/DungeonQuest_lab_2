using System;
using System.Drawing;

namespace HF_DungeonQuest_lab_2
{
    class Ghost : Enemy
    {

        public Ghost(Game game, Point location)
            : base(game, location, 8)
        {
            NearPlayerDistance += game.Level * 3;
        }
        public override void Move(Random random)
        {
            if (HitPoints > 0)
            {
                if (random.Next(0, 3) == 0)
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);

                if (NearPlayer())
                    game.HitPlayer(4, random);
            }
        }
    }
}