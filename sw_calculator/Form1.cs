using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sw_calculator
{
    public enum Operators
    {
        Plus,
        Minus,
        Multi,
        Div,
        Remain
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int result = 0;

        public bool isNewNum = true;

        

        private void NumButton_click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        public void SetNum(String num)
        {
            if(isNewNum)
            {
                tboxResult.Text = num;
                isNewNum = false;
            }
            else if (tboxResult.Text == "0")
            {
                tboxResult.Text = num;
            }
            else
            {
                tboxResult.Text = tboxResult.Text + num;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            result = 0;
            isNewNum = true;

        }
    }
}
