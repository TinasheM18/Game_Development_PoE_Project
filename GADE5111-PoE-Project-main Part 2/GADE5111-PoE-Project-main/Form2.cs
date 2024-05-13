using GADE5121_PoE_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartUpPage
{
    public partial class Form2 : Form
    {


        // Step 1: Declare Arrays and Constants
        // Arrays to store player data
        string[] P1data = new string[4];
        string[] P2data = new string[4];
        int[] P1values = new int[4];
        int[] P2values = new int[4];

        // Constants for dragon stats and types
        const string FIRE_DRAG_NAME = "Fire Dragon";
        const int FIRE_DRAG_HP = 20;
        const int FIRE_DRAG_ATK = 5;
        const int FIRE_DRAG_SPATK = 12;
        const int FIRE_DRAG_BLOCK = 4;

        const string ICE_DRAG_NAME = "Ice Dragon";
        const int ICE_DRAG_HP = 25;
        const int ICE_DRAG_ATK = 4;
        const int ICE_DRAG_SPATK = 10;
        const int ICE_DRAG_BLOCK = 5;

        const string WIND_DRAG_NAME = "Wind Dragon";
        const int WIND_DRAG_HP = 18;
        const int WIND_DRAG_ATK = 6;
        const int WIND_DRAG_SPATK = 15;
        const int WIND_DRAG_BLOCK = 3;

        const string EARTH_DRAG_NAME = "Earth Dragon";
        const int EARTH_DRAG_HP = 22;
        const int EARTH_DRAG_ATK = 7;
        const int EARTH_DRAG_SPATK = 14;
        const int EARTH_DRAG_BLOCK = 6;


        public Form2()
        {
            InitializeComponent();
        }


        private void dragon1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iceDrag1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fireDrag1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void windDrag1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void earthDrag1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Step 2: Implement saveValues() Method
        // Method to save player data based on selected dragon type
        private void saveValues(string playerName, string dragonName, string dragonType)
        {
            if (playerName.Equals("Player 1"))
            {
                P1data[0] = playerName;
                P1data[1] = dragonName;
                P1data[2] = dragonType;

                switch (dragonType)
                {
                    case FIRE_DRAG_NAME:
                        P1values[0] = FIRE_DRAG_HP;
                        P1values[1] = FIRE_DRAG_ATK;
                        P1values[2] = FIRE_DRAG_SPATK;
                        P1values[3] = FIRE_DRAG_BLOCK;
                        break;
                    case ICE_DRAG_NAME:
                        P1values[0] = ICE_DRAG_HP;
                        P1values[1] = ICE_DRAG_ATK;
                        P1values[2] = ICE_DRAG_SPATK;
                        P1values[3] = ICE_DRAG_BLOCK;
                        break;
                    case WIND_DRAG_NAME:
                        P1values[0] = WIND_DRAG_HP;
                        P1values[1] = WIND_DRAG_ATK;
                        P1values[2] = WIND_DRAG_SPATK;
                        P1values[3] = WIND_DRAG_BLOCK;
                        break;
                    case EARTH_DRAG_NAME:
                        P1values[0] = EARTH_DRAG_HP;
                        P1values[1] = EARTH_DRAG_ATK;
                        P1values[2] = EARTH_DRAG_SPATK;
                        P1values[3] = EARTH_DRAG_BLOCK;
                        break;
                    default:
                        break;
                }
                savebtn1.Enabled = false;
            }
            else if (playerName.Equals("Player 2"))
            {
                P2data[0] = playerName;
                P2data[1] = dragonName;
                P2data[2] = dragonType;

                switch (dragonType)
                {
                    case FIRE_DRAG_NAME:
                        P2values[0] = FIRE_DRAG_HP;
                        P2values[1] = FIRE_DRAG_ATK;
                        P2values[2] = FIRE_DRAG_SPATK;
                        P2values[3] = FIRE_DRAG_BLOCK;
                        break;
                    case ICE_DRAG_NAME:
                        P2values[0] = ICE_DRAG_HP;
                        P2values[1] = ICE_DRAG_ATK;
                        P2values[2] = ICE_DRAG_SPATK;
                        P2values[3] = ICE_DRAG_BLOCK;
                        break;
                    case WIND_DRAG_NAME:
                        P2values[0] = WIND_DRAG_HP;
                        P2values[1] = WIND_DRAG_ATK;
                        P2values[2] = WIND_DRAG_SPATK;
                        P2values[3] = WIND_DRAG_BLOCK;
                        break;
                    case EARTH_DRAG_NAME:
                        P2values[0] = EARTH_DRAG_HP;
                        P2values[1] = EARTH_DRAG_ATK;
                        P2values[2] = EARTH_DRAG_SPATK;
                        P2values[3] = EARTH_DRAG_BLOCK;
                        break;
                    default:
                        break;
                }
                savebtn2.Enabled = false;
            }


            // Enable start button if both players have saved their data
            if (!savebtn1.Enabled && !savebtn2.Enabled)
                startbtn.Enabled = true;
        }

        // Method to return selected dragon type from the ComboBox
        private string selectedDragonType(ComboBox comboBox)
        {
            string dragonType = "";
            if (comboBox.SelectedIndex == 0)
                dragonType = FIRE_DRAG_NAME;
            else if (comboBox.SelectedIndex == 1)
                dragonType = ICE_DRAG_NAME;
            else if (comboBox.SelectedIndex == 2)
                dragonType = WIND_DRAG_NAME;
            else if (comboBox.SelectedIndex == 3)
                dragonType = EARTH_DRAG_NAME;
            return dragonType;
        }

        // Step 3: Call saveValues() Method on Save Button

        // Event handler for Player 1 save button
        private void savebtn1_Click(object sender, EventArgs e)
        {
            saveValues(player1.Text, dragon1.Text, selectedDragonType(dragon1));
        }

        private void player1_TextChanged(object sender, EventArgs e)
        {

        }

        private void player2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dragon2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void fireDrag2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iceDrag2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void windDrag2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void earthDrag2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        // Event handler for Player 2 save button
        private void savebtn2_Click(object sender, EventArgs e)
        {

            saveValues(player2.Text, dragon2.Text, selectedDragonType(dragon2));
        }

        private string selectedDragonType(TextBox dragon2)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        // Step 4: Handle Start Game Button
        // Event handler for start button
        private void startbtn_Click(object sender, EventArgs e)
        {
            // Initialize the PlayerTurnInterface object with player data
            PlayerTurnInterface turnForm = new PlayerTurnInterface(P1data, P2data, P1values, P2values);
            // Show the turn form and hide the current form
            turnForm.Show();
            this.Hide();
        }




        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
