namespace StartUpPage
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            startbtn = new Button();
            groupBox3 = new GroupBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            savebtn2 = new Button();
            groupBox5 = new GroupBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            earthDrag2 = new RadioButton();
            windDrag2 = new RadioButton();
            iceDrag2 = new RadioButton();
            fireDrag2 = new RadioButton();
            label6 = new Label();
            label4 = new Label();
            dragon2 = new TextBox();
            player2 = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            savebtn1 = new Button();
            groupBox4 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            earthDrag1 = new RadioButton();
            windDrag1 = new RadioButton();
            iceDrag1 = new RadioButton();
            fireDrag1 = new RadioButton();
            label5 = new Label();
            label3 = new Label();
            dragon1 = new TextBox();
            player1 = new TextBox();
            label1 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // startbtn
            // 
            startbtn.Location = new Point(553, 665);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(104, 35);
            startbtn.TabIndex = 8;
            startbtn.Text = "Start Game";
            startbtn.UseVisualStyleBackColor = true;
            startbtn.Click += startbtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 224, 192);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(859, 62);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(301, 528);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dragon Stats:";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 38);
            label7.Name = "label7";
            label7.Size = new Size(184, 460);
            label7.TabIndex = 0;
            label7.Text = resources.GetString("label7.Text");
            label7.Click += label7_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 192, 255);
            groupBox2.Controls.Add(savebtn2);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dragon2);
            groupBox2.Controls.Add(player2);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(437, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(371, 528);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // savebtn2
            // 
            savebtn2.Location = new Point(116, 487);
            savebtn2.Name = "savebtn2";
            savebtn2.Size = new Size(104, 35);
            savebtn2.TabIndex = 6;
            savebtn2.Text = "Save";
            savebtn2.UseVisualStyleBackColor = true;
            savebtn2.Click += savebtn2_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(pictureBox8);
            groupBox5.Controls.Add(pictureBox7);
            groupBox5.Controls.Add(pictureBox6);
            groupBox5.Controls.Add(pictureBox5);
            groupBox5.Controls.Add(earthDrag2);
            groupBox5.Controls.Add(windDrag2);
            groupBox5.Controls.Add(iceDrag2);
            groupBox5.Controls.Add(fireDrag2);
            groupBox5.Location = new Point(6, 121);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(329, 360);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Dragon Type";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(159, 260);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(83, 75);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 11;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(159, 179);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(83, 75);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(159, 98);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(83, 75);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(159, 17);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(83, 75);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // earthDrag2
            // 
            earthDrag2.AutoSize = true;
            earthDrag2.Location = new Point(16, 288);
            earthDrag2.Name = "earthDrag2";
            earthDrag2.Size = new Size(118, 24);
            earthDrag2.TabIndex = 7;
            earthDrag2.TabStop = true;
            earthDrag2.Text = "Earth Dragon";
            earthDrag2.UseVisualStyleBackColor = true;
            earthDrag2.CheckedChanged += earthDrag2_CheckedChanged;
            // 
            // windDrag2
            // 
            windDrag2.AutoSize = true;
            windDrag2.Location = new Point(16, 206);
            windDrag2.Name = "windDrag2";
            windDrag2.Size = new Size(119, 24);
            windDrag2.TabIndex = 6;
            windDrag2.TabStop = true;
            windDrag2.Text = "Wind Dragon";
            windDrag2.UseVisualStyleBackColor = true;
            windDrag2.CheckedChanged += windDrag2_CheckedChanged;
            // 
            // iceDrag2
            // 
            iceDrag2.AutoSize = true;
            iceDrag2.Location = new Point(16, 117);
            iceDrag2.Name = "iceDrag2";
            iceDrag2.Size = new Size(103, 24);
            iceDrag2.TabIndex = 5;
            iceDrag2.TabStop = true;
            iceDrag2.Text = "Ice Dragon";
            iceDrag2.UseVisualStyleBackColor = true;
            iceDrag2.CheckedChanged += iceDrag2_CheckedChanged;
            // 
            // fireDrag2
            // 
            fireDrag2.AutoSize = true;
            fireDrag2.Location = new Point(16, 37);
            fireDrag2.Name = "fireDrag2";
            fireDrag2.Size = new Size(108, 24);
            fireDrag2.TabIndex = 4;
            fireDrag2.TabStop = true;
            fireDrag2.Text = "Fire Dragon";
            fireDrag2.UseVisualStyleBackColor = true;
            fireDrag2.CheckedChanged += fireDrag2_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 74);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 5;
            label6.Text = "Dragon Name";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 41);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 4;
            label4.Text = "Player Name";
            label4.Click += label4_Click;
            // 
            // dragon2
            // 
            dragon2.Location = new Point(116, 71);
            dragon2.Name = "dragon2";
            dragon2.Size = new Size(180, 27);
            dragon2.TabIndex = 3;
            dragon2.TextChanged += dragon2_TextChanged;
            // 
            // player2
            // 
            player2.Location = new Point(116, 38);
            player2.Name = "player2";
            player2.Size = new Size(180, 27);
            player2.TabIndex = 2;
            player2.TextChanged += player2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 0;
            label2.Text = "Player 2";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 128, 128);
            groupBox1.Controls.Add(savebtn1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dragon1);
            groupBox1.Controls.Add(player1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 528);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // savebtn1
            // 
            savebtn1.Location = new Point(114, 487);
            savebtn1.Name = "savebtn1";
            savebtn1.Size = new Size(104, 35);
            savebtn1.TabIndex = 0;
            savebtn1.Text = "Save";
            savebtn1.UseVisualStyleBackColor = true;
            savebtn1.Click += savebtn1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox2);
            groupBox4.Controls.Add(pictureBox4);
            groupBox4.Controls.Add(pictureBox3);
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Controls.Add(earthDrag1);
            groupBox4.Controls.Add(windDrag1);
            groupBox4.Controls.Add(iceDrag1);
            groupBox4.Controls.Add(fireDrag1);
            groupBox4.Location = new Point(6, 121);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(329, 360);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dragon Type";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(146, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(146, 260);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(83, 75);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(146, 179);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // earthDrag1
            // 
            earthDrag1.AutoSize = true;
            earthDrag1.Location = new Point(16, 288);
            earthDrag1.Name = "earthDrag1";
            earthDrag1.Size = new Size(118, 24);
            earthDrag1.TabIndex = 3;
            earthDrag1.TabStop = true;
            earthDrag1.Text = "Earth Dragon";
            earthDrag1.UseVisualStyleBackColor = true;
            earthDrag1.CheckedChanged += earthDrag1_CheckedChanged;
            // 
            // windDrag1
            // 
            windDrag1.AutoSize = true;
            windDrag1.Location = new Point(16, 206);
            windDrag1.Name = "windDrag1";
            windDrag1.Size = new Size(119, 24);
            windDrag1.TabIndex = 2;
            windDrag1.TabStop = true;
            windDrag1.Text = "Wind Dragon";
            windDrag1.UseVisualStyleBackColor = true;
            windDrag1.CheckedChanged += windDrag1_CheckedChanged;
            // 
            // iceDrag1
            // 
            iceDrag1.AutoSize = true;
            iceDrag1.Location = new Point(16, 117);
            iceDrag1.Name = "iceDrag1";
            iceDrag1.Size = new Size(103, 24);
            iceDrag1.TabIndex = 1;
            iceDrag1.TabStop = true;
            iceDrag1.Text = "Ice Dragon";
            iceDrag1.UseVisualStyleBackColor = true;
            iceDrag1.CheckedChanged += iceDrag1_CheckedChanged;
            // 
            // fireDrag1
            // 
            fireDrag1.AutoSize = true;
            fireDrag1.Location = new Point(16, 37);
            fireDrag1.Name = "fireDrag1";
            fireDrag1.Size = new Size(108, 24);
            fireDrag1.TabIndex = 0;
            fireDrag1.TabStop = true;
            fireDrag1.Text = "Fire Dragon";
            fireDrag1.UseVisualStyleBackColor = true;
            fireDrag1.CheckedChanged += fireDrag1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 74);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 4;
            label5.Text = "Dragon Name";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 41);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 3;
            label3.Text = "Player Name";
            label3.Click += label3_Click;
            // 
            // dragon1
            // 
            dragon1.Location = new Point(114, 71);
            dragon1.Name = "dragon1";
            dragon1.Size = new Size(182, 27);
            dragon1.TabIndex = 2;
            dragon1.TextChanged += dragon1_TextChanged;
            // 
            // player1
            // 
            player1.Location = new Point(114, 38);
            player1.Name = "player1";
            player1.Size = new Size(182, 27);
            player1.TabIndex = 1;
            player1.TextChanged += player1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 0;
            label1.Text = "Player 1";
            label1.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1185, 715);
            Controls.Add(startbtn);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button startbtn;
        private GroupBox groupBox3;
        private Label label7;
        private GroupBox groupBox2;
        private Button savebtn2;
        private GroupBox groupBox5;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private RadioButton earthDrag2;
        private RadioButton windDrag2;
        private RadioButton iceDrag2;
        private RadioButton fireDrag2;
        private Label label6;
        private Label label4;
        private TextBox dragon2;
        private TextBox player2;
        private Label label2;
        private GroupBox groupBox1;
        private Button savebtn1;
        private GroupBox groupBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private RadioButton earthDrag1;
        private RadioButton windDrag1;
        private RadioButton iceDrag1;
        private RadioButton fireDrag1;
        private Label label5;
        private Label label3;
        private TextBox dragon1;
        private TextBox player1;
        private Label label1;
    }
}