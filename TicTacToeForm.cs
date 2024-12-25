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





    }
}
