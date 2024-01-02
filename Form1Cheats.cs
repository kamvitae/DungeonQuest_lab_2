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
        private Cheats cheats; // my addition. dev tool to speed up debugging (no need to click maaaaany times to move on)

        /// <summary>
        /// cheats  controls. Not ready to work yet :(
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCheats_CheckedChanged(object sender, EventArgs e)
        {
            if (!cheats.enabled)
                enableCheats();
            else
                disableCheats();
        }

        private void disableCheats()
        {
            cheats.enabled = false;
            MessageBox.Show(this, "Cheats DISABLED", "info");
            tbCheats.Enabled = false;
            listBoxLevel.Enabled = false;
        }
        private void enableCheats()
        {
            cheats.enabled = true;
            MessageBox.Show(this, "Cheats ENABLED", "info");
            tbCheats.Enabled = true;
            listBoxLevel.Enabled = true;
        }
        private void tbCheats_TextChanged(object sender, EventArgs e) => game.ChangeWeaponInRoom(tbCheats.Text.ToLower());
        private void tbCheats_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &&
                tbCheats.Enabled == true)
                UpdateCharacters();
        }
        private void listBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxLevel.SelectedIndex)
            {//NewLevel()  firsts increments Level field then generatte new level
                case 0:
                    game.ChangeLevel(0);
                    game.NewLevel(random);
                    UpdateCharacters();
                    break;
                case 1:
                    game.ChangeLevel(1);
                    game.NewLevel(random);
                    UpdateCharacters();
                    break;
                case 2:
                    game.ChangeLevel(2);
                    game.NewLevel(random);
                    UpdateCharacters();
                    break;
                case 3:
                    game.ChangeLevel(3);
                    game.NewLevel(random);
                    UpdateCharacters();
                    break;
                case 4:
                    game.ChangeLevel(4);
                    game.NewLevel(random);
                    UpdateCharacters();
                    break;
                case 5:
                    game.ChangeLevel(5);
                    game.NewLevel(random);
                    UpdateCharacters();
                    break;
                case 6:
                    game.ChangeLevel(6);
                    game.NewLevel(random);
                    UpdateCharacters();
                    break;
                case 7:
                    game.ChangeLevel(7);
                    game.NewLevel(random);
                    UpdateCharacters();
                    break;
                default:
                    break;
            }
        }
    }
}
