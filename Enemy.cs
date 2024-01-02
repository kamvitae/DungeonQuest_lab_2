using System;
using System.Drawing;

namespace HF_DungeonQuest_lab_2
{
    abstract class Enemy : Mover
    {
        protected int NearPlayerDistance { get;  set; } = 5;//should be 10
        public int HitPoints { get; protected set; }
        public bool Dead { get {
                if (HitPoints  <= 0)
                    return true;
                else return false;}
        }
        public Enemy(Game game, Point location, int hitPoints)
            :base(game, location)
        {
            HitPoints = hitPoints;
        }
        protected bool NearPlayer() => 
            (Nearby(game.PlayerLocation, NearPlayerDistance));
        protected Direction FindPlayerDirection (Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;
            return directionToMove;
        }
        public abstract void Move(Random random); // stosujac abstrakt wymuszamy na klasach pochodnych implementacje takiego przexsloniecia metody Move
        public void Hit(int maxDamage, Random random) =>
            HitPoints -= random.Next(1, maxDamage);
        
    }
}