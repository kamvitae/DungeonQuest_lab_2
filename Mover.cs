using System.Collections;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace HF_DungeonQuest_lab_2

{
    abstract class Mover
    {
        private const int _moveInterval = 10;
        protected Game game;
        protected Point location;
        public Point Location { get => location; }

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }
        /*
        The Nearby() method in the Mover class takes only two parameters,
    a Point and an int, 
    compares the Point to the current location, and
    returns true if the Point is near the location. 
        
        For the DamageEnemy calculation, you’ll need to 
    add an overloaded Nearby() method that
    compares two points and 
    returns true if they’re     +++ within the specified distance +++ 
        of each other. 
        
        You’ll also need an overloaded Move method to                   // why?
    move a Point in a direction and 
    return the new Point. 
        
        See if you can figure out how to 
    modify the Nearby() and Move() methods that we gave you so 
        that the overloaded methods don’t duplicate any code.
 */
        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance &&
                (Math.Abs(location.Y - locationToCheck.Y) < distance))
                return true;

            else
                return false;
        } // original method
        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - _moveInterval >= boundaries.Top)
                        newLocation.Y -= _moveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + _moveInterval <= boundaries.Height)
                        newLocation.Y += _moveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - _moveInterval >= boundaries.Left)
                        newLocation.X -= _moveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + _moveInterval <= boundaries.Right)
                        newLocation.X += _moveInterval;
                    break;

                default: break;
            }
            return newLocation;
        } // original method
        public bool Nearby(Point locationToCheck, Point target, int distance) //stosowany w class Weapon. porównaj dwa 
        {
            if (Math.Abs(target.X - locationToCheck.X) < distance &&
                (Math.Abs(target.Y - locationToCheck.Y) < distance))
                return true;                //this works, but copies too much code of original method
            
            else
                return false;

            //location = target; // is this really it?.
            //return (Nearby(locationToCheck, distance));

        } // my overload. Is it ok??
        public Point Move(Direction direction, Point target, Rectangle boundaries) //stosowany w class Weapon
        {
            Point newLocation = target;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - 1 >= boundaries.Top)
                        newLocation.Y -= 1;
                    break;
                case Direction.Down:
                    if (newLocation.Y + 1 <= boundaries.Height)
                        newLocation.Y += 1;
                    break;
                case Direction.Left:
                    if (newLocation.X - 1 >= boundaries.Left)
                        newLocation.X -= 1;
                    break;
                case Direction.Right:
                    if (newLocation.X + 1 <= boundaries.Right)
                        newLocation.X += 1;
                    break;

                default: break;
            }
            return newLocation;
        }
    }
}