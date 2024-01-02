using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_DungeonQuest_lab_2
{
    class Necromancer : Enemy
    {
        public Necromancer(Game game, Point location)
           : base(game, location, 8)
        {
            NearPlayerDistance += game.Level * 4;  // on lvl#8 should be 50
        }
        public override void Move(Random random)
        {
            if (HitPoints > 0)
            {
                Direction directionToMove
                    = FindPlayerDirection(game.PlayerLocation);

                if (NearPlayer())
                {
                    game.HitPlayer(3, random);
                    drainHealth();
                    int randomMove = random.Next(0, 2);
                    if (randomMove != 0)
                        location = Move(escapePlayerDirection(directionToMove), game.Boundaries);
                }
                else
                {
                    location = Move(directionToMove, game.Boundaries);
                    if (NearPlayer())
                        game.HitPlayer(3, random);
                }
            }
        }
        private Direction escapePlayerDirection(Direction playerLocation)
        {
            if (playerLocation == Direction.Up)
                return Direction.Down;
            else if (playerLocation == Direction.Down)
                return Direction.Up;
            else if (playerLocation == Direction.Left)
                return Direction.Right;
            else
                return Direction.Left;
        }
        private Enemy summon(Enemy summonedEnemy)//not ready yet
        {
            return summonedEnemy;
        }
        protected void drainHealth() =>
            HitPoints++;

    }
}
