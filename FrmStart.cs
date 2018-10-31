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
        Hangman hangman = new Hangman();

        public FrmStart()
        {
            InitializeComponent();
            init();
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            hangman.init();
            lblWord.Text = "";
            for (int i = 0; i < hangman.Characters.Length; i++)
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

                if (hangman.GuessedWord == null)
                {
                    hangman.GuessedWord = new char[hangman.Characters.Length];
                    for (int i = 0; i < hangman.GuessedWord.Length; i++)
                    {
                        hangman.GuessedWord[i] = '-';
                    }
                }

                if (hangman.Characters.Contains(guessedCharacter))
                {
                    lblWord.Text = "";
                    for (int i = 0; i < hangman.Characters.Length; i++)
                    {
                        if (hangman.Characters[i] == guessedCharacter)
                        {
                            hangman.GuessedWord[i] = guessedCharacter;
                        }
                    }
                    for (int j = 0; j < hangman.Characters.Length; j++)
                    {
                        lblWord.Text += hangman.GuessedWord[j];
                    }
                }
                else
                {
                    hangman.WrongGuesses++;
                }
            }
            catch (Exception exep)
            {
               
            }
            
            switch (hangman.WrongGuesses)
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
                    lblWord.Text = "";
                    for (int j = 0; j < hangman.Characters.Length; j++)
                    {
                        lblWord.Text += hangman.Characters[j];
                    }
                    MessageBox.Show("You lost!");
                    break;
            }
            try
            {
                if (!hangman.GuessedWord.Contains('-'))
                {
                    MessageBox.Show("You Won!");
                }
            }
            catch (ArgumentNullException)
            {
                if (hangman.Characters != null)
                {
                    MessageBox.Show("Eingabe darf nicht leer sein");
                }
                if (hangman.Characters == null)
                {
                MessageBox.Show("Du musst ein Wort laden!");
                }
            }
        }
        private void cmdReset_Click(object sender, EventArgs e)
        {
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
            lblWord.Text = "";
            tBCharacter.MaxLength = 1;
            hangman.reset();
        }
    }
}
