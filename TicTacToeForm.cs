using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private bool isPlayerXTurn = true;
        private Button[,] gridButtons;
        private Image xImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "x.png"));
        private Image oImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "o.png"));


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
                button.Enabled = false;
                button.Click += Button_Click;
            }
        }



        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.BackgroundImage == null)
            {
                if (isPlayerXTurn)
                {
                    clickedButton.BackgroundImage = xImage;
                    clickedButton.Tag = "X"; 
                }
                else
                {
                    clickedButton.BackgroundImage = oImage;
                    clickedButton.Tag = "O"; 
                }

                if (CheckWinner())
                {
                    lblStatus.Text = $"{(isPlayerXTurn ? "Player X" : "Player O")} Wins!";
                    DisableButtons();
                    return;
                }

                isPlayerXTurn = !isPlayerXTurn; 
                lblStatus.Text = isPlayerXTurn ? "Player X's Turn" : "Player O's Turn";
            }
        }


        private bool CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (gridButtons[i, 0].Tag != null &&
                    gridButtons[i, 0].Tag == gridButtons[i, 1].Tag &&
                    gridButtons[i, 1].Tag == gridButtons[i, 2].Tag)
                {
                    return true;
                }

   
                if (gridButtons[0, i].Tag != null &&
                    gridButtons[0, i].Tag == gridButtons[1, i].Tag &&
                    gridButtons[1, i].Tag == gridButtons[2, i].Tag)
                {
                    return true;
                }
            }

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
                button.Enabled = false; 
                button.BackgroundImage = null;
                button.Tag = null;
            }

            isPlayerXTurn = true;
            lblStatus.Text = "Click Start to begin!";
            btnStart.Enabled = true;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (gridButtons == null)
            {
                gridButtons = new Button[,]
                {
            { btn00, btn01, btn02 },
            { btn10, btn11, btn12 },
            { btn20, btn21, btn22 }
                };
            }

            foreach (Button button in gridButtons)
            {
                button.Enabled = true; 
                button.BackgroundImage = null; 
                button.Tag = null; 
            }

            isPlayerXTurn = true; 
            lblStatus.Text = "Player X's Turn"; 
            btnStart.Enabled = false; 
        }


    }
}
