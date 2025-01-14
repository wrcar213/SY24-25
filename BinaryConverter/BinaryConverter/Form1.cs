using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConverter
{
    public partial class Form1 : Form
    {
        int total = 0;
        int[] bits = new int[8];
        int totalb2 = 0;
        int[] bitsb2 = new int[8];
        public Form1()
        {
            InitializeComponent();
        }
        private void Calc()
        {
            //clear the total
            total = 0;
            if (bits[0] != 0) total += 1;
            if (bits[1] != 0) total += 2;
            if (bits[2] != 0) total += 4;
            if (bits[3] != 0) total += 8;
            if (bits[4] != 0) total += 16;
            if (bits[5] != 0) total += 32;
            if (bits[6] != 0) total += 64;
            if (bits[7] != 0) total += 128;
            label1.Text = total.ToString();
        }
        private void CalcB2()
        {
            //calculate the total
            totalb2 = 0;
            if (bitsb2[0] != 0) totalb2 += 1;
            if (bitsb2[1] != 0) totalb2 += 2;
            if (bitsb2[2] != 0) totalb2 += 4;
            if (bitsb2[3] != 0) totalb2 += 8;
            if (bitsb2[4] != 0) totalb2 += 16;
            if (bitsb2[5] != 0) totalb2 += 32;
            if (bitsb2[6] != 0) totalb2 += 64;
            if (bitsb2[7] != 0) totalb2 += 128;
            label2.Text = totalb2.ToString();
        }

        private void bit0_TextChanged(object sender, EventArgs e)
        {
            //bit1
            if (bit1.Text == "1")
                bits[0] = 1;
            else
                bits[0] = 0;
            //bit2
            if (bit2.Text == "1")
                bits[1] = 1;
            else
                bits[1] = 0;
            //bit3
            if (bit3.Text == "1")
                bits[2] = 1;
            else
                bits[2] = 0;
            //bit4
            if (bit4.Text == "1")
                bits[3] = 1;
            else
                bits[3] = 0;
            //bit5
            if (bit5.Text == "1")
                bits[4] = 1;
            else
                bits[4] = 0;
            //bit6
            if (bit6.Text == "1")
                bits[5] = 1;
            else
                bits[5] = 0;
            //bit7
            if (bit7.Text == "1")
                bits[6] = 1;
            else
                bits[6] = 0;
            //bit8
            if (bit8.Text == "1")
                bits[7] = 1;
            else
                bits[7] = 0;


            Calc();





            label1.Text = total.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textboxs
            //bit1
            if (textBox1.Text == "1")
                bitsb2[0] = 1;
            else
                bitsb2[0] = 0;
            //bit2
            if (textBox2.Text == "1")
                bitsb2[1] = 1;
            else
                bitsb2[1] = 0;
            //bit3
            if (textBox3.Text == "1")
                bitsb2[2] = 1;
            else
                bitsb2[2] = 0;
            //bit4
            if (textBox4.Text == "1")
                bitsb2[3] = 1;
            else
                bitsb2[3] = 0;
            //bit5
            if (textBox5.Text == "1")
                bitsb2[4] = 1;
            else
                bitsb2[4] = 0;
            //bit6
            if (textBox6.Text == "1")
                bitsb2[5] = 1;
            else
                bitsb2[5] = 0;
            //bit7
            if (textBox7.Text == "1")
                bitsb2[6] = 1;
            else
                bitsb2[6] = 0;
            //bit8
            if (textBox8.Text == "1")
                bitsb2[7] = 1;
            else
                bitsb2[7] = 0;
            CalcB2();
        }
    }
}

