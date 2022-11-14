namespace WinFormsApp1
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            currentPlayerLabel.Text = "Krzy¿yk";
            changeLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if(currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "x";
                currentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "O";
                currentPlayer=CurrentPlayer.Cross;
            }
            changeLabel();
            checkForWinner();
        }
        public void changeLabel()
        {
            if(currentPlayer == CurrentPlayer.Cross)
            {
                currentPlayerLabel.Text = "Krzy¿yk";
            }
            else
            {
                currentPlayerLabel.Text = "Kó³ko";
            }
        }
        public void checkForWinner()
        {
            if(String.Compare(gl.Text, sl.Text) == 0 && String.Compare(sl.Text, dl.Text) == 0)
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.Show();
            }

        }
    }
}