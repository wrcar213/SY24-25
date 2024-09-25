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
    public partial class Form1 : Form
    {
        Button[] btngrid = new Button[100];
        Tile[] tilegrid = new Tile[100];
        Random Random = new Random();
        public Form1()
        {
            InitializeComponent();
            Reset();


        }
        private Button GetButton(int r, int c)
        {
            return (Button)GetButton(r, c);
        }
        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal - 1;
        }
        private void SetCounts()
        {
            //For every square on the board 
            for (int i = 0; i < 100; i++)
            {
                tilegrid[i].SetNearby(i);
            }
            //Add 1 for each adjacent mine
            //Set that count into the tile
        }


        private void button91_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            Tile t = tilegrid[getIndex(b)];

            if (e.Button == MouseButtons.Right)
                t.SetFlag();
            else
                t.SetDug();
        }


        private void CreateMines(int numMines)
        {
            int MineCount = 0;
            //until we have enough mines
            while (MineCount < numMines)
            {
                //generate num 1-100
                int rNum = Random.Next(0, 100);
                //set mine on that tile if it doesn't already have a mine
                if (tilegrid[rNum].GetMine() == false)
                {
                    MineCount++;
                    tilegrid[rNum].SetMine(true);
                }
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            for (int i = 0; i < 100; i++)
            {
                btngrid[i] = (Button)Controls["button" + (i + 1)];
                tilegrid[i] = new Tile(btngrid[i]);
                tilegrid[i].SetFlagImage(FlagPictureBox.Image);
                tilegrid[i].SetMineImage(MinePictureBox.Image);
            }
            CreateMines(5);
        }
    }
}
