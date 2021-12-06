using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity13XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] gameBoard = new string[3, 3];

        bool isWinner = false;
        //button clicks
        int turn = -1;
        
       
        private void xo00_Click(object sender, EventArgs e)
        {
            if(xo00.Text == "")
            {
                turn *= -1;
                                
                if (turn > 0)
                {
                    xo00.Text = "X";
                    xo00.ForeColor = Color.Purple;
                }
                else
                {
                    xo00.Text = "O";
                    xo00.ForeColor = Color.MediumPurple;
                }                                
                this.Refresh();

                gameBoard[0, 0] = xo00.Text;

                Winner(gameBoard);

                if(isWinner == true)
                {
                    if(turn > 0)
                    {
                        MessageBox.Show("X Wins");
                    }
                    else
                    {
                        MessageBox.Show("O Wins!");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is already a value here. Try again");
            }                        
        }

        private void xo01_Click(object sender, EventArgs e)
        {
            if (xo01.Text == "")
            {
                int nextTurn = turn * -1;
                if (nextTurn > 0)
                {
                    xo01.Text = "X";
                    xo01.ForeColor = Color.Purple;
                }
                else
                {
                    xo01.Text = "O";
                    xo01.ForeColor = Color.MediumPurple;
                }
                turn = nextTurn;
                this.Refresh();
                gameBoard[0, 1] = xo01.Text;

                Winner(gameBoard);
                if (isWinner == true)
                {
                    if (turn > 0)
                    {
                        MessageBox.Show("X Wins");
                    }
                    else
                    {
                        MessageBox.Show("O Wins!");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is already a value here. Try again");
            }
        }

        private void xo02_Click(object sender, EventArgs e)
        {
            if (xo02.Text == "")
            {
                int nextTurn = turn * -1;
                if (nextTurn > 0)
                {
                    xo02.Text = "X";
                    xo02.ForeColor = Color.Purple;
                }
                else
                {
                    xo02.Text = "O";
                    xo02.ForeColor = Color.MediumPurple;
                }
                turn = nextTurn;
                this.Refresh();
                gameBoard[0, 2] = xo02.Text;

                Winner(gameBoard);
                if (isWinner == true)
                {
                    if (turn > 0)
                    {
                        MessageBox.Show("X Wins");
                    }
                    else
                    {
                        MessageBox.Show("O Wins!");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is already a value here. Try again");
            }
        }

        private void xo10_Click(object sender, EventArgs e)
        {
            if (xo10.Text == "")
            {
                int nextTurn = turn * -1;
                if (nextTurn > 0)
                {
                    xo10.Text = "X";
                    xo10.ForeColor = Color.Purple;
                }
                else
                {
                    xo10.Text = "O";
                    xo10.ForeColor = Color.MediumPurple;
                }
                turn = nextTurn;
                this.Refresh();

                gameBoard[1, 0] = xo10.Text;

                Winner(gameBoard);
                if (isWinner == true)
                {
                    if (turn > 0)
                    {
                        MessageBox.Show("X Wins");
                    }
                    else
                    {
                        MessageBox.Show("O Wins!");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is already a value here. Try again");
            }
        }

        private void xo11_Click(object sender, EventArgs e)
        {
            if (xo11.Text == "")
            {
                int nextTurn = turn * -1;
                if (nextTurn > 0)
                {
                    xo11.Text = "X";
                    xo11.ForeColor = Color.Purple;
                }
                else
                {
                    xo11.Text = "O";
                    xo11.ForeColor = Color.MediumPurple;
                }
                turn = nextTurn;
                this.Refresh();

                gameBoard[1, 1] = xo11.Text;

                Winner(gameBoard);
                if (isWinner == true)
                {
                    if (turn > 0)
                    {
                        MessageBox.Show("X Wins");
                    }
                    else
                    {
                        MessageBox.Show("O Wins!");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is already a value here. Try again");
            }
        }

        private void xo12_Click(object sender, EventArgs e)
        {
            if (xo12.Text == "")
            {
                int nextTurn = turn * -1;
                if (nextTurn > 0)
                {
                    xo12.Text = "X";
                    xo12.ForeColor = Color.Purple;
                }
                else
                {
                    xo12.Text = "O";
                    xo12.ForeColor = Color.MediumPurple;
                }
                turn = nextTurn;
                this.Refresh();

                gameBoard[1, 2] = xo12.Text;

                Winner(gameBoard);
                if (isWinner == true)
                {
                    if (turn > 0)
                    {
                        MessageBox.Show("X Wins");
                    }
                    else
                    {
                        MessageBox.Show("O Wins!");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is already a value here. Try again");
            }
        }

        private void xo20_Click(object sender, EventArgs e)
        {
            if (xo20.Text == "")
            {
                int nextTurn = turn * -1;
                if (nextTurn > 0)
                {
                    xo20.Text = "X";
                    xo20.ForeColor = Color.Purple;
                }
                else
                {
                    xo20.Text = "O";
                    xo20.ForeColor = Color.MediumPurple;
                }
                turn = nextTurn;
                this.Refresh();

                gameBoard[2, 0] = xo20.Text;

                Winner(gameBoard);
                if (isWinner == true)
                {
                    if (turn > 0)
                    {
                        MessageBox.Show("X Wins");
                    }
                    else
                    {
                        MessageBox.Show("O Wins!");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is already a value here. Try again");
            }
        }

        private void xo21_Click(object sender, EventArgs e)
        {
            if (xo21.Text == "")
            {
                int nextTurn = turn * -1;
                if (nextTurn > 0)
                {
                    xo21.Text = "X";
                    xo21.ForeColor = Color.Purple;
                }
                else
                {
                    xo21.Text = "O";
                    xo21.ForeColor = Color.MediumPurple;
                }
                turn = nextTurn;
                this.Refresh();
                gameBoard[2, 1] = xo21.Text;

                Winner(gameBoard);
                if (isWinner == true)
                {
                    if (turn > 0)
                    {
                        MessageBox.Show("X Wins");
                    }
                    else
                    {
                        MessageBox.Show("O Wins!");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is already a value here. Try again");
            }
        }

        private void xo22_Click(object sender, EventArgs e)
        {
            if (xo22.Text == "")
            {
                int nextTurn = turn * -1;
                if (nextTurn > 0)
                {
                    xo22.Text = "X";
                    xo22.ForeColor = Color.Purple;
                }
                else
                {
                    xo22.Text = "O";
                    xo22.ForeColor = Color.MediumPurple;
                }
                turn = nextTurn;
                this.Refresh();
                gameBoard[2, 2] = xo22.Text;

                Winner(gameBoard);
                if (isWinner == true)
                {
                    if (turn > 0)
                    {
                        MessageBox.Show("X Wins");
                    }
                    else
                    {
                        MessageBox.Show("O Wins!");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is already a value here. Try again");
            }
        }
                             
       private bool Winner(string[,] board)
        {
            //winner - check each row
            for(int row = 0; row < 3; row++)
            {
                if(gameBoard[row,0] == gameBoard[row,1] && gameBoard[row, 1] == gameBoard[row, 2])
                {
                    if(gameBoard[row,0] != null && gameBoard[row, 1] != null && gameBoard[row, 2] != null)
                    {
                        isWinner = true;
                        groupBox1.Enabled = false;
                    }                   
                }
            }
            //winner - check each col
            for (int col = 0; col < 3; col++)
            {
                if (gameBoard[0, col] == gameBoard[1, col] && gameBoard[1, col] == gameBoard[2, col])
                {
                    if (gameBoard[0, col] != null && gameBoard[1, col] != null && gameBoard[2, col] != null)
                    {
                        isWinner = true;
                        groupBox1.Enabled = false;
                    }
                    
                }
            }
            //winner - check right diagonal
            if(gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2])
            {
                if(gameBoard[1,1] != null)
                {
                    isWinner = true;
                    groupBox1.Enabled = false;
                }
                
            }
            //winner - check left diagonal
            if (gameBoard[2,0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[0,2])
            {
                if (gameBoard[1, 1] != null)
                {
                    isWinner = true;
                    groupBox1.Enabled = false;
                }
            }

            return isWinner;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
          
        }
    }
    
}
