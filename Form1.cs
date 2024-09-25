/*********************************************************

   Gill Guimaraes

  Mini Project - September 26, 2024

   I wrote this code myself...
   I did not use AI or copy code from Google or another student

 *********************************************************/




using System.Security.Cryptography;

// generate a random number 1 - 3 on page load. (do not display) 
Random random = new Random();
int randomNumber = random.Next(1, 3);

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shoot_button_Click(object sender, EventArgs e)
        {
            if (rockRadio.Checked)
            {
                int userSelection = 1;
            }
            else if (paperRadio.Checked)
            {
                int userSelection = 2;
            }
            else if (scissorsRadio.Checked)
            {
                int userSelection = 3;
            }

        }
    }
}
