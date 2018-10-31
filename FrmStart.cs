using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class FrmStart : Form
    {
        WordGenerator wg = new WordGenerator();
        char[] characters = null;
        char[] guessedWord = null;
        int wrongGuesses = 0;

        public FrmStart()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            pb_lukas1.Visible = false;
            pb_lukas2.Visible = false;
            pb_lukas3.Visible = false;
            pb_lucas4.Visible = false;
            pb_lukas5.Visible = false;
            pb_lukas6.Visible = false;
            pb_statusbalken.Visible = false;
            pb_statusbalken2.Visible = false;
            pb_statusbalken3.Visible = false;
            pb_statusbalken4.Visible = false;
            pb_statusbalken5.Visible = false;
            pb_statusbalken6.Visible = false;
            pb_statusbalken7.Visible = false;
            pb_statusbalken8.Visible = false;
            pb_statusbalken9.Visible = false;
            pb_statusbalken10.Visible = false;
            pb_hügel.Visible = false;
            pb_seil.Visible = false;
            pb_senkrechtb.Visible = false;
            pb_waagerechtb.Visible = false;
            wrongGuesses = 0;
            guessedWord = null;
            characters = null;
            lblWord.Text = "";
            tBCharacter.MaxLength = 1;
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            lblWord.Text = "";
            String words = wg.getWord().ToUpper();
            characters = words.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                lblWord.Text += "-";
            }
        }

        private void cmdGuess_Click(object sender, EventArgs e)
        {
            try
            {
                char guessedCharacter = tBCharacter.Text.ToCharArray()[0];
                guessedCharacter = Char.ToUpper(guessedCharacter);

                if (guessedWord == null)
                {
                    guessedWord = new char[characters.Length];
                    for (int i = 0; i < guessedWord.Length; i++)
                    {
                        guessedWord[i] = '-';
                    }
                }

                if (characters.Contains(guessedCharacter))
                {
                    lblWord.Text = "";
                    for (int i = 0; i < characters.Length; i++)
                    {
                        if (characters[i] == guessedCharacter)
                        {
                            guessedWord[i] = guessedCharacter;
                        }
                    }
                    for (int j = 0; j < guessedWord.Length; j++)
                    {
                        lblWord.Text += guessedWord[j];
                    }
                }
                else
                {
                    wrongGuesses++;
                }
            }
            catch (Exception exep)
            {
               
            }
            
            switch (wrongGuesses)
            {
                case 1:
                    pb_hügel.Visible = true;
                    pb_statusbalken.Visible = true;
                    break;
                case 2:
                    pb_senkrechtb.Visible = true;
                    pb_statusbalken2.Visible = true;
                    break;
                case 3:
                    pb_waagerechtb.Visible = true;
                    pb_statusbalken3.Visible = true;
                    break;
                case 4:
                    pb_seil.Visible = true;
                    pb_statusbalken4.Visible = true;
                    break;
                case 5:
                    pb_lukas1.Visible = true;
                    pb_statusbalken5.Visible = true;
                    break;
                case 6:
                    pb_lukas1.Visible = false;
                    pb_lukas2.Visible = true;
                    pb_statusbalken6.Visible = true;
                    break;
                case 7:
                    pb_lukas2.Visible = false;
                    pb_lukas3.Visible = true;
                    pb_statusbalken7.Visible = true;
                    break;
                case 8:
                    pb_lukas3.Visible = false;
                    pb_lucas4.Visible = true;
                    pb_statusbalken8.Visible = true;
                    break;
                case 9:
                    pb_lucas4.Visible = false;
                    pb_lukas5.Visible = true;
                    pb_statusbalken9.Visible = true;
                    break;
                case 10:
                    pb_lukas5.Visible = false;
                    pb_lukas6.Visible = true;
                    pb_statusbalken10.Visible = true;
                    MessageBox.Show("You lost!");
                    break;
            }
            try
            {
                if (!guessedWord.Contains('-'))
                {
                    MessageBox.Show("You Won!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eingabe darf nicht leer sein.");
            }
            
            
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            init();
        }
    }
}
