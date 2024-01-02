using System;
using System.Drawing;


namespace HF_DungeonQuest_lab_2
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }
        public Weapon(Game game, Point location)
            : base(game, location)
        {
            PickedUp = false;
        }
        protected int _range { get; set; } 
        public void PickUpWeapon() { PickedUp = true; }
        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);
        protected bool DamageEnemy(Direction direction, int radius,
                                    int damage, Random random )
        {
            Point target = game.PlayerLocation; // początkowy cel. Zaczynamy sprawdzanie od lokacji gracza
            for (int distance = 0; distance <= radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                    if (Nearby(enemy.Location, target, distance)) //przeciążenie
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
            target = Move(direction, target, game.Boundaries); // przeciążenie. Jeśli nie trafi -> przesuwamy lekko target w strone przeciwnika 
            }
            return false;
        }
    }
}
/*
 The Nearby() method in the Mover class takes only two parameters,
a Point and an int, compares the Point to the current location, and
returns true if the Point is near the location. For the DamageEnemy
calculation, you’ll need to add an overloaded Nearby() method that
compares two points and returns true if they’re within the specified
distance of each other. You’ll also need an overloaded Move method to
move a Point in a direction and return the new Point. See if you can
figure out how to modify the Nearby() and Move() methods that we
gave you so that the overloaded methods don’t duplicate any code.
 */