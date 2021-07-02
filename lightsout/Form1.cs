using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lightsout
{
    public partial class Form1 : Form
    {
        int nbrMoves;
        const int GridSize = 5;  // changing this changes grid size
        Color onColor = Color.DarkGreen;
        Color offColor = Color.LightGreen;

        public Form1()
        {
            InitializeComponent();
            nbrMoves = 0;
        }

        private bool CheckForWin()
        {
            bool win = true;

            for (int row = 0; row < GridSize; row++)
            {
                for (int col = 0; col < GridSize; col++)
                {
                    if (this.btnLights[row, col].BackColor == onColor)
                    {
                        win = false;
                        return win;
                    }
                }
            }
            return win;  // true
        }

        private void RestartClickHandler(object sender, System.EventArgs e)
        {
            ResetGameGrid();
        }

        private void ResetGameGrid()
        {
            for (int y = 0; y < GridSize; y++)
                for (int x = 0; x < GridSize; x++)
                    this.btnLights[x, y].BackColor = onColor;

            nbrMoves = 0;
            this.txtMoves.Text = nbrMoves.ToString();
        }

        private void LightsClickHandler(object sender, System.EventArgs e)
        {
            Button tempButton = (Button)sender;
            
            // Toggle this button...
            ToggleButtonColor(tempButton);

            // Determine location of current button in grid of buttons
            // the -1 is because buttons start at position 1 instead of 0.
            int btnX = ((tempButton.TabIndex-1) % GridSize);
            int btnY = (int)((tempButton.TabIndex-1) / GridSize);

            // Toggle button to the left
            if(btnX > 0 )
            {
                ToggleButtonColor(btnLights[(btnX-1), btnY]);
            }
            // Toggle button to the right
            if(btnX < (GridSize-1) )
            {
                ToggleButtonColor(btnLights[(btnX+1), btnY]);
            }
            // Toggle button above
            if(btnY > 0 )
            {
                ToggleButtonColor(btnLights[btnX,(btnY-1)]);
            }
            // Toggle button below
            if(btnY < (GridSize-1)) 
            {
                ToggleButtonColor(btnLights[btnX,(btnY+1)]);
            }

            nbrMoves++;
            this.txtMoves.Text = nbrMoves.ToString();

            if (CheckForWin() == true)
            {
                MessageBox.Show("You Won in " + this.txtMoves.Text + " moves!");
                ResetGameGrid();
            }
        }

        private void ToggleButtonColor(Button tempButton)
        {
            if (tempButton.BackColor == onColor)
            {
                tempButton.BackColor = offColor;
            }
            else
            {
                tempButton.BackColor = onColor;
            }
        }
    }
}