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


        private void button91_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Red;
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
                btngrid[i].BackColor = Color.Green;
                tilegrid[i] = new Tile(btngrid[i]);
            }
        }
    }
}
