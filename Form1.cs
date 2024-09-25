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

        private void shoot_button_Click(object sender, EventArgs e)
        {
            // generate a random number 1 - 3(do not display) 
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            //check user rock,paper,scissor selection
            int userSelection = 0;

            if (rockRadio.Checked)
            {
                //rock
                userSelection = 1;
            }
            else if (paperRadio.Checked)
            {
                //paper
                userSelection = 2;
            }
            else if (scissorsRadio.Checked)
            {
                //scissors
                userSelection = 3;
            }

            System.Diagnostics.Debug.WriteLine(randomNumber);
            System.Diagnostics.Debug.WriteLine(userSelection);


            if (userSelection == randomNumber)
            {
                MessageBox.Show("Draw!");
            }
            else if (userSelection == 1 && randomNumber == 2)
            {
                MessageBox.Show(" Rock vs Paper - You loose");
            }
            else if (userSelection == 2 && randomNumber == 3)
            {
                MessageBox.Show("Paper vs Scissors - You Loose");
            }
            else if (userSelection == 3 && randomNumber == 1)
            {
                MessageBox.Show("Scissors vs Rock - You Loose");
            }else if (userSelection == 1 && randomNumber == 3)
            {
                MessageBox.Show("Rock vs Scissors - You Win!");
            }else if(userSelection == 2 && randomNumber == 1)
            {
                MessageBox.Show("Paper vs Rock - You Win!");
            }else if(userSelection == 3 && randomNumber == 2)
            {
                MessageBox.Show("Scissors vs Paper - You Win!");
            }



        }
    }
}
