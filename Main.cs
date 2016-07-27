using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Minesweeper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // method for executing when the form loads
        private void Menu_Load(object sender, EventArgs e)
        {
            this.AutoSize = false; // set autosize to false, stopping the user from changing the form size
            readFiles(); // read the high scores file
        }
        // event handler for clicking the new button
        private void btnNew_Click(object sender, EventArgs e)
        {
            mainMenuVisible(false); // Hide menu for choosing options
            diffMenuVisible(true); // Draw new menu for choosing difficulty
        }

        // method to change the visibility of the main menu buttons
        private void mainMenuVisible(bool visible)
        {
            btnNew.Visible = visible;
            btnHighScore.Visible = visible;
            btnExit.Visible = visible;
        }
        // method to change the visibility of the difficulty menu buttons
        private void diffMenuVisible(bool visible)
        {
            btnBeg.Visible = visible;
            btnInt.Visible = visible;
            btnExpert.Visible = visible;
            btnCustom.Visible = visible;
        }

        // method to change the visibility of the custom difficulty options
        private void customChoicesVisible(bool visible)
        {
            customPlay.Visible = visible;
            lblX.Visible = visible;
            lblY.Visible = visible;
            txtX.Visible = visible;
            txtY.Visible = visible;
            lblAskUser.Visible = visible;
        }

        // event handler for the high score button
        private void btnHighScore_Click(object sender, EventArgs e)
        {
            showHighScore(); // shows the high scores
        }

        // method to change the visibility of the high scores
        private void highScoreVisible(bool visible)
        {
            lblBegHS.Visible = visible;
            lblIntHS.Visible = visible;
            lblExpHS.Visible = visible;
            lblBegHSTime.Visible = visible;
            lblIntHSTime.Visible = visible;
            lblExpHSTime.Visible = visible;
            lblBegHSName.Visible = visible;
            lblIntHSName.Visible = visible;
            lblExpHSName.Visible = visible;
        }

        // method that shows the high scores
        private void showHighScore()
        {
            mainMenuVisible(false);
            btnMenu.Visible = true;
            lblBegHSTime.Text = highScoreArr[0, 1] + " Seconds      ";
            lblBegHSName.Text = highScoreArr[0, 0];
            lblIntHSTime.Text = highScoreArr[1, 1] + " Seconds      ";
            lblIntHSName.Text = highScoreArr[1, 0];
            lblExpHSTime.Text = highScoreArr[2, 1] + " Seconds      ";
            lblExpHSName.Text = highScoreArr[2, 0];

            highScoreVisible(true);
        }

        // event handler for the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); // closes the form
        }

        // event handler for the custom button
        private void btnCustom_Click(object sender, EventArgs e)
        {
            diffMenuVisible(false); // hides the difficulty menu
            customChoicesVisible(true); // shows the custom choices
        }

        // event handler for the play button on the custom screen
        private void customPlay_Click(object sender, EventArgs e)
        {
            setUpCustom(); // sets up the custom game
        }

        // method to change the visibility of the game UI
        private void playUIVisible(bool visible)
        {
            lblTimer.Visible = visible;
            lblFlgRem.Visible = visible;
            btnReset.Visible = visible;
        }

        // method to set up and play the custom game
        private void setUpCustom()
        {
            playUIVisible(false); // hides the play UI
            bool valid = false; // creates a bool to store if the options were valid
            customX = System.Convert.ToInt32(txtX.Text); // convert the text to an int and set it in x
            customY = System.Convert.ToInt32(txtY.Text); // convert the text to an int and set it in y
            if (customX > 1 && customX < 31 && customY > 1 && customY < 31) // if the values are in range
                valid = true; // set valid to true
          
           if (valid == true) // if values are valid
           {
                customChoicesVisible(false); // hide the choices
                playCustom(); // play custom game
            }
        }

        // method to play a custom game
        private void playCustom()
        {
            int gridX = customX, gridY = customY; // gridX and Y to customX and Y
            int winWidth = (customX * 30) + 100, winHeight = (gridY * 35) + 200; // set form dimensions based on grid size
            int numMines = (customX * gridY) / 8; // sets number of mines
            diff = 4; // sets diff to 4 to indicate custom difficulty
            btnCounter = (customX * gridY) - numMines; // sets btnCounter to grid size minus mines to be used to detect if the user has won

            // Hides difficulty selection buttons
            diffMenuVisible(false); // hides difficulty selection buttons

            flgRem = numMines; // sets class variable that stores the number of flags left to numMines

            gameBtn = new Button[gridX, gridY]; // creates an array of buttons of size specified earlier
            hintGrid = new Label[gridX, gridY]; // creates an array of labels to go under the buttons for the hint numbers
            logicGrid = new int[gridX, gridY]; // creates an int array to store the hint numbers and mine positions

            buildGameUI(winWidth, winHeight); // calls method to build the gameUI and passes in form dimensions
            buildGrid(gridX, gridY); // calls method to build the grid and passes in the grid dimensions
            placeMines(numMines, gridX - 1, gridY - 1); // calls method to place the mines and passes in the number of mines and the grid size -1
            calcHintNum(numMines, gridX - 1, gridY - 1); // calls method to calculate the hint numbers for the positions without mines
            this.AutoSize = true; // sets autosize to true
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // sets autosize mode to change based on screen contents
            scoreTimer.Start(); // starts the timer

            //changeBtnText(gridX, gridY);
        }

        private Button[,] gameBtn; // Create 2D array of buttons
        private int[,] logicGrid; // stores grid as int for game logic
        private Label[,] hintGrid; // stores the hint numbers as labels to be shown when the button is clicked
        private string[,] highScoreArr = new string[3, 2]; // array to store 25 high scores for the 3 difficulties
        private int flgRem; // int to hold the remaining flags to place
        public static int diff = 0; // declares variable to store the difficulty
        private int timer = 0; // sets int variable to store the timer
        public static string userName; // sets string variable to store username
        private int btnCounter; // sets int variable to store the btnCounter
        private int customX, customY; // sets int variables to store the x and y for custom difficulties
        string[] losingMineCoord = new string[2];

        // method for handling setup and playing of beginner difficulty
        private void playBeg()
        {
            int winWidth = 300, winHeight = 410; // declares int variables to be used for form height and width
            this.Width = winWidth; // sets the form width to 300
            this.Height = winHeight; // sets the form height to 410

            int gridX = 9, gridY = 9; // declares variables to be used for grid width and height and sets them to 9
            int numMines = 10; // variable for number of mines
            flgRem = numMines; // sets class variable that stores the number of flags left to numMines
            diff = 1; // sets diff to 1 to indicate beginner difficulty
            btnCounter = 71; // sets btnCounter to 71 to be used to detect if the user has won

            diffMenuVisible(false); // Hides difficulty selection buttons

            gameBtn = new Button[gridX, gridY]; // creates an array of buttons of size specified earlier
            hintGrid = new Label[gridX, gridY]; // creates an array of labels to go under the buttons for the hint numbers
            logicGrid = new int[gridX, gridY]; // creates an int array to store the hint numbers and mine positions

            buildGameUI(winWidth, winHeight); // calls method to build the gameUI and passes in form dimensions
            buildGrid(gridX, gridY); // calls method to build the grid and passes in the grid dimensions
            placeMines(numMines, gridX - 1, gridY - 1); // calls method to place the mines and passes in the number of mines and the grid size -1
            calcHintNum(numMines, gridX - 1, gridY - 1); // calls method to calculate the hint numbers for the positions without mines
            scoreTimer.Start(); // starts the timer

            //changeBtnText(gridX, gridY);
        }

        // event handler for clicking the beginner button
        private void btnBeg_Click(object sender, EventArgs e)
        {
            destroyGrid(); // calls method to clean up the old arrays
            playBeg(); // calls method to play on beginner
        }

        // method that builds the 3 arrays for the game
        private void buildGrid(int gridX, int gridY)
        {
            for (int x = 0; x < gridX; x++) // Loop for x axis until grid size
            {
                for (int y = 0; y < gridY; y++) // Loop for y axis until grid size
                {
                    logicGrid[x, y] = 0; // set the logic grid position to 0
                    gameBtn[x, y] = new Button(); // initialize a new instance of a button
                    hintGrid[x, y] = new Label(); // initialize a new instance of a label

                    hintGrid[x, y].Name = x.ToString() + " " + y.ToString(); // set the name of the label to the position in the array
                    hintGrid[x, y].SetBounds(30 * x + 5, 30 * y + 80, 30, 30); // set the position and dimensions of the label
                    hintGrid[x, y].TextAlign = ContentAlignment.MiddleCenter; // align the text
                    hintGrid[x, y].BorderStyle = BorderStyle.FixedSingle; // set border style

                    gameBtn[x, y].Name = x.ToString() + " " + y.ToString(); // set the name of the button to the position in the array
                    gameBtn[x, y].SetBounds(30 * x + 5, 30 * y + 80, 30, 30); // set the position and dimensions of the button
                    gameBtn[x, y].BackColor = Color.PowderBlue; // change the background color to powder blue 
                    gameBtn[x, y].Image = Minesweeper.Properties.Resources.tile;
                    //gameBtn[x, y].Text = Convert.ToString((x) + "," + (y));//remove when done
                    //gameBtn[x, y].Image = Minesweeper.Properties.Resources.blankBtn;
                    gameBtn[x, y].MouseDown += new MouseEventHandler(gameBtnEvent_Click);
                    Controls.Add(hintGrid[x, y]); // add the hintGrid to the collection
                    Controls.Add(gameBtn[x, y]); // add the gameBtn to the collection
                    hintGrid[x, y].SendToBack(); // sends the hint to behind the button
                }
            }
        }

        // method to place mines in the logic grid
        private void placeMines(int numMines, int gridX, int gridY)
        {
            Random rand = new Random(); // initialize new instance to generate a pseudo-random number
            int minePosX, minePosY; // variables to hold x and y of the mine
            bool validPlace = false; // variable to hold whether a valid position in array
            for (int i = numMines; i > 0; i--) // loop until all mines are placed
            {
                do // do until the mine is in a valid place
                {
                    minePosX = rand.Next(gridX); // generate random x position
                    minePosY = rand.Next(gridY); // generate random y position
                    if (logicGrid[minePosX, minePosY] == 0) // if the position does not already have a mine
                        validPlace = true; // then it is a valid place
                    else // if there is a mine already there
                        validPlace = false; // then it isn't a valid place
                } while (validPlace == false);
                logicGrid[minePosX, minePosY] = 9; // set the position in the logic array to 9 to indicate a mine
            }
        }

        // method to calculate the number to be displayed when the button is selected
        private void calcHintNum(int numMines, int gridX, int gridY)
        {
            // checks logic grid between x1-7
            for (int x = 1; x < gridX; x++)
            {
                for (int y = 1; y < gridY; y++) // checks logic grid between y1-7
                {
                    if (logicGrid[x, y] >= 9) // if position is a mine
                    {
                        // adds 1 to the logic grid of the 8 positions around the mine
                        logicGrid[x - 1, y - 1] += 1;
                        logicGrid[x, y - 1] += 1;
                        logicGrid[x + 1, y - 1] += 1;
                        logicGrid[x - 1, y] += 1;
                        logicGrid[x + 1, y] += 1;
                        logicGrid[x - 1, y + 1] += 1;
                        logicGrid[x, y + 1] += 1;
                        logicGrid[x + 1, y + 1] += 1;
                    }
                }
            }
            // checks logic for top of grid except corners
            for (int x = 1, y = 0; x < gridX; x++)
            {
                if (logicGrid[x, y] >= 9) // if position is a mine
                {
                    // adds 1 to the logic grid of the 5 positions around the mine
                    logicGrid[x - 1, y] += 1;
                    logicGrid[x + 1, y] += 1;
                    logicGrid[x - 1, y + 1] += 1;
                    logicGrid[x, y + 1] += 1;
                    logicGrid[x + 1, y + 1] += 1;
                }
            }
            // checks logic for bottom of grid except corners
            for (int x = 1, y = gridY; x < gridX; x++)
            {
                if (logicGrid[x, y] >= 9) // if position is a mine
                {
                    // adds 1 to the logic grid of the 5 positions around the mine
                    logicGrid[x - 1, y - 1] += 1;
                    logicGrid[x, y - 1] += 1;
                    logicGrid[x + 1, y - 1] += 1;
                    logicGrid[x - 1, y] += 1;
                    logicGrid[x + 1, y] += 1;
                }
            }
            // checks logic for left side of grid except corners
            for (int y = 1, x = 0; y < gridY; y++)
            {
                if (logicGrid[x, y] >= 9) // if position is a mine
                {
                    // adds 1 to the logic grid of the 5 positions around the mine
                    logicGrid[x, y - 1] += 1;
                    logicGrid[x + 1, y - 1] += 1;
                    logicGrid[x + 1, y] += 1;
                    logicGrid[x, y + 1] += 1;
                    logicGrid[x + 1, y + 1] += 1;
                }
            }
            // checks logic for right side of grid except corners
            for (int y = 1, x = gridX; y < gridY; y++)
            {
                if (logicGrid[x, y] >= 9) // if position is a mine
                {
                    // adds 1 to the logic grid of the 5 positions around the mine
                    logicGrid[x - 1, y - 1] += 1;
                    logicGrid[x, y - 1] += 1;
                    logicGrid[x - 1, y] += 1;
                    logicGrid[x - 1, y + 1] += 1;
                    logicGrid[x, y + 1] += 1;
                }
            }
            // checks logic for top left corner
            if (logicGrid[0, 0] >= 9) // if position is a mine
            {
                // adds 1 to the logic grid of the 3 positions around the mine
                logicGrid[1, 0] += 1;
                logicGrid[0, 1] += 1;
                logicGrid[1, 1] += 1;
            }
            // checks logic for top right corner
            if (logicGrid[gridX, 0] >= 9) // if position is a mine
            {
                // adds 1 to the logic grid of the 3 positions around the mine
                logicGrid[gridX - 1, 0] += 1;
                logicGrid[gridX, 1] += 1;
                logicGrid[gridX - 1, 1] += 1;
            }
            // checks logic for bottom left corner
            if (logicGrid[0, gridY] >= 9) // if position is a mine
            {
                // adds 1 to the logic grid of the 3 positions around the mine
                logicGrid[1, gridY] += 1;
                logicGrid[0, gridY - 1] += 1;
                logicGrid[1, gridY - 1] += 1;
            }
            // checks logic for bottom right corner
            if (logicGrid[gridX, gridY] >= 9) // if position is a mine
            {
                // adds 1 to the logic grid of the 3 positions around the mine
                logicGrid[gridX - 1, gridY] += 1;
                logicGrid[gridX, gridY - 1] += 1;
                logicGrid[gridX - 1, gridY - 1] += 1;
            }

            // sets the hint values in logic grid to the label to display
            for (int x = 0; x < gridX + 1; x++) // loop on x axis
            {
                for (int y = 0; y < gridY + 1; y++) // loop on y axis
                {
                    hintGrid[x, y].Text = logicGrid[x, y].ToString(); // set the text of the label at x,y to a string value of the logic grid
                    if (hintGrid[x, y].Text == "0") // there is no mines connected to the label
                        hintGrid[x, y].Text = " "; // sets the text to blank string
                }
            }
        }

        // method to place the in game UI
        private void buildGameUI(int width, int height)
        {
            btnReset.Image = Minesweeper.Properties.Resources.happyFace;
            lblFlgRem.Location = new Point(10, 35); // set the location of the counter for flags remaining
            lblTimer.Location = new Point(width - 82, 35); // set the location for the timer
            btnReset.Location = new Point((width / 2) - 25, 32); // set the location for the reset button
            btnReset.BackColor = Color.White; //change the background color to white
            playUIVisible(true); // set the UI as visible
            lblFlgRem.Text = flgRem.ToString(); //set the value of the flgRem lbl to the string value of the flgRem int           
        }

        // currently for testing, maybe changed and used later. Shows hint numbers on button, makes winning easy
        private void changeBtnText(int gridX, int gridY)
        {
            for (int x = 0; x < gridX; x++)
            {
                for (int y = 0; y < gridY; y++)
                {
                    if (logicGrid[x, y] >= 9)
                        gameBtn[x, y].Text = "*";
                    else
                        gameBtn[x, y].Text = Convert.ToString(logicGrid[x, y]);
                }
            }
        }

        // event handler for clicking game buttons
        void gameBtnEvent_Click(object sender, MouseEventArgs e)
        {
            Button gameBtnRClick = sender as Button; // controls actions for when button is clicked  

            string[] btnPos = gameBtnRClick.Name.Split(new Char[] { ' ' }); // split the btn name to get the position in grid

            int posX = System.Convert.ToInt32(btnPos[0]); // convert to int and place in posX
            int posY = System.Convert.ToInt32(btnPos[1]); // convert to int and place in posY

            if (e.Button == MouseButtons.Right) // if right click on button
            {
                if (gameBtn[posX, posY].BackColor == Color.PowderBlue) // if the button has not been flagged
                {
                    gameBtn[posX, posY].BackColor = Color.Red; // set the back color to red, ie flagged
                    gameBtn[posX, posY].Image = Minesweeper.Properties.Resources.flag; // change the image to the flag
                    flgRem--; // decrement flag remaining variable
                    lblFlgRem.Text = flgRem.ToString(); // update the flag remaining label
                }
                else if (gameBtn[posX, posY].BackColor == Color.Red) // else if the button has been flagged
                {
                    gameBtn[posX, posY].BackColor = Color.PowderBlue; // set back color to powder blue, ie not flagged
                    gameBtn[posX, posY].Image = Minesweeper.Properties.Resources.tile; // change the image back to the tile
                    flgRem++; // increment flag remaining variable
                    lblFlgRem.Text = flgRem.ToString(); // update the flag remaining label
                }
            }
            else if (e.Button == MouseButtons.Left && gameBtn[posX, posY].BackColor == Color.PowderBlue) // else if left click and not flagged
            {
                if (logicGrid[posX, posY] > 8) // if the button is a mine
                {
                    scoreTimer.Stop(); // stop the timer
                    for (int x = 0; x < gameBtn.GetLength(0); x++) // loop for x axis
                    {
                        for (int y = 0; y < gameBtn.GetLength(1); y++) // loop for y axis
                        {
                            if (logicGrid[x, y] > 8) // if the position is a mine
                            {
                                gameBtn[x, y].Visible = false; // make button invisible
                            }
                        }
                    }
                    losingMineCoord[0] = posX.ToString(); // set losing coord x in array
                    losingMineCoord[1] = posY.ToString(); // set losing coord y in array
                    gameOverLoss(); // call the method to handle the loss
                }
                else // else if the button is not a mine
                {
                    removeZeroBtn(posX, posY); // call the method to remove the buttons connected that are near no mines
                    gameBtnRClick.Visible = false; // make button invisible
                    if (btnCounter == 0) // check if game is won, ie 0 non mine buttons left
                    {
                        gameOverWin(); // call method to handle the win
                    }
                }
            }
        }

        // method to write the current high scores to the text file
        private void writeScores()
        {
            System.IO.StreamWriter outFile = new System.IO.StreamWriter("highScores.txt"); // initialises a new instance of streamwriter for the highscores file
            for (int i = 0; i < 3; i++) // loop for the 3 difficulties
                outFile.WriteLine(highScoreArr[i, 0] + "," + highScoreArr[i, 1]); // write the name, then a comma, then the time
            outFile.Close(); // close the file
        }

        //Method the high score file and place it in the high score array
        //Adapted from code on MSDN site: https://msdn.microsoft.com/en-GB/library/aa287535(v=vs.71).aspx
        private void readFiles()
        {
            if (File.Exists("highScores.txt") == true) // check if the highscores file exists
            {
                System.IO.StreamReader inFile = new System.IO.StreamReader("highScores.txt"); // initalises a new instance of streamreader for the highscores file
                string line; // stores the current file line
                char delim = ','; // sets a delim character to split the strings.

                for (int i = 0; i < 3; i++) // loop for the 3 difficulties
                {
                    line = inFile.ReadLine(); // read file line into line
                    string[] split = line.Split(delim); // split line into string array split
                    for (int k = 0; k < 2; k++) // loop twice
                        highScoreArr[i, k] = split[k]; // put the name and time into different array positions
                }
                inFile.Close(); // close the file
            }
            else // else if the file doesn't exist
            {
                for (int i = 0; i < 3; i++) // loop for the 3 difficulties
                {
                    highScoreArr[i, 0] = "No High Score"; // set the name to No High Score
                    highScoreArr[i, 1] = "999"; // set the time to 999
                }
                writeScores(); // write to a new file
            }
        }

        // method to handle what happens if the user wins the game
        private void gameOverWin()
        {
            scoreTimer.Stop(); // stop the score timer
            btnReset.Image = Minesweeper.Properties.Resources.sunFace;
            for (int x = 0; x < gameBtn.GetLength(0); x++) // loop for the x axis
            {
                for (int y = 0; y < gameBtn.GetLength(1); y++) // loop for the y axis
                {
                    gameBtn[x, y].Enabled = false; // disable the buttons so the user can't click them
                }
            }
            btnReset.BackColor = Color.Purple; // sets the background color to purple
            if (diff == 4) // if it's a custom game then return as no high scores will be saved
                return;
            if (timer < System.Convert.ToInt32(highScoreArr[diff - 1, 1])) // if the time was a new high score
            {
                Minesweeper.highScore highScore = new Minesweeper.highScore(); // create a new instance of highScore called highScore
                highScore.ShowDialog(); // show the dialog box to get the user to insert their name
                highScoreArr[diff - 1, 0] = userName; // store the username in the correct array position
                highScoreArr[diff - 1, 1] = timer.ToString(); // store the string value of the time in the correct position
                writeScores(); // call method to write to the file
            }
            else // else if they didn't beat the high score
            {
                DialogResult winPop; // create a dialog box for if they didn't beat the high score then show the dialog box on screen
                winPop = MessageBox.Show("You won however you didn't beat the high score.", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // method to handle what happens if the user loses the game
        private void gameOverLoss()
        {
            scoreTimer.Stop(); // stop the score timer
            btnReset.Image = Minesweeper.Properties.Resources.sadFace;
            //DialogResult lossPop; // show a popup box to tell them they lost. Remove because it was annoying
            //lossPop = MessageBox.Show("You Lost.", "Loser", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int x = 0; x < gameBtn.GetLength(0); x++) // loop for x axis
            {
                for (int y = 0; y < gameBtn.GetLength(1); y++) // loop for y axis
                {
                    if (logicGrid[x, y] > 8)
                    {;
                        hintGrid[x, y].Text = "";
                        hintGrid[x, y].Image = Minesweeper.Properties.Resources.mineGrey;
                        hintGrid[System.Convert.ToInt32(losingMineCoord[0]), System.Convert.ToInt32(losingMineCoord[1])].Image = Minesweeper.Properties.Resources.mineRed;
                    }
                    gameBtn[x, y].Enabled = false; // disable the game buttons
                }
            }
            timer = 0; // set the int timer value to 0
        }

        // method to destroy the old unused game grid arrays
        private void destroyGrid()
        {
            if (gameBtn != null) // if a gameBtn exists
            {
                scoreTimer.Stop(); // stop the score timer
                timer = 0; // set the int timer to 0
                for (int x = 0; x < gameBtn.GetLength(0); x++) // loop for x axis
                {
                    for (int y = 0; y < gameBtn.GetLength(1); y++) // loop for y axis
                    {
                        Controls.Remove(gameBtn[x, y]); // remove the button from the collection
                        Controls.Remove(hintGrid[x, y]); // remove the label from the collection
                        logicGrid[x, y] = 0; // set the logic grid position to 0
                    }
                }
            }
            this.AutoSize = false; // set autosize to false, allows the user to resize the window.
        }

        // function to remove the buttons for points that are 0
        void removeZeroBtn(int posX, int posY)
        {
            int[] posToCheck = new int[2]; // creates an array to hold the x and y of the position to check
            if (gameBtn[posX, posY].Visible == false) // if the button is invisible
                return; // return from function
            else // else it is visible
            {
                gameBtn[posX, posY].Visible = false; // make button invisible
                btnCounter--; // decrement the counter for number of buttons left
                for (int i = -1; i < 2; i++) // for the x positions around the button
                {
                    for (int j = -1; j < 2; j++) // for the y positions around the button
                    {
                        posToCheck[0] = posX + i; // set the x posToCheck to the x coord
                        posToCheck[1] = posY + j; // set the y posToCheck to the y coord
                        if (posToCheck[0] > -1 && posToCheck[1] > -1) // if he position is in the bounds of the array
                        {
                            if (posToCheck[0] < gameBtn.GetLength(0) && posToCheck[1] < gameBtn.GetLength(1))
                            {
                                gameBtn[posX, posY].Visible = false; // make button invisible
                                if (logicGrid[posX, posY] == 0) // if the logic grid holds a 0
                                    removeZeroBtn(posX + i, posY + j); // recursion to remove connected 0's
                            }
                        }
                    }
                }
            }
        }

        // event handler for clicking the intermediate difficulty button
        private void btnInt_Click(object sender, EventArgs e)
        {
            playInt(); // calls the method to play on int difficulty
        }

        // class that sets up and handles playing on intermediate
        private void playInt()
        {
            int winWidth = 510, winHeight = 620; // declares int variables to be used for form height and width
            this.Width = winWidth; // sets the form width to 510
            this.Height = winHeight; // sets the form height to 620

            diffMenuVisible(false); // Hides difficulty selection buttons

            diff = 2; // sets diff to 2 to indicate intermediate difficulty
            int gridX = 16, gridY = 16; // declares variables to be used for grid width and height and sets them to 16
            int numMines = 40; // variable for number of mines
            btnCounter = 216; // sets btnCounter to 216 to be used to detect if the user has won
            flgRem = numMines; // sets class variable that stores the number of flags left to numMines

            gameBtn = new Button[gridX, gridY]; // creates an array of buttons of size specified earlier
            hintGrid = new Label[gridX, gridY]; // creates an array of labels to go under the buttons for the hint numbers
            logicGrid = new int[gridX, gridY]; // creates an int array to store the hint numbers and mine positions

            buildGameUI(winWidth, winHeight); // calls method to build the gameUI and passes in form dimensions
            buildGrid(gridX, gridY); // calls method to build the grid and passes in the grid dimensions
            placeMines(numMines, gridX - 1, gridY - 1); // calls method to place the mines and passes in the number of mines and the grid size -1
            calcHintNum(numMines, gridX - 1, gridY - 1); // calls method to calculate the hint numbers for the positions without mines
            scoreTimer.Start(); // starts the timer
            //changeBtnText(gridX, gridY);
        }

        // event handler for the expert difficulty button
        private void btnExpert_Click(object sender, EventArgs e)
        {
            playExpert(); // calls method for playing on expert
        }

        private void playExpert()
        {
            int winWidth = 750, winHeight = 860; // declares int variables to be used for form height and width
            this.Width = winWidth; // sets the form width to 750
            this.Height = winHeight; // sets the form height to 860

            diffMenuVisible(false); // hides difficulty selection buttons

            diff = 3; // sets diff to 1 to indicate beginner difficulty
            int gridX = 24, gridY = 24; // declares variables to be used for grid width and height and sets them to 24
            int numMines = 99; // variable for number of mines
            btnCounter = 477; // sets btnCounter to 477 to be used to detect if the user has won
            flgRem = numMines; // sets class variable that stores the number of flags left to numMines

            gameBtn = new Button[gridX, gridY]; // creates an array of buttons of size specified earlier
            hintGrid = new Label[gridX, gridY]; // creates an array of labels to go under the buttons for the hint numbers
            logicGrid = new int[gridX, gridY]; // creates an int array to store the hint numbers and mine positions

            buildGameUI(winWidth, winHeight); // calls method to build the gameUI and passes in form dimensions
            buildGrid(gridX, gridY); // calls method to build the grid and passes in the grid dimensions
            placeMines(numMines, gridX - 1, gridY - 1); // calls method to place the mines and passes in the number of mines and the grid size -1
            calcHintNum(numMines, gridX - 1, gridY - 1); // calls method to calculate the hint numbers for the positions without mines
            scoreTimer.Start(); // starts the timer
            //changeBtnText(gridX, gridY);
        }
        
        // event handler for exit in the strip menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // closes the form
        }

        // tick handler for the timer
        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            timer++;
            lblTimer.Text = timer.ToString();
        }

        // event handler for the reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            destroyGrid();
            lblTimer.Text = "0";
            if (diff == 1)
                playBeg();
            else if (diff == 2)
                playInt();
            else if (diff == 3)
                playExpert();
            else if (diff == 4)
                playCustom();
        }

        // event handler for beginner in the strip menu
        private void beginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            destroyGrid(); // calls method to destroy grid
            mainMenuVisible(false); // makes the main menu invisible
            playBeg(); // calls method to play on beginner
        }
        // event handler for intermediate in the strip menu
        private void intermediateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            destroyGrid(); // calls method to destroy grid
            mainMenuVisible(false); // makes the main menu invisible
            playInt(); // calls method to play on intermediate
        }
        // event handler for expert in the strip menu
        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            destroyGrid(); // calls method to destroy grid
            mainMenuVisible(false); // makes the main menu invisible
            playExpert(); // calls method to play on expert
        }

        // event handler for menu button shown on high score screen
        private void btnMenu_Click(object sender, EventArgs e)
        {
            mainMenuVisible(true); // shows the main menu
            btnMenu.Visible = false; // hides the menu button
            highScoreVisible(false); // hides the high scores
        }

        // event handler for reseting the high scores in the strip menu
        private void resetHighScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++) // loop for the 3 difficulties
            {
                highScoreArr[i, 0] = "No High Score";  // set the name to No High Score
                highScoreArr[i, 1] = "999"; // set the time to 999
            }
            writeScores(); // write to file
        }

        // event handler for viewing high scores from the strip menu
        private void viewHighScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            destroyGrid(); // destroy the current game
            this.Width = 600; // set form width to 600px
            this.Height = 500; // set form height to 500px
            playUIVisible(false); // hide the game ui
            showHighScore(); // call method to show high scores
        }

        // event handler for the main menu option from the strip menu
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            destroyGrid(); // destroy the current game
            this.Width = 600; // set form width to 600px
            this.Height = 500; // set form height to 500px
            playUIVisible(false); // hide the game ui
            mainMenuVisible(true); // make the main menu visible
        }

        // event handler for the about option on the strip menu. Display info about the game
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult about;
            about = MessageBox.Show("Minesweeper in C# by Josh Corps (c) 2016", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // event handler for how to play from the strip menu. Shows short instructions from: http://windows.microsoft.com/en-gb/windows/minesweeper-how-to#1TC=windows-7
        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult howTo;
            howTo = MessageBox.Show("The rules in Minesweeper are simple: Uncover a mine, and the game ends. Uncover an empty square, and you keep playing. Uncover a number, and it tells you how many mines lay hidden in the eight surrounding squares—information you use to deduce which nearby squares are safe to click.", "How to Play", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // event handler for custom game from strip menu
        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 600; // sets the width of the form to 600px
            this.Height = 500; // sets the height of the form to 500px
            destroyGrid(); // calls the destroy method to clean up the old game
            playUIVisible(false); // removes the game ui from view
            mainMenuVisible(false); // removes the main menu from view
            diffMenuVisible(false); // removes the difficulty menu from view
            customChoicesVisible(true); // shows the choices for a custom game to the user
        }
    }
}