using System;
using System.Drawing;

namespace HF_DungeonQuest_lab_2
{
    internal class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        {
            NearPlayerDistance += game.Level * 2;
        }
        public override void Move(Random random)
        {
            if (HitPoints > 0)
            {
                if (random.Next(0, 3) < 2)
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);

                if (NearPlayer())
                    game.HitPlayer(5, random);
            }
        }
    }
}