using System.Xml.Linq;

namespace GADE5121_PoE_Project
{
    public partial class PlayerTurnInterface : Form
    {

        public PlayerTurnInterface(string[] p1data)
        {
            InitializeComponent();
        }

        private string[] p1data = new string[4];
        private string[] p2data = new string[4];
        private int[] p1values = new int[4];
        private int[] p2values = new int[4];

        static string turn = "";
        static bool OppBlocking = false;
        static string currentPlayer = "";

        public PlayerTurnInterface(string[] p1data, string[] p2data, int[] p1values, int[] p2values) : this(p1data)
        {
            this.p1data = p1data;
            this.p2data = p2data;
            this.p1values = p1values;
            this.p2values = p2values;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            turn = takeInitiative();
            turnSwitch(turn);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblHitPoints_Click(object sender, EventArgs e)
        {

        }

        private void lblOppDragonHP_Click(object sender, EventArgs e)
        {

        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            btnAttack_Click(sender, e, p2data);
        }

        private void btnAttack_Click(object sender, EventArgs e, string[] p2data)
        {
            if (turn == "P1")
            {
                p2values[0] = Attack(p2values[0], p1values[1], p2values[3], OppBlocking);
                string p1DragonName = p1data[1].ToString();
                string output = "\n" + p1DragonName + " attacks, " + p2data[1] + " has " + p2values[0] + "HP remaining";
                txtBoxBattleLog.Text += output;
                txtBoxBattleLog.Text += "\n**********************************************************";

            }

            else
            {
                p1values[0] = Attack(p1values[0], p2values[1], p1values[3], OppBlocking);
                txtBoxBattleLog.Text += "\n" + p2data[1] + " attacks, " + p1data[1] + " has " + p1values[0] + "HP remaining";
                txtBoxBattleLog.Text += "\n**********************************************************";

            }

            nextTurn(turn);
        }

        private void pcBoxPlayerDragon_Click(object sender, EventArgs e)
        {

        }

        private void btnSpecialAttck_Click(object sender, EventArgs e)
        {
            if (turn == "P1")
            {
                p2values[0] = SPAttack(p2values[0], p1values[1], p2values[3], OppBlocking);
                txtBoxBattleLog.Text += "\n" + p1data[1] + " special attacks, " + p2data[1]+ " has " + p2values[0] + "HP remaining";
                txtBoxBattleLog.Text += "\n**********************************************************";

            }

            else
            {
                p1values[0] = SPAttack(p1values[0], p2values[1], p1values[3], OppBlocking);
                txtBoxBattleLog.Text += "\n" + p2data[1] + " attacks, " + p1data[1] + " has " + p1values[0] + "HP remaining";
                txtBoxBattleLog.Text += "\n**********************************************************";

            }

            nextTurn(turn);
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            Block();

            if (turn == "P1")
            {
                txtBoxBattleLog.Text += "\n" + p1values[0] + " blocks!";
                txtBoxBattleLog.Text += "\n**********************************************************";

            }

            else
            {
                txtBoxBattleLog.Text += "\n" + p2values[0] + " blocks!";
                txtBoxBattleLog.Text += "\n**********************************************************";

            }

        }

        private void txtBoxBattleLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void pcBoxOppDragon_Click(object sender, EventArgs e)
        {

        }

        private void lblOppDragonNameAndType_Click(object sender, EventArgs e)
        {

        }

        private void grpBoxOppDetails_Enter(object sender, EventArgs e)
        {

        }

        private void grpBoxBattleLog_Enter(object sender, EventArgs e)
        {

        }

        //methods for in game actions
        //Random number generator to return a number between 1-6 
        public static int randomRoll()
        {
            Random diceRoll = new Random();
            int roll = diceRoll.Next(1, 7);
            return roll;
        }

        //Initiative method to determine which player takes the first turn
        //returns which player takes the first turn
        private string takeInitiative()
        {
            int p1Roll = randomRoll();
            int p2Roll = randomRoll();

            while (p1Roll == p2Roll)//while loop to ensure the random numbers are not equal and if they are method will randomRoll their values again
            {
                p1Roll = randomRoll();
                p2Roll = randomRoll();
            }

            string playerTurn = "";

            if (p1Roll > p2Roll)//if statement to check which players roll value was higher
            {
                playerTurn = "P1";
            }

            else
            {
                playerTurn = "P2";
            }

            txtBoxBattleLog.Text = p1data[0] + " rolled a " + p1Roll + "and " + p2data[0] + " rolled a " + p2Roll + "\n" + playerTurn + " takes the first turn";
            txtBoxBattleLog.Text += "**********************************************************";

            return playerTurn;
        }

        //method to customize turn player form according to current players turn
        
        public void turnSwitch(string pTurn)
        {
            if (pTurn == "P1")
            {
                grpBoxPlayerDetails.Text = p1data[1] + ", the " + p1data[2] + "'s Turn";
                lblPlayerHitPoints.Text = "HP:\n" + p1values[0];
                btnAttack.Text = "Attack [" + p1values[1] + " DP]";
                btnSpecialAttck.Text = "Special Attack [" + p1values[2] + " DP]";
                btnBlock.Text = "Block [-" + p1values[3] + " DP]";

                grpBoxOppDetails.Text = "Opp: " + p2data[0];
                lblOppDragonNameAndType.Text = p2data[1] + ", " + p2data[2];
                lblOppDragonHP.Text = "HP: " + p2values[0];

                txtBoxBattleLog.Text += "\n" + p1data[0] + "'s Turn \n**********************************************************";
            }

            else
            {
                grpBoxPlayerDetails.Text = p2data[1] + ", the " + p2data[2] + "'s Turn";
                lblPlayerHitPoints.Text = "HP:\n" + p2values[0];
                btnAttack.Text = "Attack [" + p2values[1] + " DP]";
                btnSpecialAttck.Text = "Special Attack [" + p2values[2] + " DP]";
                btnBlock.Text = "Block [-" + p2values[3] + " DP]";

                grpBoxOppDetails.Text = "Opp: " + p1data[0];
                lblOppDragonNameAndType.Text = p1data[1] + ", " + p1data[2];
                lblOppDragonHP.Text = "HP: " + p1values[0];

                txtBoxBattleLog.Text += "\n" + p2data[0] + "'s Turn \n**********************************************************";
            }
        }

        //method to switch current players turn value
        public void nextTurn(string nextTurn)
        {
            if (nextTurn == "P1")
            {
                nextTurn = "P2";
            }

            else
            {
                nextTurn = "P1";
            }

            turn = nextTurn;

            turnSwitch(nextTurn);
        }

        //method to set blocking bool to true
        public static void Block()
        {
            OppBlocking = true;
        }

        //method to deal attack damage to opponents HP and return remaining HP
        public static int Attack(int oppHP, int attackDMG, int blockDMG, bool OppBlocking)
        {
            if (OppBlocking)
            {
                int remAtt = attackDMG - blockDMG;
                oppHP -= remAtt;
                OppBlocking = false;
            }

            else
            {
                oppHP -= attackDMG;
            }

            return oppHP;
        }

        //method to deal special attack damage to opponents HP and return remaining HP
        public static int SPAttack(int oppHP, int SPattackDMG, int blockDMG, bool OppBlocking)
        {
            if (OppBlocking)
            {
                int remAtt = SPattackDMG - blockDMG;
                oppHP -= remAtt;
                OppBlocking = false;
            }

            else
            {
                oppHP -= SPattackDMG;
            }

            return oppHP;
        }

        private void grpBoxPlayerDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
