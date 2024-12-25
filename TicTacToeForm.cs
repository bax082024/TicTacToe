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
    public partial class TicTacToeForm : Form
    {
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private bool isPlayerXTurn = true; // Tracks the current player
        private Button[,] gridButtons;    // 2D array for the button grid

        private void Form1_Load(object sender, EventArgs e)
        {
            gridButtons = new Button[,]
            {
            { btn00, btn01, btn02 },
            { btn10, btn11, btn12 },
            { btn20, btn21, btn22 }
            };

            foreach (Button button in gridButtons)
            {
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.Text == "")
            {
                clickedButton.Text = isPlayerXTurn ? "X" : "O";
                if (CheckWinner())
                {
                    lblStatus.Text = $"{clickedButton.Text} Wins!";
                    DisableButtons();
                    return;
                }
                isPlayerXTurn = !isPlayerXTurn;
                lblStatus.Text = isPlayerXTurn ? "Player X's Turn" : "Player O's Turn";
            }
        }

        private bool CheckWinner()
        {
            // Check rows, columns, and diagonals
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (gridButtons[i, 0].Text != "" &&
                    gridButtons[i, 0].Text == gridButtons[i, 1].Text &&
                    gridButtons[i, 1].Text == gridButtons[i, 2].Text)
                    return true;

                // Check columns
                if (gridButtons[0, i].Text != "" &&
                    gridButtons[0, i].Text == gridButtons[1, i].Text &&
                    gridButtons[1, i].Text == gridButtons[2, i].Text)
                    return true;
            }

            // Check diagonals
            if (gridButtons[0, 0].Text != "" &&
                gridButtons[0, 0].Text == gridButtons[1, 1].Text &&
                gridButtons[1, 1].Text == gridButtons[2, 2].Text)
                return true;

            if (gridButtons[0, 2].Text != "" &&
                gridButtons[0, 2].Text == gridButtons[1, 1].Text &&
                gridButtons[1, 1].Text == gridButtons[2, 0].Text)
                return true;

            return false;
        }







    }
}
