namespace GADE5121_PoE_Project
{
    public partial class PlayerTurnInterface : Form
    {
        private string[] p2data;
        private int[] p1values;
        private int[] p2values;

        public PlayerTurnInterface(string[] p1data)
        {
            InitializeComponent();
        }

        public PlayerTurnInterface(string[] p1data, string[] p2data, int[] p1values, int[] p2values) : this(p1data)
        {
            this.p2data = p2data;
            this.p1values = p1values;
            this.p2values = p2values;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        }

        private void pcBoxPlayerDragon_Click(object sender, EventArgs e)
        {

        }

        private void btnSpecialAttck_Click(object sender, EventArgs e)
        {

        }

        private void btnBlock_Click(object sender, EventArgs e)
        {

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
    }
}
