namespace HF_DungeonQuest_lab_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picBat = new System.Windows.Forms.PictureBox();
            this.picGhoul = new System.Windows.Forms.PictureBox();
            this.picGhost = new System.Windows.Forms.PictureBox();
            this.picBow = new System.Windows.Forms.PictureBox();
            this.picSword = new System.Windows.Forms.PictureBox();
            this.picRedPotion = new System.Windows.Forms.PictureBox();
            this.picBluePotion = new System.Windows.Forms.PictureBox();
            this.picMace = new System.Windows.Forms.PictureBox();
            this.tlpHitPoints = new System.Windows.Forms.TableLayoutPanel();
            this.lblNecroHp = new System.Windows.Forms.Label();
            this.lblNecro = new System.Windows.Forms.Label();
            this.lblBat = new System.Windows.Forms.Label();
            this.lblGhost = new System.Windows.Forms.Label();
            this.lblGhoul = new System.Windows.Forms.Label();
            this.lblBatHP = new System.Windows.Forms.Label();
            this.lblGhostHP = new System.Windows.Forms.Label();
            this.lblGhoulHP = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.grboxMove = new System.Windows.Forms.GroupBox();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.grboxAttack = new System.Windows.Forms.GroupBox();
            this.btnAttackUp = new System.Windows.Forms.Button();
            this.btnAttackLeft = new System.Windows.Forms.Button();
            this.btnAttackDown = new System.Windows.Forms.Button();
            this.btnAttackRight = new System.Windows.Forms.Button();
            this.picInventoryMace = new System.Windows.Forms.PictureBox();
            this.picInventoryBow = new System.Windows.Forms.PictureBox();
            this.picInventorySword = new System.Windows.Forms.PictureBox();
            this.picInventoryRed = new System.Windows.Forms.PictureBox();
            this.picInventoryBlue = new System.Windows.Forms.PictureBox();
            this.tbCheats = new System.Windows.Forms.TextBox();
            this.picNecromancer = new System.Windows.Forms.PictureBox();
            this.cbCheats = new System.Windows.Forms.CheckBox();
            this.listBoxLevel = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).BeginInit();
            this.tlpHitPoints.SuspendLayout();
            this.grboxMove.SuspendLayout();
            this.grboxAttack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventorySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNecromancer)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPlayer.Image = global::HF_DungeonQuest_lab_2.Properties.Resources.player;
            this.picPlayer.InitialImage = null;
            this.picPlayer.Location = new System.Drawing.Point(117, 75);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(40, 37);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picBat
            // 
            this.picBat.BackColor = System.Drawing.Color.Transparent;
            this.picBat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBat.Image = global::HF_DungeonQuest_lab_2.Properties.Resources.bat;
            this.picBat.Location = new System.Drawing.Point(327, 305);
            this.picBat.Margin = new System.Windows.Forms.Padding(4);
            this.picBat.Name = "picBat";
            this.picBat.Size = new System.Drawing.Size(40, 37);
            this.picBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBat.TabIndex = 1;
            this.picBat.TabStop = false;
            this.picBat.Visible = false;
            this.picBat.Click += new System.EventHandler(this.picBat_Click);
            // 
            // picGhoul
            // 
            this.picGhoul.BackColor = System.Drawing.Color.Transparent;
            this.picGhoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picGhoul.Image = ((System.Drawing.Image)(resources.GetObject("picGhoul.Image")));
            this.picGhoul.Location = new System.Drawing.Point(423, 305);
            this.picGhoul.Margin = new System.Windows.Forms.Padding(4);
            this.picGhoul.Name = "picGhoul";
            this.picGhoul.Size = new System.Drawing.Size(40, 37);
            this.picGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhoul.TabIndex = 3;
            this.picGhoul.TabStop = false;
            this.picGhoul.Visible = false;
            this.picGhoul.Click += new System.EventHandler(this.picGhoul_Click);
            // 
            // picGhost
            // 
            this.picGhost.BackColor = System.Drawing.Color.Transparent;
            this.picGhost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picGhost.Image = global::HF_DungeonQuest_lab_2.Properties.Resources.ghost;
            this.picGhost.Location = new System.Drawing.Point(375, 305);
            this.picGhost.Margin = new System.Windows.Forms.Padding(4);
            this.picGhost.Name = "picGhost";
            this.picGhost.Size = new System.Drawing.Size(40, 37);
            this.picGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhost.TabIndex = 2;
            this.picGhost.TabStop = false;
            this.picGhost.Visible = false;
            this.picGhost.Click += new System.EventHandler(this.picGhost_Click);
            // 
            // picBow
            // 
            this.picBow.BackColor = System.Drawing.Color.Transparent;
            this.picBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBow.Image = global::HF_DungeonQuest_lab_2.Properties.Resources.bow;
            this.picBow.Location = new System.Drawing.Point(471, 90);
            this.picBow.Margin = new System.Windows.Forms.Padding(4);
            this.picBow.Name = "picBow";
            this.picBow.Size = new System.Drawing.Size(40, 37);
            this.picBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBow.TabIndex = 7;
            this.picBow.TabStop = false;
            this.picBow.Visible = false;
            // 
            // picSword
            // 
            this.picSword.BackColor = System.Drawing.Color.Transparent;
            this.picSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSword.Image = ((System.Drawing.Image)(resources.GetObject("picSword.Image")));
            this.picSword.Location = new System.Drawing.Point(423, 90);
            this.picSword.Margin = new System.Windows.Forms.Padding(4);
            this.picSword.Name = "picSword";
            this.picSword.Size = new System.Drawing.Size(40, 37);
            this.picSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSword.TabIndex = 6;
            this.picSword.TabStop = false;
            this.picSword.Visible = false;
            // 
            // picRedPotion
            // 
            this.picRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.picRedPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picRedPotion.Image = ((System.Drawing.Image)(resources.GetObject("picRedPotion.Image")));
            this.picRedPotion.Location = new System.Drawing.Point(375, 90);
            this.picRedPotion.Margin = new System.Windows.Forms.Padding(4);
            this.picRedPotion.Name = "picRedPotion";
            this.picRedPotion.Size = new System.Drawing.Size(40, 37);
            this.picRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedPotion.TabIndex = 5;
            this.picRedPotion.TabStop = false;
            this.picRedPotion.Visible = false;
            // 
            // picBluePotion
            // 
            this.picBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.picBluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBluePotion.Image = ((System.Drawing.Image)(resources.GetObject("picBluePotion.Image")));
            this.picBluePotion.Location = new System.Drawing.Point(327, 90);
            this.picBluePotion.Margin = new System.Windows.Forms.Padding(4);
            this.picBluePotion.Name = "picBluePotion";
            this.picBluePotion.Size = new System.Drawing.Size(40, 37);
            this.picBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBluePotion.TabIndex = 4;
            this.picBluePotion.TabStop = false;
            this.picBluePotion.Visible = false;
            // 
            // picMace
            // 
            this.picMace.BackColor = System.Drawing.Color.Transparent;
            this.picMace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMace.Image = global::HF_DungeonQuest_lab_2.Properties.Resources.mace;
            this.picMace.Location = new System.Drawing.Point(519, 90);
            this.picMace.Margin = new System.Windows.Forms.Padding(4);
            this.picMace.Name = "picMace";
            this.picMace.Size = new System.Drawing.Size(40, 37);
            this.picMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMace.TabIndex = 8;
            this.picMace.TabStop = false;
            this.picMace.Visible = false;
            // 
            // tlpHitPoints
            // 
            this.tlpHitPoints.AutoSize = true;
            this.tlpHitPoints.BackColor = System.Drawing.Color.Transparent;
            this.tlpHitPoints.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpHitPoints.ColumnCount = 2;
            this.tlpHitPoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.96227F));
            this.tlpHitPoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.03773F));
            this.tlpHitPoints.Controls.Add(this.lblNecroHp, 1, 3);
            this.tlpHitPoints.Controls.Add(this.lblNecro, 0, 3);
            this.tlpHitPoints.Controls.Add(this.lblBat, 0, 0);
            this.tlpHitPoints.Controls.Add(this.lblGhost, 0, 1);
            this.tlpHitPoints.Controls.Add(this.lblGhoul, 0, 2);
            this.tlpHitPoints.Controls.Add(this.lblBatHP, 1, 0);
            this.tlpHitPoints.Controls.Add(this.lblGhostHP, 1, 1);
            this.tlpHitPoints.Controls.Add(this.lblGhoulHP, 1, 2);
            this.tlpHitPoints.Location = new System.Drawing.Point(681, 346);
            this.tlpHitPoints.Margin = new System.Windows.Forms.Padding(4);
            this.tlpHitPoints.Name = "tlpHitPoints";
            this.tlpHitPoints.RowCount = 4;
            this.tlpHitPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHitPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHitPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHitPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHitPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHitPoints.Size = new System.Drawing.Size(295, 83);
            this.tlpHitPoints.TabIndex = 14;
            // 
            // lblNecroHp
            // 
            this.lblNecroHp.AutoSize = true;
            this.lblNecroHp.BackColor = System.Drawing.Color.Transparent;
            this.lblNecroHp.Location = new System.Drawing.Point(104, 61);
            this.lblNecroHp.Name = "lblNecroHp";
            this.lblNecroHp.Size = new System.Drawing.Size(110, 17);
            this.lblNecroHp.TabIndex = 25;
            this.lblNecroHp.Text = "necromancerHP";
            // 
            // lblNecro
            // 
            this.lblNecro.AutoSize = true;
            this.lblNecro.BackColor = System.Drawing.Color.Transparent;
            this.lblNecro.Location = new System.Drawing.Point(4, 61);
            this.lblNecro.Name = "lblNecro";
            this.lblNecro.Size = new System.Drawing.Size(93, 17);
            this.lblNecro.TabIndex = 24;
            this.lblNecro.Text = "Necromancer";
            // 
            // lblBat
            // 
            this.lblBat.AutoSize = true;
            this.lblBat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBat.Location = new System.Drawing.Point(5, 1);
            this.lblBat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBat.Name = "lblBat";
            this.lblBat.Size = new System.Drawing.Size(91, 19);
            this.lblBat.TabIndex = 1;
            this.lblBat.Text = "Bat";
            // 
            // lblGhost
            // 
            this.lblGhost.AutoSize = true;
            this.lblGhost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGhost.Location = new System.Drawing.Point(5, 21);
            this.lblGhost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhost.Name = "lblGhost";
            this.lblGhost.Size = new System.Drawing.Size(91, 19);
            this.lblGhost.TabIndex = 2;
            this.lblGhost.Text = "Ghost";
            // 
            // lblGhoul
            // 
            this.lblGhoul.AutoSize = true;
            this.lblGhoul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGhoul.Location = new System.Drawing.Point(5, 41);
            this.lblGhoul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhoul.Name = "lblGhoul";
            this.lblGhoul.Size = new System.Drawing.Size(91, 19);
            this.lblGhoul.TabIndex = 3;
            this.lblGhoul.Text = "Ghoul";
            // 
            // lblBatHP
            // 
            this.lblBatHP.AutoSize = true;
            this.lblBatHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBatHP.Location = new System.Drawing.Point(105, 1);
            this.lblBatHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatHP.Name = "lblBatHP";
            this.lblBatHP.Size = new System.Drawing.Size(185, 19);
            this.lblBatHP.TabIndex = 6;
            this.lblBatHP.Text = "batHP";
            // 
            // lblGhostHP
            // 
            this.lblGhostHP.AutoSize = true;
            this.lblGhostHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGhostHP.Location = new System.Drawing.Point(105, 21);
            this.lblGhostHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhostHP.Name = "lblGhostHP";
            this.lblGhostHP.Size = new System.Drawing.Size(185, 19);
            this.lblGhostHP.TabIndex = 7;
            this.lblGhostHP.Text = "ghostHP";
            // 
            // lblGhoulHP
            // 
            this.lblGhoulHP.AutoSize = true;
            this.lblGhoulHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGhoulHP.Location = new System.Drawing.Point(105, 41);
            this.lblGhoulHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhoulHP.Name = "lblGhoulHP";
            this.lblGhoulHP.Size = new System.Drawing.Size(185, 19);
            this.lblGhoulHP.TabIndex = 8;
            this.lblGhoulHP.Text = "ghoulHP";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Location = new System.Drawing.Point(95, 369);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(48, 17);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player";
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerHP.Location = new System.Drawing.Point(151, 369);
            this.lblPlayerHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(66, 17);
            this.lblPlayerHP.TabIndex = 5;
            this.lblPlayerHP.Text = "playerHP";
            // 
            // grboxMove
            // 
            this.grboxMove.BackColor = System.Drawing.Color.Transparent;
            this.grboxMove.Controls.Add(this.btnMoveUp);
            this.grboxMove.Controls.Add(this.btnMoveLeft);
            this.grboxMove.Controls.Add(this.btnMoveDown);
            this.grboxMove.Controls.Add(this.btnMoveRight);
            this.grboxMove.Location = new System.Drawing.Point(543, 437);
            this.grboxMove.Margin = new System.Windows.Forms.Padding(4);
            this.grboxMove.Name = "grboxMove";
            this.grboxMove.Padding = new System.Windows.Forms.Padding(4);
            this.grboxMove.Size = new System.Drawing.Size(135, 129);
            this.grboxMove.TabIndex = 15;
            this.grboxMove.TabStop = false;
            this.grboxMove.Text = "Move";
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(44, 20);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(45, 42);
            this.btnMoveUp.TabIndex = 3;
            this.btnMoveUp.Text = "↑";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            this.btnMoveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveUp_MouseDown);
            this.btnMoveUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMoveUp_MouseUp);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(0, 42);
            this.btnMoveLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(45, 42);
            this.btnMoveLeft.TabIndex = 2;
            this.btnMoveLeft.Text = "←";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            this.btnMoveLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveLeft_MouseDown);
            this.btnMoveLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMoveLeft_MouseUp);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(44, 69);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(45, 42);
            this.btnMoveDown.TabIndex = 1;
            this.btnMoveDown.Text = "↓";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            this.btnMoveDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveDown_MouseDown);
            this.btnMoveDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMoveDown_MouseUp);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(88, 42);
            this.btnMoveRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(45, 42);
            this.btnMoveRight.TabIndex = 0;
            this.btnMoveRight.Text = "→";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            this.btnMoveRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMoveRight_MouseDown);
            this.btnMoveRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMoveRight_MouseUp);
            // 
            // grboxAttack
            // 
            this.grboxAttack.BackColor = System.Drawing.Color.Transparent;
            this.grboxAttack.Controls.Add(this.btnAttackUp);
            this.grboxAttack.Controls.Add(this.btnAttackLeft);
            this.grboxAttack.Controls.Add(this.btnAttackDown);
            this.grboxAttack.Controls.Add(this.btnAttackRight);
            this.grboxAttack.Location = new System.Drawing.Point(711, 437);
            this.grboxAttack.Margin = new System.Windows.Forms.Padding(4);
            this.grboxAttack.Name = "grboxAttack";
            this.grboxAttack.Padding = new System.Windows.Forms.Padding(4);
            this.grboxAttack.Size = new System.Drawing.Size(135, 129);
            this.grboxAttack.TabIndex = 16;
            this.grboxAttack.TabStop = false;
            this.grboxAttack.Text = "Attack";
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.Location = new System.Drawing.Point(44, 20);
            this.btnAttackUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(45, 42);
            this.btnAttackUp.TabIndex = 3;
            this.btnAttackUp.Text = "↑";
            this.btnAttackUp.UseVisualStyleBackColor = true;
            this.btnAttackUp.Click += new System.EventHandler(this.btnAttackUp_Click);
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.Location = new System.Drawing.Point(-1, 42);
            this.btnAttackLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(45, 42);
            this.btnAttackLeft.TabIndex = 2;
            this.btnAttackLeft.Text = "←";
            this.btnAttackLeft.UseVisualStyleBackColor = true;
            this.btnAttackLeft.Click += new System.EventHandler(this.btnAttackLeft_Click);
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.Location = new System.Drawing.Point(44, 69);
            this.btnAttackDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(45, 42);
            this.btnAttackDown.TabIndex = 1;
            this.btnAttackDown.Text = "↓";
            this.btnAttackDown.UseVisualStyleBackColor = true;
            this.btnAttackDown.Click += new System.EventHandler(this.btnAttackDown_Click);
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.Location = new System.Drawing.Point(88, 42);
            this.btnAttackRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(45, 42);
            this.btnAttackRight.TabIndex = 0;
            this.btnAttackRight.Text = "→";
            this.btnAttackRight.UseVisualStyleBackColor = true;
            this.btnAttackRight.Click += new System.EventHandler(this.btnAttackRight_Click);
            // 
            // picInventoryMace
            // 
            this.picInventoryMace.BackColor = System.Drawing.Color.Transparent;
            this.picInventoryMace.Image = global::HF_DungeonQuest_lab_2.Properties.Resources.mace;
            this.picInventoryMace.Location = new System.Drawing.Point(267, 457);
            this.picInventoryMace.Margin = new System.Windows.Forms.Padding(4);
            this.picInventoryMace.Name = "picInventoryMace";
            this.picInventoryMace.Size = new System.Drawing.Size(67, 62);
            this.picInventoryMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInventoryMace.TabIndex = 21;
            this.picInventoryMace.TabStop = false;
            this.picInventoryMace.Visible = false;
            this.picInventoryMace.Click += new System.EventHandler(this.picInventoryMace_Click);
            // 
            // picInventoryBow
            // 
            this.picInventoryBow.BackColor = System.Drawing.Color.Transparent;
            this.picInventoryBow.Image = global::HF_DungeonQuest_lab_2.Properties.Resources.bow;
            this.picInventoryBow.Location = new System.Drawing.Point(192, 457);
            this.picInventoryBow.Margin = new System.Windows.Forms.Padding(4);
            this.picInventoryBow.Name = "picInventoryBow";
            this.picInventoryBow.Size = new System.Drawing.Size(67, 62);
            this.picInventoryBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInventoryBow.TabIndex = 20;
            this.picInventoryBow.TabStop = false;
            this.picInventoryBow.Visible = false;
            this.picInventoryBow.Click += new System.EventHandler(this.picInventoryBow_Click);
            // 
            // picInventorySword
            // 
            this.picInventorySword.BackColor = System.Drawing.Color.Transparent;
            this.picInventorySword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picInventorySword.Image = ((System.Drawing.Image)(resources.GetObject("picInventorySword.Image")));
            this.picInventorySword.Location = new System.Drawing.Point(117, 457);
            this.picInventorySword.Margin = new System.Windows.Forms.Padding(4);
            this.picInventorySword.Name = "picInventorySword";
            this.picInventorySword.Size = new System.Drawing.Size(67, 62);
            this.picInventorySword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInventorySword.TabIndex = 19;
            this.picInventorySword.TabStop = false;
            this.picInventorySword.Visible = false;
            this.picInventorySword.Click += new System.EventHandler(this.picInventorySword_Click);
            // 
            // picInventoryRed
            // 
            this.picInventoryRed.BackColor = System.Drawing.Color.Transparent;
            this.picInventoryRed.Image = ((System.Drawing.Image)(resources.GetObject("picInventoryRed.Image")));
            this.picInventoryRed.Location = new System.Drawing.Point(416, 457);
            this.picInventoryRed.Margin = new System.Windows.Forms.Padding(4);
            this.picInventoryRed.Name = "picInventoryRed";
            this.picInventoryRed.Size = new System.Drawing.Size(67, 62);
            this.picInventoryRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInventoryRed.TabIndex = 18;
            this.picInventoryRed.TabStop = false;
            this.picInventoryRed.Visible = false;
            this.picInventoryRed.Click += new System.EventHandler(this.picInventoryRed_Click);
            // 
            // picInventoryBlue
            // 
            this.picInventoryBlue.BackColor = System.Drawing.Color.Transparent;
            this.picInventoryBlue.Image = ((System.Drawing.Image)(resources.GetObject("picInventoryBlue.Image")));
            this.picInventoryBlue.Location = new System.Drawing.Point(341, 457);
            this.picInventoryBlue.Margin = new System.Windows.Forms.Padding(4);
            this.picInventoryBlue.Name = "picInventoryBlue";
            this.picInventoryBlue.Size = new System.Drawing.Size(67, 62);
            this.picInventoryBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInventoryBlue.TabIndex = 17;
            this.picInventoryBlue.TabStop = false;
            this.picInventoryBlue.Visible = false;
            this.picInventoryBlue.Click += new System.EventHandler(this.picInventoryBlue_Click);
            // 
            // tbCheats
            // 
            this.tbCheats.BackColor = System.Drawing.Color.Black;
            this.tbCheats.Enabled = false;
            this.tbCheats.ForeColor = System.Drawing.Color.White;
            this.tbCheats.Location = new System.Drawing.Point(190, 543);
            this.tbCheats.Name = "tbCheats";
            this.tbCheats.Size = new System.Drawing.Size(69, 22);
            this.tbCheats.TabIndex = 22;
            this.tbCheats.TextChanged += new System.EventHandler(this.tbCheats_TextChanged);
            this.tbCheats.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCheats_KeyDown);
            // 
            // picNecromancer
            // 
            this.picNecromancer.BackColor = System.Drawing.Color.Transparent;
            this.picNecromancer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picNecromancer.Image = global::HF_DungeonQuest_lab_2.Properties.Resources.wizard;
            this.picNecromancer.Location = new System.Drawing.Point(471, 305);
            this.picNecromancer.Margin = new System.Windows.Forms.Padding(4);
            this.picNecromancer.Name = "picNecromancer";
            this.picNecromancer.Size = new System.Drawing.Size(40, 37);
            this.picNecromancer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNecromancer.TabIndex = 23;
            this.picNecromancer.TabStop = false;
            this.picNecromancer.Visible = false;
            this.picNecromancer.Click += new System.EventHandler(this.picNecromancer_Click);
            // 
            // cbCheats
            // 
            this.cbCheats.AutoSize = true;
            this.cbCheats.BackColor = System.Drawing.Color.Transparent;
            this.cbCheats.ForeColor = System.Drawing.Color.White;
            this.cbCheats.Location = new System.Drawing.Point(112, 544);
            this.cbCheats.Name = "cbCheats";
            this.cbCheats.Size = new System.Drawing.Size(72, 21);
            this.cbCheats.TabIndex = 24;
            this.cbCheats.Text = "cheats";
            this.cbCheats.UseVisualStyleBackColor = false;
            this.cbCheats.CheckedChanged += new System.EventHandler(this.cbCheats_CheckedChanged);
            // 
            // listBoxLevel
            // 
            this.listBoxLevel.BackColor = System.Drawing.Color.Black;
            this.listBoxLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxLevel.Enabled = false;
            this.listBoxLevel.ForeColor = System.Drawing.Color.White;
            this.listBoxLevel.FormattingEnabled = true;
            this.listBoxLevel.ItemHeight = 16;
            this.listBoxLevel.Items.AddRange(new object[] {
            "Level#1",
            "Level#2",
            "Level#3",
            "Level#4",
            "Level#5",
            "Level#6",
            "Level#7",
            "Level#8"});
            this.listBoxLevel.Location = new System.Drawing.Point(265, 543);
            this.listBoxLevel.Name = "listBoxLevel";
            this.listBoxLevel.Size = new System.Drawing.Size(102, 18);
            this.listBoxLevel.TabIndex = 25;
            this.listBoxLevel.SelectedIndexChanged += new System.EventHandler(this.listBoxLevel_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(895, 469);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(62, 63);
            this.btnPause.TabIndex = 26;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HF_DungeonQuest_lab_2.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 567);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.listBoxLevel);
            this.Controls.Add(this.cbCheats);
            this.Controls.Add(this.picNecromancer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.tbCheats);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picBat);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.picInventoryMace);
            this.Controls.Add(this.picInventoryBow);
            this.Controls.Add(this.picInventorySword);
            this.Controls.Add(this.picInventoryRed);
            this.Controls.Add(this.picInventoryBlue);
            this.Controls.Add(this.grboxAttack);
            this.Controls.Add(this.grboxMove);
            this.Controls.Add(this.tlpHitPoints);
            this.Controls.Add(this.picGhoul);
            this.Controls.Add(this.picGhost);
            this.Controls.Add(this.picMace);
            this.Controls.Add(this.picBow);
            this.Controls.Add(this.picSword);
            this.Controls.Add(this.picRedPotion);
            this.Controls.Add(this.picBluePotion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).EndInit();
            this.tlpHitPoints.ResumeLayout(false);
            this.tlpHitPoints.PerformLayout();
            this.grboxMove.ResumeLayout(false);
            this.grboxAttack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventorySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNecromancer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBat;
        private System.Windows.Forms.PictureBox picGhoul;
        private System.Windows.Forms.PictureBox picGhost;
        private System.Windows.Forms.PictureBox picBow;
        private System.Windows.Forms.PictureBox picSword;
        private System.Windows.Forms.PictureBox picRedPotion;
        private System.Windows.Forms.PictureBox picBluePotion;
        private System.Windows.Forms.PictureBox picMace;
        private System.Windows.Forms.TableLayoutPanel tlpHitPoints;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblBat;
        private System.Windows.Forms.Label lblGhost;
        private System.Windows.Forms.Label lblGhoul;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblBatHP;
        private System.Windows.Forms.Label lblGhostHP;
        private System.Windows.Forms.Label lblGhoulHP;
        private System.Windows.Forms.GroupBox grboxMove;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.GroupBox grboxAttack;
        private System.Windows.Forms.Button btnAttackUp;
        private System.Windows.Forms.Button btnAttackLeft;
        private System.Windows.Forms.Button btnAttackDown;
        private System.Windows.Forms.Button btnAttackRight;
        private System.Windows.Forms.PictureBox picInventoryMace;
        private System.Windows.Forms.PictureBox picInventoryBow;
        private System.Windows.Forms.PictureBox picInventorySword;
        private System.Windows.Forms.PictureBox picInventoryRed;
        private System.Windows.Forms.PictureBox picInventoryBlue;
        private System.Windows.Forms.TextBox tbCheats;
        private System.Windows.Forms.PictureBox picNecromancer;
        private System.Windows.Forms.Label lblNecroHp;
        private System.Windows.Forms.Label lblNecro;
        private System.Windows.Forms.CheckBox cbCheats;
        private System.Windows.Forms.ListBox listBoxLevel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPause;
    }
}

