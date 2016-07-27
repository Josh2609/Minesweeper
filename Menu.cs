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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Hide menu for choosing options
            btnNew.Visible = false;
            btnResume.Visible = false;
            btnHighScore.Visible = false;
            btnExit.Visible = false;

            // Draw new menu for choosing difficulty
            btnBeg.Visible = true;
            btnInt.Visible = true;
            btnExpert.Visible = true;
            btnCustom.Visible = true;
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {

        }

        private void btnResume_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {

        }

        private Button[,] gameBtn;      // Create 2D array of buttons
        private int[,] logicGrid; // stores grid as int for game logic
        private int[] minePositions; // stores the position of the mines in the logic grid
        private Label[,] hintGrid; // stores the hint numbers as labels to be shown when the button is clicked
        private string[,,] highScoreArr = new string [3,25,25]; // array to store 25 high scores for the 3 difficulties

        private void playBeg()
        {
            // Hides difficulty selection buttons
            btnBeg.Visible = false;
            btnInt.Visible = false;
            btnExpert.Visible = false;
            btnCustom.Visible = false;

            int gridX = 9, gridY = 9;
            int numMines = 10;

            gameBtn = new Button[gridX, gridY];
            hintGrid = new Label[gridX, gridY];
            logicGrid = new int[gridX, gridY];
            minePositions = new int[numMines];

            buildGrid(gridX, gridY);
            placeMines(numMines, gridX - 1, gridY - 1);
            calcHintNum(numMines, gridX - 1, gridY - 1);
            //changeBtnText(gridX, gridY);
        }

        private void btnBeg_Click(object sender, EventArgs e)
        {
            playBeg();
        }

        private void buildGrid(int gridX, int gridY)
        {
            for (int x = 0; x < gridX; x++)         // Loop for x
            {
                for (int y = 0; y < gridY; y++)     // Loop for y
                {
                    logicGrid[x, y] = 0;
                    gameBtn[x, y] = new Button();

                    hintGrid[x, y] = new Label();
                    //hintGrid[x, y].Text = x.ToString() + " " + y.ToString();
                    hintGrid[x, y].Name = x.ToString() + " " + y.ToString();
                    hintGrid[x, y].SetBounds(30 * x + 20, 30 * y + 80, 30, 30);
                    hintGrid[x, y].TextAlign = ContentAlignment.MiddleCenter;
                    hintGrid[x, y].BorderStyle = BorderStyle.FixedSingle;

                    gameBtn[x, y].Name = x.ToString() + " " + y.ToString();
                    gameBtn[x, y].SetBounds(30 * x + 20, 30 * y + 80, 30, 30);
                    gameBtn[x, y].BackColor = Color.PowderBlue;
                    //gameBtn[x, y].Text = Convert.ToString((x) + "," + (y));//remove when done
                    // gameBtn[x, y].Image = Minesweeper.Properties.Resources.blankBtn;
                    gameBtn[x, y].Click += new EventHandler(this.gameBtnEvent_Click);
                    gameBtn[x, y].MouseDown += new MouseEventHandler(gameBtnEvent_rClick);
                    Controls.Add(hintGrid[x, y]);
                    Controls.Add(gameBtn[x, y]);
                    hintGrid[x, y].SendToBack(); // sends the hint to behind the button
                }
            }
        }

        private void placeMines(int numMines, int gridX, int gridY)
        {
            Random rand = new Random();
            int minePosX;
            int minePosY;
            bool validPlace = false;
            for (int i = numMines; i > 0; i-- )
            {
                do
                {
                    minePosX = rand.Next(gridX);
                    minePosY = rand.Next(gridY);
                    if (logicGrid[minePosX, minePosY] == 0)
                        validPlace = true;
                    else
                        validPlace = false;
                } while (validPlace == false);
            logicGrid[minePosX, minePosY] = 9; // 9 on logicGrid means it's a mine
            }
        }

        private void calcHintNum(int numMines, int gridX, int gridY)
        {
            // checks logic grid between 1-7
            for (int x = 1; x < gridX; x++)
            {
                for (int y = 1; y < gridY; y++)
                {
                    if (logicGrid[x, y] >= 9)
                    { // need to handle if mine at edge of grid  
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
                if (logicGrid[x, y] >= 9)
                {            
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
                if (logicGrid[x, y] >= 9)
                {
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
                if (logicGrid[x, y] >= 9)
                {
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
                if (logicGrid[x, y] >= 9)
                {
                    logicGrid[x - 1, y - 1] += 1;
                    logicGrid[x, y - 1] += 1;
                    logicGrid[x - 1, y] += 1;
                    logicGrid[x - 1, y + 1] += 1;
                    logicGrid[x, y + 1] += 1;
                }
            }
            // checks logic for top left corner
            if (logicGrid[0, 0] >= 9)
            {
                logicGrid[1, 0] += 1;
                logicGrid[0, 1] += 1;
                logicGrid[1, 1] += 1;
            }
            // checks logic for top right corner
            if (logicGrid[gridX, 0] >= 9)
            {
                logicGrid[gridX - 1, 0] += 1;
                logicGrid[gridX, 1] += 1;
                logicGrid[gridX - 1, 1] += 1;
            }
            // checks logic for bottom left corner
            if (logicGrid[0, gridY] >= 9)
            {
                logicGrid[1, gridY] += 1;
                logicGrid[0, gridY - 1] += 1;
                logicGrid[1, gridY - 1] += 1;
            }
            // checks logic for bottom right corner
            if (logicGrid[gridX, gridY] >= 9)
            {
                logicGrid[gridX - 1, gridY] += 1;
                logicGrid[gridX, gridY - 1] += 1;
                logicGrid[gridX - 1, gridY - 1] += 1;
            }

            // sets the hint values in logic grid to the label to display
            for (int x = 0; x < gridX + 1; x++)
            {
                for (int y = 0; y < gridY + 1; y++)
                {
                    hintGrid[x, y].Text = logicGrid[x, y].ToString();
                    if (hintGrid[x, y].Text == "0")
                        hintGrid[x, y].Text = " ";
                }
            }
        }

        // currently for testing, maybe changed and used later
        private void changeBtnText(int gridX, int gridY)
        {
            for (int x = 0; x < gridX; x++)
            {
                for (int y = 0; y < gridY; y++)
                {
                    if (logicGrid[x, y] >= 9)
                        gameBtn[x, y].Text = "*";
                    else
                    {
                        string temp = Convert.ToString(logicGrid[x, y]);
                        gameBtn[x, y].Text = temp;
                    }
                }
            }
        }

        //*********************************************************************change
        void gameBtnEvent_rClick(object sender, MouseEventArgs e)
        {
            Button gameBtnRClick = sender as Button;

            string[] btnPos = gameBtnRClick.Name.Split(new Char[] { ' ' });

            int x = System.Convert.ToInt32(btnPos[0]);
            int y = System.Convert.ToInt32(btnPos[1]);

            if(e.Button == MouseButtons.Right)
            {
                gameBtn[x,y].BackColor = SystemColors.Control;
            }
                   
        }

        private void gameOver()
        { //working here

        }

        void gameBtnEvent_Click(object sender, System.EventArgs e)
        {// doing stuff here
            
            Button gameBtnClick = sender as Button;
            string[] btnPos = gameBtnClick.Name.Split(new Char[] { ' ' });

            int posX = System.Convert.ToInt32(btnPos[0]);
            int posY = System.Convert.ToInt32(btnPos[1]);

            if (logicGrid[posX, posY] > 8)
            {
                for (int xx = 0; xx < gameBtn.GetLength(0); xx++)
                {
                    for (int yy = 0; yy < gameBtn.GetLength(1); yy++)
                    {
                        if (logicGrid[xx, yy] > 8)
                        {
                            gameBtn[xx, yy].Visible = false;
                        }

                    }
                }
            }
            hideBtn(posX, posY);
            gameBtnClick.Visible = false;
        }

        // fix 9's for actual width
        void hideBtn(int posX, int posY)
        {

            if (!gameBtn[posX, posY].Visible)
                return;
            else 
            {
                gameBtn[posX, posY].Visible = false;
                for (int xx = -1; xx < 2; xx++)
                {
                    for (int yy = -1; yy < 2; yy++)
                    {
                        if (posX + xx >= 0 && posY + yy >= 0 && posX + xx < gameBtn.GetLength(0) && posY + yy < gameBtn.GetLength(1))
                        {
                            gameBtn[posX, posY].Visible = false;
                            if (logicGrid[posX, posY] == 0)
                                hideBtn(posX + xx, posY + yy);
                        }
                    }
                }
            }
        }
        //*********************************************************************change

        private void btnInt_Click(object sender, EventArgs e)
        {
            // Hides difficulty selection buttons
            btnBeg.Visible = false;
            btnInt.Visible = false;
            btnExpert.Visible = false;
            btnCustom.Visible = false;
           
            int gridX = 16, gridY = 16;
            int numMines = 40;

            gameBtn = new Button[gridX, gridY];
            logicGrid = new int[gridX, gridY];
            minePositions = new int[numMines];

            buildGrid(gridX, gridY);
            placeMines(numMines, gridX - 1, gridY - 1);
            calcHintNum(numMines, gridX - 1, gridY - 1);
            changeBtnText(gridX, gridY);
        }

        private void btnExpert_Click(object sender, EventArgs e)
        {
            // Hides difficulty selection buttons
            btnBeg.Visible = false;
            btnInt.Visible = false;
            btnExpert.Visible = false;
            btnCustom.Visible = false;

            int gridX = 24, gridY = 24;
            int numMines = 99;

            gameBtn = new Button[gridX, gridY];
            logicGrid = new int[gridX, gridY];
            minePositions = new int[numMines];

            buildGrid(gridX, gridY);
            placeMines(numMines, gridX - 1, gridY - 1);
            calcHintNum(numMines, gridX - 1, gridY - 1);
            changeBtnText(gridX, gridY);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void beginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playBeg();
        }

        private void submitHS_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

