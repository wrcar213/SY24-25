using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BinaryConverter
{
    public partial class Form1 : Form
    {
        int Total = 0;
        int TotalB = 0;
        int TotalC = 0;
        int[] bits = new int[8];
        int[] Bbits = new int[8];
        int[] Cbits = new int[8];
        public Form1()
        {
            InitializeComponent();
        }
        private void Calc()
        {
            //clear the total
            Total = 0;


            if (Bit1.Text == "1") bits[0] = 1;
            else bits[0] = 0;
            //bit1
            if (Bit2.Text == "1") bits[1] = 1;
            else bits[1] = 0;
            //bit2
            if (Bit3.Text == "1") bits[2] = 1;
            else bits[2] = 0;
            //bit3
            if (Bit4.Text == "1") bits[3] = 1;
            else bits[3] = 0;
            //bit4
            if (Bit5.Text == "1") bits[4] = 1;
            else bits[4] = 0;
            //bit5
            if (Bit6.Text == "1") bits[5] = 1;
            else bits[5] = 0;
            //bit6
            if (Bit7.Text == "1") bits[6] = 1;
            else bits[6] = 0;
            //bit7
            if (Bit8.Text == "1") bits[7] = 1;
            else bits[7] = 0;
            //bit8

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] != 0)
                {
                    Total += (int)Math.Pow(2, i);
                }
            }


            label1.Text = Total.ToString();
        }
        private void CalcB()
        {

            if (bBit1.Text == "1") Bbits[0] = 1;
            else Bbits[0] = 0;
            //bit1
            if (bBit2.Text == "1") Bbits[1] = 1;
            else Bbits[1] = 0;
            //bit2
            if (bBit3.Text == "1") Bbits[2] = 1;
            else Bbits[2] = 0;
            //bit3
            if (bBit4.Text == "1") Bbits[3] = 1;
            else Bbits[3] = 0;
            //bit4
            if (bBit5.Text == "1") Bbits[4] = 1;
            else Bbits[4] = 0;
            //bit5
            if (bBit6.Text == "1") Bbits[5] = 1;
            else Bbits[5] = 0;
            //bit6
            if (bBit7.Text == "1") Bbits[6] = 1;
            else Bbits[6] = 0;
            //bit7
            if (bBit8.Text == "1") Bbits[7] = 1;
            else Bbits[7] = 0;
            //bit8

            TotalB = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (Bbits[i] != 0)
                {
                    TotalB += (int)Math.Pow(2, i);
                }
            }
            label2.Text = TotalB.ToString();
        }
        private void CalcC()
        {
            TotalC = 0;

            if (cBits1.Text == "1") Cbits[0] = 1;
            else Cbits[0] = 0;
            //bit1
            if (cBits2.Text == "1") Cbits[1] = 1;
            else Cbits[1] = 0;
            //bit2
            if (cBits3.Text == "1") Cbits[2] = 1;
            else Cbits[2] = 0;
            //bit3
            if (cBits4.Text == "1") Cbits[3] = 1;
            else Cbits[3] = 0;
            //bit4
            if (cBits5.Text == "1") Cbits[4] = 1;
            else Cbits[4] = 0;
            //bit5
            if (cBits6.Text == "1") Cbits[5] = 1;
            else Cbits[5] = 0;
            //bit6
            if (cBits7.Text == "1") Cbits[6] = 1;
            else Cbits[6] = 0;
            //bit7
            if (cBits8.Text == "1") Cbits[7] = 1;
            else Cbits[7] = 0;
            //bit8

            TotalC = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (Cbits[i] != 0)
                {
                    TotalC += (int)Math.Pow(2, i);
                }
            }

            label3.Text = TotalC.ToString();
        }


        private void update()
        {
            Bit1.Text = (bits[0] == 1 ? "1" : "0");
            Bit2.Text = (bits[1] == 1 ? "1" : "0");
            Bit3.Text = (bits[2] == 1 ? "1" : "0");
            Bit4.Text = (bits[3] == 1 ? "1" : "0");
            Bit5.Text = (bits[4] == 1 ? "1" : "0");
            Bit6.Text = (bits[5] == 1 ? "1" : "0");
            Bit7.Text = (bits[6] == 1 ? "1" : "0");
            Bit8.Text = (bits[7] == 1 ? "1" : "0");

            bBit1.Text = (Bbits[0] == 1 ? "1" : "0");
            bBit2.Text = (Bbits[1] == 1 ? "1" : "0");
            bBit3.Text = (Bbits[2] == 1 ? "1" : "0");
            bBit4.Text = (Bbits[3] == 1 ? "1" : "0");
            bBit5.Text = (Bbits[4] == 1 ? "1" : "0");
            bBit6.Text = (Bbits[5] == 1 ? "1" : "0");
            bBit7.Text = (Bbits[6] == 1 ? "1" : "0");
            bBit8.Text = (Bbits[7] == 1 ? "1" : "0");

            cBits1.Text = (Cbits[0] == 1 ? "1" : "0");
            cBits2.Text = (Cbits[1] == 1 ? "1" : "0");
            cBits3.Text = (Cbits[2] == 1 ? "1" : "0");
            cBits4.Text = (Cbits[3] == 1 ? "1" : "0");
            cBits5.Text = (Cbits[4] == 1 ? "1" : "0");
            cBits6.Text = (Cbits[5] == 1 ? "1" : "0");
            cBits7.Text = (Cbits[6] == 1 ? "1" : "0");
            cBits8.Text = (Cbits[7] == 1 ? "1" : "0");
            Calc();
            CalcB();
            CalcC();
        }
        private void cBits1_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "0") ((TextBox)sender).Text = "1";
            else ((TextBox)sender).Text = "0";

            Calc();
            CalcB();
            CalcC();

            update();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++) { bits[i] = 0; update(); }
        }

        private void clearbuttonB_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Bbits.Length; i++) { Bbits[i] = 0; update(); }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++) { bits[i] = 0; update(); }
            for (int i = 0; i < Bbits.Length; i++) { Bbits[i] = 0; update(); }
            for (int i = 0; i < Cbits.Length; i++) { Cbits[i] = 0; update(); }
        }
        private void shift_right(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length - 1; i++)
            {

                bits[i] = bits[i + 1];

            }
            bits[7] = 0;
            update();
        }

        private void shift_left(object sender, EventArgs e)
        {
            for (int i = Bbits.Length - 1; i > 0; i--)
            {
                Bbits[i] = Bbits[i - 1];
            }
            Bbits[0] = 0;
            update();
        }

        private void ANDIT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] * Bbits[i] == 1) { Cbits[i] = 1; }
                if (bits[i] * Bbits[i] == 0) { Cbits[i] = 0; }

                update();
            }
        }

        private void ORIT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 0 || Bbits[i] == 1) { Cbits[i] = 1; }
                if (bits[i] == 1 || Bbits[i] == 0) { Cbits[i] = 1; }
                if (bits[i] == 0 || Bbits[i] == 0) { Cbits[i] = 0; }
                if (bits[i] == 1 || Bbits[i] == 1) { Cbits[i] = 1; }

                update();
            }
        }

        private void XORIT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1 || Bbits[i] == 1) { Cbits[i] = 0; }
                if (bits[i] == 0 || Bbits[i] == 0) { Cbits[i] = 0; }
                if (bits[i] == 0 && Bbits[i] == 1) { Cbits[i] = 1; }
                if (bits[i] == 1 && Bbits[i] == 0) { Cbits[i] = 1; }

                update();
            }
        }

        private void ADDIT_Click(object sender, EventArgs e)
        {
            int carry = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                // Calculate the sum of the current bits and the carry
                int sum = bits[i] + Bbits[i] + carry;

                // Determine the resulting bit and the new carry
                if (sum == 0)
                {
                    Cbits[i] = 0;
                    carry = 0;
                }
                else if (sum == 1)
                {
                    Cbits[i] = 1;
                    carry = 0;
                }
                else if (sum == 2)
                {
                    Cbits[i] = 0;
                    carry = 1;
                }
                else // sum == 3
                {
                    Cbits[i] = 1;
                    carry = 1;
                }
            }

            // If there's a carry left after the last addition, handle it
            if (carry == 1)
            {
                // Assuming Cbits has enough space to accommodate an extra bit
                Cbits[bits.Length] = 1; // This will be the carry bit
            }

            update();
        }


    }
}

