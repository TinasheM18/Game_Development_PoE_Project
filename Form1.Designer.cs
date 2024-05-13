namespace GADE5121_PoE_Project
{
    partial class PlayerTurnInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerTurnInterface));
            pcBoxPlayerDragon = new PictureBox();
            lblPlayerHitPoints = new Label();
            btnAttack = new Button();
            btnSpecialAttck = new Button();
            btnBlock = new Button();
            txtBoxBattleLog = new TextBox();
            pcBoxOppDragon = new PictureBox();
            lblOppDragonNameAndType = new Label();
            lblOppDragonHP = new Label();
            grpBoxOppDetails = new GroupBox();
            grpBoxPlayerDetails = new GroupBox();
            grpBoxBattleLog = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pcBoxPlayerDragon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxOppDragon).BeginInit();
            grpBoxOppDetails.SuspendLayout();
            grpBoxPlayerDetails.SuspendLayout();
            grpBoxBattleLog.SuspendLayout();
            SuspendLayout();
            // 
            // pcBoxPlayerDragon
            // 
            pcBoxPlayerDragon.Image = (Image)resources.GetObject("pcBoxPlayerDragon.Image");
            pcBoxPlayerDragon.Location = new Point(6, 36);
            pcBoxPlayerDragon.Name = "pcBoxPlayerDragon";
            pcBoxPlayerDragon.Size = new Size(151, 140);
            pcBoxPlayerDragon.SizeMode = PictureBoxSizeMode.Zoom;
            pcBoxPlayerDragon.TabIndex = 1;
            pcBoxPlayerDragon.TabStop = false;
            pcBoxPlayerDragon.Click += pcBoxPlayerDragon_Click;
            // 
            // lblPlayerHitPoints
            // 
            lblPlayerHitPoints.AutoSize = true;
            lblPlayerHitPoints.BackColor = Color.Transparent;
            lblPlayerHitPoints.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerHitPoints.Location = new Point(163, 51);
            lblPlayerHitPoints.Name = "lblPlayerHitPoints";
            lblPlayerHitPoints.Size = new Size(82, 108);
            lblPlayerHitPoints.TabIndex = 2;
            lblPlayerHitPoints.Text = "HP:\r\n30 ";
            lblPlayerHitPoints.Click += lblHitPoints_Click;
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(6, 188);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(386, 41);
            btnAttack.TabIndex = 3;
            btnAttack.Text = "Attack (4 Damage Points)";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // btnSpecialAttck
            // 
            btnSpecialAttck.Location = new Point(6, 235);
            btnSpecialAttck.Name = "btnSpecialAttck";
            btnSpecialAttck.Size = new Size(386, 41);
            btnSpecialAttck.TabIndex = 4;
            btnSpecialAttck.Text = "Special Attack (9 DP)";
            btnSpecialAttck.UseVisualStyleBackColor = true;
            btnSpecialAttck.Click += btnSpecialAttck_Click;
            // 
            // btnBlock
            // 
            btnBlock.Location = new Point(6, 282);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(386, 41);
            btnBlock.TabIndex = 5;
            btnBlock.Text = "Block (-5 DP)";
            btnBlock.UseVisualStyleBackColor = true;
            btnBlock.Click += btnBlock_Click;
            // 
            // txtBoxBattleLog
            // 
            txtBoxBattleLog.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxBattleLog.Location = new Point(5, 39);
            txtBoxBattleLog.Multiline = true;
            txtBoxBattleLog.Name = "txtBoxBattleLog";
            txtBoxBattleLog.ReadOnly = true;
            txtBoxBattleLog.Size = new Size(1035, 145);
            txtBoxBattleLog.TabIndex = 7;
            txtBoxBattleLog.Text = "Lupe's Turn:\r\nTundra attacks Boulder and deals 4 DP, Boulder has 36 HP left\r\n****************************************************************************";
            txtBoxBattleLog.TextChanged += txtBoxBattleLog_TextChanged;
            // 
            // pcBoxOppDragon
            // 
            pcBoxOppDragon.Image = (Image)resources.GetObject("pcBoxOppDragon.Image");
            pcBoxOppDragon.Location = new Point(6, 30);
            pcBoxOppDragon.Name = "pcBoxOppDragon";
            pcBoxOppDragon.Size = new Size(128, 135);
            pcBoxOppDragon.SizeMode = PictureBoxSizeMode.Zoom;
            pcBoxOppDragon.TabIndex = 8;
            pcBoxOppDragon.TabStop = false;
            pcBoxOppDragon.Click += pcBoxOppDragon_Click;
            // 
            // lblOppDragonNameAndType
            // 
            lblOppDragonNameAndType.AutoSize = true;
            lblOppDragonNameAndType.BackColor = Color.Transparent;
            lblOppDragonNameAndType.Font = new Font("Segoe UI", 14F);
            lblOppDragonNameAndType.Location = new Point(140, 46);
            lblOppDragonNameAndType.Name = "lblOppDragonNameAndType";
            lblOppDragonNameAndType.Size = new Size(249, 32);
            lblOppDragonNameAndType.TabIndex = 9;
            lblOppDragonNameAndType.Text = "Boulder, Earth Dragon";
            lblOppDragonNameAndType.Click += lblOppDragonNameAndType_Click;
            // 
            // lblOppDragonHP
            // 
            lblOppDragonHP.AutoSize = true;
            lblOppDragonHP.BackColor = Color.Transparent;
            lblOppDragonHP.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOppDragonHP.Location = new Point(140, 85);
            lblOppDragonHP.Name = "lblOppDragonHP";
            lblOppDragonHP.Size = new Size(137, 54);
            lblOppDragonHP.TabIndex = 11;
            lblOppDragonHP.Text = "HP: 46";
            lblOppDragonHP.Click += lblOppDragonHP_Click;
            // 
            // grpBoxOppDetails
            // 
            grpBoxOppDetails.BackColor = Color.FromArgb(192, 255, 192);
            grpBoxOppDetails.Controls.Add(lblOppDragonNameAndType);
            grpBoxOppDetails.Controls.Add(lblOppDragonHP);
            grpBoxOppDetails.Controls.Add(pcBoxOppDragon);
            grpBoxOppDetails.Location = new Point(534, 106);
            grpBoxOppDetails.Name = "grpBoxOppDetails";
            grpBoxOppDetails.Size = new Size(472, 186);
            grpBoxOppDetails.TabIndex = 12;
            grpBoxOppDetails.TabStop = false;
            grpBoxOppDetails.Text = "Opp: Gustavo";
            grpBoxOppDetails.Enter += grpBoxOppDetails_Enter;
            // 
            // grpBoxPlayerDetails
            // 
            grpBoxPlayerDetails.BackColor = Color.FromArgb(192, 255, 255);
            grpBoxPlayerDetails.Controls.Add(pcBoxPlayerDragon);
            grpBoxPlayerDetails.Controls.Add(lblPlayerHitPoints);
            grpBoxPlayerDetails.Controls.Add(btnAttack);
            grpBoxPlayerDetails.Controls.Add(btnSpecialAttck);
            grpBoxPlayerDetails.Controls.Add(btnBlock);
            grpBoxPlayerDetails.Location = new Point(12, 12);
            grpBoxPlayerDetails.Name = "grpBoxPlayerDetails";
            grpBoxPlayerDetails.Size = new Size(420, 331);
            grpBoxPlayerDetails.TabIndex = 13;
            grpBoxPlayerDetails.TabStop = false;
            grpBoxPlayerDetails.Text = "Tundra, Ice Dragon";
            grpBoxPlayerDetails.Enter += grpBoxPlayerDetails_Enter;
            // 
            // grpBoxBattleLog
            // 
            grpBoxBattleLog.BackColor = Color.FromArgb(255, 192, 128);
            grpBoxBattleLog.Controls.Add(txtBoxBattleLog);
            grpBoxBattleLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBoxBattleLog.Location = new Point(12, 349);
            grpBoxBattleLog.Name = "grpBoxBattleLog";
            grpBoxBattleLog.Size = new Size(1048, 189);
            grpBoxBattleLog.TabIndex = 14;
            grpBoxBattleLog.TabStop = false;
            grpBoxBattleLog.Text = "Battle Log";
            grpBoxBattleLog.Enter += grpBoxBattleLog_Enter;
            // 
            // PlayerTurnInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1059, 539);
            Controls.Add(grpBoxBattleLog);
            Controls.Add(grpBoxPlayerDetails);
            Controls.Add(grpBoxOppDetails);
            Name = "PlayerTurnInterface";
            Text = "Dragon Dungeon Duels (Lupe's Turn)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcBoxPlayerDragon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxOppDragon).EndInit();
            grpBoxOppDetails.ResumeLayout(false);
            grpBoxOppDetails.PerformLayout();
            grpBoxPlayerDetails.ResumeLayout(false);
            grpBoxPlayerDetails.PerformLayout();
            grpBoxBattleLog.ResumeLayout(false);
            grpBoxBattleLog.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pcBoxPlayerDragon;
        private Label lblPlayerHitPoints;
        private Button btnAttack;
        private Button btnSpecialAttck;
        private Button btnBlock;
        private TextBox txtBoxBattleLog;
        private PictureBox pcBoxOppDragon;
        private Label lblOppDragonNameAndType;
        private Label lblOppDragonHP;
        private GroupBox grpBoxOppDetails;
        private GroupBox grpBoxPlayerDetails;
        private GroupBox grpBoxBattleLog;
    }
}
