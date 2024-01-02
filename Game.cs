using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HF_DungeonQuest_lab_2
{
    class Game
    {
        private Player _player;
        public IEnumerable<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }
        public Point PlayerLocation { get => _player.Location; }
        public int PlayerHitPoints { get => _player.HitPoints; }
        public IEnumerable<string> PlayerWeapons { get => _player.Weapons; }

        public int Level { get; private set; } = 0;
        private Rectangle _boundaries;
        internal readonly int HowManyLvls = 8;

        ///określa dostępne pole gry (lochu)

        public Rectangle Boundaries { get => _boundaries; }
        public Game(Rectangle boundaries)
        {
            this._boundaries = boundaries;
            _player = new Player(this,
                    new Point(_boundaries.Left + 10, _boundaries.Top + 70));
        }
        private Point GetRandomLocation(Random random)
        {
            Point randomLocation =
              new Point(
                         _boundaries.Left +
                     random.Next(_boundaries.Width / 10 - _boundaries.Left / 10) * 10,
                         _boundaries.Top +
                     random.Next(_boundaries.Height / 10 - _boundaries.Top / 10) * 10);

            if (randomLocation != _player.Location) //z#helpabezpieczenie przed wylosowaniem obiektu w lokacji gracza. Clever?
                return randomLocation;
            else
               return GetRandomLocation(random);
        }

        /// <summary>
        /// metody zarządzania obiektami dziedziczącymi po Mover (gracz, wrogowie, przedmioty)
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="random"></param>
        public void Move(Direction direction, Random random)
        {                                                   ///wywoluje ruch gracza, następnie wrogów
            _player.Move(direction);
            //foreach (Enemy enemy in Enemies)
            //    enemy.Move(random);
        }
        public void Attack(Direction direction, Random random)
        {                                                   ///podobnie jak Move(), wywoluje metody ataku gracza, nastepnie ruch wrogow (atak wroga jest wbudowany w ruch) 
            _player.Attack(direction, random);
            //foreach (Enemy enemy in Enemies) // silenced with action-game-mode
            //    enemy.Move(random);
        }
        public void HitPlayer(int maxDamage, Random random) =>
            _player.Hit(maxDamage, random);

        public void Equip(string weaponName) =>
            _player.Equip(weaponName);

        public bool CheckPlayerInventory(string weaponName) =>
            _player.Weapons.Contains(weaponName);
        public void IncreasePlayerHealth(int health, Random random) =>
            _player.IncreaseHealth(health, random);
        /// generator kolejnych poziomów lochu.
        /// (losuje lokacje obiektow. Ich rodzaj jest w większości z góry określony)
        /// niestety na razie nie jestt możliwe stworzenie kilku takich samych obiektów pochoddnych od Mover
        ///   np. zaamiast new Bat() => new List<Bat>()  ??? 
        public void NewLevel(Random random)
        {
            Level++;
            switch (Level)
            {
                case 1:
                    Enemies = new List<Enemy>() {
                        new Bat(this, GetRandomLocation(random)) };
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));

                    break;
                case 2:
                    Enemies = new List<Enemy>() {
                        new Ghost(this, GetRandomLocation(random)) };
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));

                    break;
                case 3:
                    Enemies = new List<Enemy>() {
                        (new Ghoul(this, GetRandomLocation(random))) };

                    WeaponInRoom = new Bow(this, GetRandomLocation(random));

                    break;
                case 4:
                    Enemies = new List<Enemy>() {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random)) };

                    if (CheckPlayerInventory("Bow"))
                    {
                        if (CheckPlayerInventory("Blue Potion"))
                            break;

                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                        break;
                    }
                    else
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;

                case 5:
                    Enemies = new List<Enemy>() {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)) };

                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));

                    break;
                case 6:
                    Enemies = new List<Enemy>() {
                        new Ghost(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)) };

                    WeaponInRoom = new Mace(this, GetRandomLocation(random));

                    break;
                case 7:
                    Enemies = new List<Enemy>() {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)) };

                    if (CheckPlayerInventory("Mace"))
                    {
                        if (CheckPlayerInventory("Red Potion"))
                            break;

                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                        break;
                    }
                    else
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;

                case 8:
                    Enemies = new List<Enemy>(){
                        new Necromancer(this, GetRandomLocation(random))};
                    if (CheckPlayerInventory("Red Potion"))
                    {
                        if (CheckPlayerInventory("Blue Potion"))
                            break;

                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                        break;
                    }
                    else
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                default:
                    break;
            }
        }
        /// Dev help hotkeys and cheats
        public void ChangeLevel(int level) =>
            Level = level;
        public void ChangeWeaponInRoom(string weaponName)
        {
            Point closeToPlayer = new Point(PlayerLocation.X + 10, PlayerLocation.Y);
            switch (weaponName)
            {
                case "sword":
                    WeaponInRoom = new Sword(this, closeToPlayer);
                    break;
                case "bow":
                    WeaponInRoom = new Bow(this, closeToPlayer);
                    break;
                case "mace":
                    WeaponInRoom = new Mace(this, closeToPlayer);
                    break;
                case "bluepotion":
                    WeaponInRoom = new BluePotion(this, closeToPlayer);
                    break;
                case "redpotion":
                    WeaponInRoom = new RedPotion(this, closeToPlayer);
                    break;
                default:
                    break;
            }
        }
        public Direction checkPlayerAttackDirection(Point playerLocation, Point enemyLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > enemyLocation.X + 10)
                directionToMove = Direction.Left;
            else if (playerLocation.X < enemyLocation.X - 10)
                directionToMove = Direction.Right;
            else if (playerLocation.Y < enemyLocation.Y - 10)
                directionToMove = Direction.Down;
            else
                directionToMove = Direction.Up;
            return directionToMove;
        }

    }
}