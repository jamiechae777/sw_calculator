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
    public partial class Form1 : Form
    {
        //연산자 버튼이 눌리면 true 안눌리면 false
        private bool opFlag = false;

        //클릭한 숫자 저장 변수
        private double tempNum = 0;

        //클릭한 연산자 저장 변수
        private string opt;

        //다중 연산을 위한 결과값 저장 변수
        private double tempResult = 0;

        //다중 연산을 위한 연산자 저장 변수
        private string tempOpt;

        //다중 연산이면 true 아니면 false
        private bool countFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        //숫자 버튼 클릭 메소드
        private void NumButton_click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;

            if (tboxResult.Text == "0" || opFlag == true) //처음 누르거나 연산자 누른 후거나
            {
                tboxResult.Text = numButton.Text;
                opFlag = false;
            }
            else //자릿수 추가
            {
                tboxResult.Text += numButton.Text;
            }
        }

        //연산자 버튼 클릭 메소드
        private void OptButton_click(object sender, EventArgs e)
        {
            Button optBtn = (Button)sender;

            //지금 누른 연산자
            opt = optBtn.Text;            

            //지금 창에 써있는 숫자
            tempNum = Double.Parse(tboxResult.Text);

            if (countFlag == false) //연산자 처음 누른 경우
            {                
                tempResult = tempNum;
                tboxTemp.Text += tboxResult.Text + opt;
                countFlag = true;
                tempOpt = opt; //다중연산을 위한 현재 연산자 저장
            }
            else //다중연산
            {
                switch (tempOpt) //저장해놓은 이전 연산자로 결과 계산
                {
                    case "+":
                        tempResult = tempResult + tempNum;                        
                        break;
                    case "-":
                        tempResult = tempResult - tempNum;
                        break;
                    case "×":
                        tempResult = tempResult * tempNum;
                        break;
                    case "÷":
                        tempResult = tempResult / tempNum;
                        break;
                    case "%":
                        tempResult = tempResult % tempNum;
                        break;
                    default:
                        break;
                }
                tboxTemp.Text = tempResult + opt;
                tempOpt = opt; //현재 연산자를 다시 다중연산을 위해 저장
            }                      

            opFlag = true;
            
        }

        //C 버튼 클릭 메소드
        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxResult.Text = "0";
            tboxTemp.Text = "";
            tempNum = 0;
            tempResult = 0;
            opt = "";
            tempOpt = "";
            opFlag = false;
            countFlag = false;
        }

        //소숫점 버튼 클릭 메소드
        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (tboxResult.Text.Contains("."))
                return;
            else
                tboxResult.Text += ".";
        }

        //양수,음수 버튼 클릭 메소드
        private void btnPM_Click(object sender, EventArgs e)
        {
            double num = Double.Parse(tboxResult.Text);
            tboxResult.Text = (-num).ToString();
        }

        //= 버튼 클릭 메소드
        private void btnResult_Click(object sender, EventArgs e)
        {
            Double tNum = Double.Parse(tboxResult.Text);

            switch (opt)
            {
                case "+":
                    tboxResult.Text = (tempResult + tNum).ToString();
                    break;
                case "-":
                    tboxResult.Text = (tempResult - tNum).ToString();
                    break;
                case "×":
                    tboxResult.Text = (tempResult * tNum).ToString();
                    break;
                case "÷":
                    tboxResult.Text = (tempResult / tNum).ToString();
                    break;
                case "%":
                    tboxResult.Text = (tempResult % tNum).ToString();
                    break;
                default:
                    break;
            }
             
            tboxTemp.Text = "";
            tempResult = Double.Parse(tboxResult.Text);
            countFlag = false;
            tempOpt = "";
            opt = "";
        }
    }
}
