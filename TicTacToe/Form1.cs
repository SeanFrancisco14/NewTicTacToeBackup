using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        String[] gameBoard = new string[9];
        int current_Turn = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public System.Drawing.Color determineColor(String symbol)
        {
            if (symbol.Equals("O"))
            {
                return System.Drawing.Color.LightGreen;
            }
            else if (symbol.Equals("X"))
            {
                return System.Drawing.Color.LightBlue;
            }
            return System.Drawing.Color.White;
        }

        public void checkWinConditions()
        {
            for (int i = 0; i < 8; i++)
            {
                String combination = "";
                int one = 0, two = 0, three = 0;

                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        one = 0;
                        two = 1;
                        three = 2;
                        break;
                    case 1:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        one = 3;
                        two = 4;
                        three = 5;
                        break;
                    case 2:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        one = 6;
                        two = 7;
                        three = 8;
                        break;
                    case 3:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        one = 0;
                        two = 3;
                        three = 6;
                        break;
                    case 4:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        one = 1;
                        two = 4;
                        three = 7;
                        break;
                    case 5:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        one = 2;
                        two = 5;
                        three = 8;
                        break;
                    case 6:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        one = 0;
                        two = 4;
                        three = 8;
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        one = 2;
                        two = 4;
                        three = 6;
                        break;
                }

                if (combination.Equals("OOO"))
                {
                    change_Color(one);
                    change_Color(two);
                    change_Color(three);
                    MessageBox.Show("O wins the game! " + "\r\n" + "GG ");
                    reset();
                }
                else if (combination.Equals("XXX"))
                {
                    change_Color(one);
                    change_Color(two);
                    change_Color(three);
                    MessageBox.Show("X wins the game! " + "\r\n" + "GG ");
                    reset();
                }

                checkDrawConditions();
            }
        }

        public void change_Color(int number)
        {
            switch (number)
            {
                case 0:
                    btn1.BackColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    btn2.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    btn3.BackColor = System.Drawing.Color.Red;
                    break;
                case 3:
                    btn4.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    btn5.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:
                    btn6.BackColor = System.Drawing.Color.Red;
                    break;
                case 6:
                    btn7.BackColor = System.Drawing.Color.Red;
                    break;
                case 7:
                    btn8.BackColor = System.Drawing.Color.Red;
                    break;
                case 8:
                    btn9.BackColor = System.Drawing.Color.Red;
                    break;
            }
        }

        public void checkDrawConditions()
        {
            int counter = 0;
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] != null) { counter++; }

                if (counter == 9)
                {
                    MessageBox.Show("The game is a draw! " + "\r\n" + "WP ");
                    reset();
                }
            }
        }

        public void reset()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.BackColor = System.Drawing.Color.White;
            btn2.BackColor = System.Drawing.Color.White;
            btn3.BackColor = System.Drawing.Color.White;
            btn4.BackColor = System.Drawing.Color.White;
            btn5.BackColor = System.Drawing.Color.White;
            btn6.BackColor = System.Drawing.Color.White;
            btn7.BackColor = System.Drawing.Color.White;
            btn8.BackColor = System.Drawing.Color.White;
            btn9.BackColor = System.Drawing.Color.White;
            gameBoard = new string[9];
            current_Turn = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[0] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[0]);
            btn1.BackColor = button_Color;
            btn1.Text = gameBoard[0];
            checkWinConditions();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[1] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[1]);
            btn2.BackColor = button_Color;
            btn2.Text = gameBoard[0];
            checkWinConditions();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[2] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[2]);
            btn3.BackColor = button_Color;
            btn3.Text = gameBoard[2];
            checkWinConditions();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[3] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[3]);
            btn4.BackColor = button_Color;
            btn4.Text = gameBoard[3];
            checkWinConditions();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[4] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[4]);
            btn5.BackColor = button_Color;
            btn5.Text = gameBoard[4];
            checkWinConditions();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[5] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[5]);
            btn6.BackColor = button_Color;
            btn6.Text = gameBoard[5];
            checkWinConditions();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[6] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[6]);
            btn7.BackColor = button_Color;
            btn7.Text = gameBoard[6];
            checkWinConditions();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[7] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[7]);
            btn8.BackColor = button_Color;
            btn8.Text = gameBoard[7];
            checkWinConditions();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[8] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[8]);
            btn9.BackColor = button_Color;
            btn9.Text = gameBoard[8];
            checkWinConditions();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
