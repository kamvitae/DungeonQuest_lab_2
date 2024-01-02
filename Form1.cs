using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HF_DungeonQuest_lab_2
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private List<PictureBox> _playerInventoryPBs = new List<PictureBox>();
        private List<PictureBox> _weaponsInRoomPBs = new List<PictureBox>();

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(88, 61, 527, 260));
            cheats = new Cheats(game, this); // Cheats are in separate file (Form1Cheats.cs)
            game.NewLevel(random);

            _playerInventoryPBs.AddRange(new List<PictureBox>() {
                picInventorySword, picInventoryBow, picInventoryMace, picInventoryBlue, picInventoryRed});  //listy picBox formularza. Zgrupowane dla wygodniejszej obsługi w metodzie (i skrócenia i tak już rozbudowanej metody) updateCharacters()
            _weaponsInRoomPBs.AddRange(new List<PictureBox>() {
               picSword, picBow, picMace, picBluePotion, picRedPotion});                                    //listy picBox formularza. Zgrupowane dla wygodniejszej obsługi w metodzie (i skrócenia i tak już rozbudowanej metody) updateCharacters()

            UpdateCharacters();
            timer1.Start();

        }
        /// <summary>
        ///  odświeżanie kontrolek formularza każdorazowo po wykonaniu akcji
        /// </summary>
        private void UpdateCharacters() // zbyt rozbudowana metoda?
        {
            ///pobranie lokacji i stanu gracza
            updatePlayerInfo();
            ///wyświetlanie przeciwników
            int enemiesShown = updateEnemies();
            ///wyświetlanie ikon znajdziek
            updateItemsInventory();
            checkVictoreDefeatConditions(enemiesShown);

            ///local functions
            void updatePlayerInfo()
            {
                picPlayer.Location = game.PlayerLocation;
                lblPlayerHP.Text = game.PlayerHitPoints.ToString() + "/10";
            }
            int updateEnemies()
            {
                bool showBat = false;
                bool showGhost = false;
                bool showGhoul = false;
                bool showNecromancer = false;
                int enemies = 0;
                ///wyświetlanie przeciwników
                foreach (Enemy enemy in game.Enemies)
                {
                    if (enemy is Bat)
                    {
                        picBat.Location = enemy.Location;
                        lblBatHP.Text = enemy.HitPoints.ToString();
                        if (enemy.HitPoints > 0)
                        {
                            showBat = true;
                            picBat.Visible = true;
                            enemies++;
                        }
                    }
                    if (enemy is Ghost)
                    {
                        picGhost.Location = enemy.Location;
                        lblGhostHP.Text = enemy.HitPoints.ToString();
                        if (enemy.HitPoints > 0)
                        {
                            showGhost = true;
                            picGhost.Visible = true;
                            enemies++;
                        }
                    }
                    if (enemy is Ghoul)
                    {
                        picGhoul.Location = enemy.Location;
                        lblGhoulHP.Text = enemy.HitPoints.ToString();
                        if (enemy.HitPoints > 0)
                        {
                            showGhoul = true;
                            picGhoul.Visible = true;
                            enemies++;
                        }
                    }
                    if (enemy is Necromancer)
                    {
                        picNecromancer.Location = enemy.Location;
                        lblNecroHp.Text = enemy.HitPoints.ToString();
                        if (enemy.HitPoints > 0)
                        {
                            showNecromancer = true;
                            picNecromancer.Visible = true;
                            enemies++;
                        }
                    }
                }
                if (!showBat)
                {
                    picBat.Visible = false;
                    lblBatHP.Text = "";
                }
                if (!showGhost)
                {
                    picGhost.Visible = false;
                    lblGhostHP.Text = "";
                }
                if (!showGhoul)
                {
                    picGhoul.Visible = false;
                    lblGhoulHP.Text = "";
                }
                if (!showNecromancer)
                {
                    picNecromancer.Visible = false;
                    lblNecroHp.Text = "";
                }

                return enemies;
            }
            void checkVictoreDefeatConditions(int enemies)
            {
                ///sprawdzenie warunku przegranej
                if (game.PlayerHitPoints <= 0)
                {
                    timer1.Stop();
                    MessageBox.Show("You have died!   (x_x)",
                        "GAME OVER");
                    Application.Exit();
                }
                /// sprawdzenie warunku ukonczenia poziomu
                if (enemies < 1)
                {
                    timer1.Stop();
                    MessageBox.Show("You have defeated your enemies here!\n " +
                                    "As you stray down deeper inside the dungeon, \n" +
                                    "you can hear, that more are coming.\n" +
                                    "Brace yoursef for another fight!           (o_o)",
                                        "Level cleared");
                    if (game.Level <= game.HowManyLvls)
                    {
                        game.NewLevel(random);
                        UpdateCharacters();
                        timer1.Start();
                    }
                    else
                    {
                        timer1.Stop();
                        MessageBox.Show("You have Cleared this dungeon!\n " +
                                    "Exhausted, you collect treasures they left \n" +
                                    "and leave this cursed place.\n" +
                                    "           VICTORY!           (o_o)",
                        "You have won.");
                        Application.Exit();
                    }
                }
                ///zmiana tytułu formularza
                Text = "Simple Dungeon - level#" + game.Level.ToString();
            }
            void updateItemsInventory()
            {
                ///wyświetlanie ikon znajdziek
                foreach (PictureBox pbWeaponInDungeon in _weaponsInRoomPBs)
                    pbWeaponInDungeon.Visible = false;
                Control weaponControl = null;
                switch (game.WeaponInRoom.Name)
                {
                    case "Sword":
                        weaponControl = picSword; break;
                    case "Bow":
                        weaponControl = picBow; break;
                    case "Mace":
                        weaponControl = picMace; break;
                    case "Blue potion":
                        weaponControl = picBluePotion; break;
                    case "Red potion":
                        weaponControl = picRedPotion; break;
                    default:
                        break;
                }
                weaponControl.Visible = true;
                ///wyświetlanie ikon ekwipunku
                foreach (PictureBox pbItemInPlayerInventory in _playerInventoryPBs)
                    pbItemInPlayerInventory.Visible = false;
                Control inventoryControl = null;
                foreach (string weaponName in game.PlayerWeapons)
                {
                    if (game.CheckPlayerInventory(weaponName))
                    {
                        switch (weaponName)
                        {
                            case "Sword":
                                inventoryControl = picInventorySword; break;
                            case "Bow":
                                inventoryControl = picInventoryBow; break;
                            case "Mace":
                                inventoryControl = picInventoryMace; break;
                            case "Blue potion":
                                inventoryControl = picInventoryBlue; break;
                            case "Red potion":
                                inventoryControl = picInventoryRed; break;
                            default:
                                break;
                        }
                        inventoryControl.Visible = true;
                    }
                }
                ///sprawdzanie stanu znajdzki (podniesiona/na ziemi)
                weaponControl.Location = game.WeaponInRoom.Location;
                if (game.WeaponInRoom.PickedUp)
                    weaponControl.Visible = false;
                else
                    weaponControl.Visible = true;
                ///chwycenie za miecz po wypiciu mikstury
                int count = 0;
                foreach (PictureBox invPic in _playerInventoryPBs)
                    if (invPic.BorderStyle == BorderStyle.FixedSingle
                        && invPic.Visible)
                        count++;
                if (count == 0)
                    picInventorySword.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        /// <summary>
        ///  kontrola ruchu gracza. wyciszona ---> obsługa aktywna pod btnMove_Down i btnMove_Up (wraz z timerem)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private delegate void movePlayerDelegate(Direction direction, Random random); //przypisanie metody delegacji. Nie podajemy parametrów - te muszą się zgadzać

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            //game.Move(Direction.Up, random);
            //UpdateCharacters();
        }
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            //game.Move(Direction.Down, random);
            //UpdateCharacters();
        }
        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            //game.Move(Direction.Left, random);
            //UpdateCharacters();
        }
        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            //game.Move(Direction.Right, random);
            //UpdateCharacters();
        }
        /// <summary>
        ///  kontrola ataku gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttackUp_Click(object sender, EventArgs e)
        {
            game.Attack((Direction)0, random);
            //UpdateCharacters();
            switchToAtttack();
        }

        private void btnAttackDown_Click(object sender, EventArgs e)
        {
            game.Attack((Direction)1, random);
            //UpdateCharacters();
        }

        private void btnAttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack((Direction)2, random);
            //UpdateCharacters();
        }

        private void btnAttackRight_Click(object sender, EventArgs e)
        {
            game.Attack((Direction)3, random);
            //UpdateCharacters();
        }
        /// <summary>
        /// zmiana trzymanego przez gracza ekwipunku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picInventorySword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                picInventorySword.BorderStyle = BorderStyle.FixedSingle;
                picInventoryBow.BorderStyle = BorderStyle.None;
                picInventoryMace.BorderStyle = BorderStyle.None;
                picInventoryBlue.BorderStyle = BorderStyle.None;
                picInventoryRed.BorderStyle = BorderStyle.None;
            }
            switchToAtttack();
        }

        private void picInventoryBow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                picInventoryBow.BorderStyle = BorderStyle.FixedSingle;
                picInventorySword.BorderStyle = BorderStyle.None;
                picInventoryMace.BorderStyle = BorderStyle.None;
                picInventoryBlue.BorderStyle = BorderStyle.None;
                picInventoryRed.BorderStyle = BorderStyle.None;
            }
            switchToAtttack();
        }

        private void picInventoryMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                picInventoryMace.BorderStyle = BorderStyle.FixedSingle;
                picInventorySword.BorderStyle = BorderStyle.None;
                picInventoryBow.BorderStyle = BorderStyle.None;
                picInventoryBlue.BorderStyle = BorderStyle.None;
                picInventoryRed.BorderStyle = BorderStyle.None;
            }
            switchToAtttack();
        }

        private void picInventoryBlue_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue potion"))
            {
                game.Equip("Blue potion");
                picInventoryBlue.BorderStyle = BorderStyle.FixedSingle;
                picInventorySword.BorderStyle = BorderStyle.None;
                picInventoryBow.BorderStyle = BorderStyle.None;
                picInventoryMace.BorderStyle = BorderStyle.None;
                picInventoryRed.BorderStyle = BorderStyle.None;
                switchToDrink();
            }
        }
        private void picInventoryRed_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red potion"))
            {
                game.Equip("Red potion");
                picInventoryRed.BorderStyle = BorderStyle.FixedSingle;
                picInventorySword.BorderStyle = BorderStyle.None;
                picInventoryBow.BorderStyle = BorderStyle.None;
                picInventoryMace.BorderStyle = BorderStyle.None;
                picInventoryBlue.BorderStyle = BorderStyle.None;

                switchToDrink();
            }
        }
        /// <summary>
        /// short simple methods made to avoid repeating code between other methods with simillar functionality
        /// </summary>
        private void switchToDrink()
        {
            grboxAttack.Text = "Drink potion";
            btnAttackLeft.Enabled = false;
            btnAttackRight.Enabled = false;
            btnAttackDown.Enabled = false;
        }
        private void switchToAtttack()
        {
            if (grboxAttack.Text == "Drink potion")
            {
                grboxAttack.Text = "Attack";
                btnAttackLeft.Enabled = true;
                btnAttackRight.Enabled = true;
                btnAttackDown.Enabled = true;
                picInventoryBlue.BorderStyle = BorderStyle.None;
            }
        }

        /// <summary>
        /// Action-game funcionality. Timer control & mouseDown events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private Direction moveDirection;
        private bool isKeyOrMouseDown = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game.PlayerHitPoints > 0
                && isKeyOrMouseDown)
            {
                movePlayerDelegate movePlayer = game.Move; //delegat. niby niepotrzebny ale chciałem sobie przypomnieć trochę
                movePlayer(moveDirection, random);
                UpdateCharacters();
                moveEnemies();
            }
            else
            {
                UpdateCharacters();
                moveEnemies();
            }
            void moveEnemies()
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (enemy is Bat)
                    {
                        picBat.Location = enemy.Location;
                        enemy.Move(random);
                    }
                    else if (enemy is Ghost)
                    {
                        picGhost.Location = enemy.Location;
                        enemy.Move(random);
                    }
                    else if (enemy is Ghoul)
                    {
                        picGhoul.Location = enemy.Location;
                        enemy.Move(random);
                    }
                    else if (enemy is Necromancer)
                    {
                        picNecromancer.Location = enemy.Location;
                        enemy.Move(random);
                    }
                }
            }
        }
        private void btnMoveUp_MouseDown(object sender, MouseEventArgs e)
        {
            isKeyOrMouseDown = true;
            moveDirection = Direction.Up;
            UpdateCharacters();
        }
        private void btnMoveUp_MouseUp(object sender, MouseEventArgs e)
        {

            isKeyOrMouseDown = false;
            UpdateCharacters();
        }
        private void btnMoveDown_MouseDown(object sender, MouseEventArgs e)
        {

            isKeyOrMouseDown = true;
            moveDirection = Direction.Down;
            UpdateCharacters();
        }
        private void btnMoveDown_MouseUp(object sender, MouseEventArgs e)
        {

            isKeyOrMouseDown = false;
            UpdateCharacters();
        }
        private void btnMoveRight_MouseDown(object sender, MouseEventArgs e)
        {

            isKeyOrMouseDown = true;
            moveDirection = Direction.Right;
            UpdateCharacters();
        }
        private void btnMoveRight_MouseUp(object sender, MouseEventArgs e)
        {

            isKeyOrMouseDown = false;
            UpdateCharacters();
        }
        private void btnMoveLeft_MouseDown(object sender, MouseEventArgs e)
        {

            isKeyOrMouseDown = true;
            moveDirection = Direction.Left;
            UpdateCharacters();
        }
        private void btnMoveLeft_MouseUp(object sender, MouseEventArgs e)
        {
            isKeyOrMouseDown = false;
            UpdateCharacters();
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            else if (!timer1.Enabled)
                timer1.Start();
        }

        ///key control functions
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            isKeyOrMouseDown = true;
            switch (e.KeyChar)
            {
                case ' ':
                    if (timer1.Enabled)
                        timer1.Stop();
                    else if (!timer1.Enabled)
                        timer1.Start();
                    break;
                case 'w':
                    moveDirection = Direction.Up;
                    break;
                case 's':
                    moveDirection = Direction.Down;
                    break;
                case 'a':
                    moveDirection = Direction.Left;
                    break;
                case 'd':
                    moveDirection = Direction.Right;
                    break;
                default:
                    break;
            }
            UpdateCharacters();

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            isKeyOrMouseDown = false;
        }

        private void picBat_Click(object sender, EventArgs e)
        {
            game.Attack(game.checkPlayerAttackDirection(
                game.PlayerLocation, picBat.Location), random);
        }

        private void picGhost_Click(object sender, EventArgs e)
        {
            game.Attack(game.checkPlayerAttackDirection(
                game.PlayerLocation, picGhost.Location), random);
        }

        private void picGhoul_Click(object sender, EventArgs e)
        {
            game.Attack(game.checkPlayerAttackDirection(
                game.PlayerLocation, picGhoul.Location), random);
        }

        private void picNecromancer_Click(object sender, EventArgs e)
        {
            game.Attack(game.checkPlayerAttackDirection(
                game.PlayerLocation, picNecromancer.Location), random);
        }


        //private void btnMoveDown_MouseDown(object sender, MouseEventArgs e)
        //{ /*opcja poruszania za pomocą przytrzymanego przycisku. Zadanie dodatkowe - zamienić na grę akcji */
        //    while (true)
        //    {
        //        btnMoveDown_Click(sender, e);
        //    }
        //}

    }
}
