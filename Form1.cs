/*********************************************************

   Gill Guimaraes

  Mini Project - September 26, 2024

   I wrote this code myself...
   I did not use AI or copy code from Google or another student

 *********************************************************/




using System.Security.Cryptography;



namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        int readUserChoice()
        {
            if (rockRadio.Checked)
            {
                return 1; //rock
            }
            else if (paperRadio.Checked)
            {
                return 2; //paper
            }
            else if (scissorsRadio.Checked)
            {
                return 3; //scissors
            }
            else {
                return 0;
            }
        }

        void determineWinner(int user, int bot)
        {
            if(user == 0)
            {
                MessageBox.Show("Please select your weapon");
            }
            else if (user == bot)
            {
                MessageBox.Show("Draw!");
            }
            else if (user == 1 && bot == 2)
            {
                MessageBox.Show(" Rock vs Paper - You loose");
            }
            else if (user == 2 && bot == 3)
            {
                MessageBox.Show("Paper vs Scissors - You Loose");
            }
            else if (user == 3 && bot == 1)
            {
                MessageBox.Show("Scissors vs Rock - You Loose");
            }
            else if (user == 1 && bot == 3)
            {
                MessageBox.Show("Rock vs Scissors - You Win!");
            }
            else if (user == 2 && bot == 1)
            {
                MessageBox.Show("Paper vs Rock - You Win!");
            }
            else if (user == 3 && bot == 2)
            {
                MessageBox.Show("Scissors vs Paper - You Win!");
            }
        }

        private void shoot_button_Click(object sender, EventArgs e)
        {
            // generate a random number 1 - 3(do not display) 
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            //check user rock,paper,scissor selection
            int userSelection = readUserChoice();

            determineWinner(userSelection, randomNumber);

            System.Diagnostics.Debug.WriteLine(randomNumber);
            System.Diagnostics.Debug.WriteLine(userSelection);
        }
    }
}
