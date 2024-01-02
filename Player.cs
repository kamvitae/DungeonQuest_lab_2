using System;
using System.Drawing;
using System.Collections.Generic;

namespace HF_DungeonQuest_lab_2
{
    internal class Player : Mover
    {
        private Weapon _equippedWeapon;
        private List<Weapon> _inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in _inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }
        public int HitPoints { get; private set; }
        public Player(Game game, Point location)
            : base(game, location)
        {
            HitPoints = 10;
        }
        /// <summary>
        /// metody kontroli pól obiektu
        /// </summary>
        /// <param name="maxDamage"></param>
        /// <param name="random"></param>
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
            if (HitPoints > 10)
                HitPoints = 10;
        }
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in _inventory)
                if (weapon.Name == weaponName)
                    _equippedWeapon = weapon;
        }
        /// <summary>
        /// metody interakcji obiektu
        /// </summary>
        /// <param name="direction"></param>
        public void Move(Direction direction)
        {
            Weapon weapon = game.WeaponInRoom;
            location = Move(direction, game.Boundaries);
            if (!weapon.PickedUp)
            {
                if (weapon.Nearby(Location, 15))
                {
                    weapon.PickUpWeapon();
                    _inventory.Add(weapon);
                    if (_inventory.Count == 1)
                        Equip(weapon.Name);
                }
            }
        }
        internal void Attack(Direction direction, Random random)
        {
            if (_equippedWeapon != null)
            {
                _equippedWeapon.Attack(direction, random);

                if (_equippedWeapon is IPotion)
                {
                    _inventory.Remove(_equippedWeapon);
                    Equip("Sword"); ; // should equip sword (if ready) when potion is drinked
                }
            }
            else
                return;
        }
        internal Weapon CheckEquippedWeapon() =>  
            _equippedWeapon;
    }
}