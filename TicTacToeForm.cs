﻿using System;
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
        private Image xImage = Image.FromFile("Images/x.png");
        private Image oImage = Image.FromFile("Images/o.png");

        private void TicTacToeForm_Load(object sender, EventArgs e)
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

            if (clickedButton.BackgroundImage == null) // Check if the button is empty
            {
                if (isPlayerXTurn)
                {
                    clickedButton.BackgroundImage = xImage;
                    clickedButton.Tag = "X"; // Store the player for winner check
                }
                else
                {
                    clickedButton.BackgroundImage = oImage;
                    clickedButton.Tag = "O"; // Store the player for winner check
                }

                if (CheckWinner())
                {
                    lblStatus.Text = $"{(isPlayerXTurn ? "Player X" : "Player O")} Wins!";
                    DisableButtons();
                    return;
                }

                isPlayerXTurn = !isPlayerXTurn; // Switch turns
                lblStatus.Text = isPlayerXTurn ? "Player X's Turn" : "Player O's Turn";
            }
        }


        private bool CheckWinner()
        {
            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (gridButtons[i, 0].Tag != null &&
                    gridButtons[i, 0].Tag == gridButtons[i, 1].Tag &&
                    gridButtons[i, 1].Tag == gridButtons[i, 2].Tag)
                {
                    return true;
                }

                // Check columns
                if (gridButtons[0, i].Tag != null &&
                    gridButtons[0, i].Tag == gridButtons[1, i].Tag &&
                    gridButtons[1, i].Tag == gridButtons[2, i].Tag)
                {
                    return true;
                }
            }

            // Check diagonals
            if (gridButtons[0, 0].Tag != null &&
                gridButtons[0, 0].Tag == gridButtons[1, 1].Tag &&
                gridButtons[1, 1].Tag == gridButtons[2, 2].Tag)
            {
                return true;
            }

            if (gridButtons[0, 2].Tag != null &&
                gridButtons[0, 2].Tag == gridButtons[1, 1].Tag &&
                gridButtons[1, 1].Tag == gridButtons[2, 0].Tag)
            {
                return true;
            }

            return false;
        }



        private void DisableButtons()
        {
            foreach (Button button in gridButtons)
            {
                button.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Button button in gridButtons)
            {
                button.BackgroundImage = null; // Clear the image
                button.Tag = null; // Reset the Tag property
                button.Enabled = true;
            }
            isPlayerXTurn = true;
            lblStatus.Text = "Player X's Turn";
        }

    }
}
