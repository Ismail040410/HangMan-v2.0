using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameLogic.SetupStartCondition();
            txtWord.Text = GameLogic.FullWord;

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (GameLogic.IsWordCorrect(txtWord.Text))
            {
                txtSecret.Text = GameLogic.FullWord;
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);

            }
            else if (GameLogic.GameLost == false)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("U have guessed" + GameLogic.CountGuesses + " times", "The word is incorrect", MessageBoxButtons.OK);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameLogic.SetupStartCondition();
            resetAll();
            txtWord.Text = GameLogic.GetOneWord();
            txtSecret.Text = GameLogic.GetSecretWord();
        }

        private void resetAll()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnJ.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnQ.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnV.Enabled = true;
            btnW.Enabled = true;
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;
        }

        private void btnA_Click(object sender, EventArgs e)
        {           
            btnA.Enabled = false;
            if (GameLogic.GameWon==true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if(GameLogic.CorrectLetter('A'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);
      
            }
           
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('B'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
           else if (GameLogic.CorrectLetter('C'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
           else if (GameLogic.CorrectLetter('D'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            btnE.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('E'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            btnF.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('F'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            btnG.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('G'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            btnH.Enabled = false;
           
            if (GameLogic.CorrectLetter('H'))
            {
                txtSecret.Text = GameLogic.SecretWord;
                if (GameLogic.GameWon == true)
                {
                    
                    MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
                }
               
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            btnI.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('I'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            btnJ.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('J'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            btnK.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('K'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            btnL.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('L'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnM.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('M'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            btnN.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('N'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            btnO.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('O'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            btnP.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('P'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            btnQ.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('Q'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('R'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btnS.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('S'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            btnT.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('T'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            btnU.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('U'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            btnV.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('V'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }

        }

        private void btnW_Click(object sender, EventArgs e)
        {
            btnW.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('W'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            btnX.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('X'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            btnY.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('Y'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            btnZ.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('Z'))
            {
                txtSecret.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }
    }
}
