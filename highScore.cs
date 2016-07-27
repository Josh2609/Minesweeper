using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class highScore : Form
    {
        public highScore()
        {
            InitializeComponent();
        }

        private void lblFstMsg_Click(object sender, EventArgs e)
        {

        }

        // ran when the form loads
        private void highScore_Load(object sender, EventArgs e)
        {
            if (Main.diff == 1) // if difficulty is beginner
                lblFstMsg.Text = "You have beat the fastest time\nfor the Beginner difficulty.\nPlease enter your name";
            else if (Main.diff == 2) // if difficulty is intermediate
                lblFstMsg.Text = "You have beat the fastest time\nfor the Intermediate difficulty.\nPlease enter your name";
            else if (Main.diff == 3) // if difficulty is expert
                lblFstMsg.Text = "You have beat the fastest time\nfor the Expert difficulty.\nPlease enter your name";  
        }
        
        // event handler for submit button click
        private void submitInitials_Click(object sender, EventArgs e)
        {
            if (tbInitials.Text.Length > 0) // if the box contains text
            {
                Main.userName = tbInitials.Text; // set the username to the text
                // Hide menu for choosing options
                tbInitials.Visible = false;
                submitInitials.Visible = false;
                lblNoInitials.Visible = false;
                Close();
            }
            else // if no text entered
            {
                lblNoInitials.Visible = true; // display label to tell the user to add text
            }
        }
    }
}
