
namespace sw_calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnRemainder = new System.Windows.Forms.Button();
            this.tboxTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tboxResult
            // 
            this.tboxResult.Font = new System.Drawing.Font("페이북 OTF Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxResult.Location = new System.Drawing.Point(30, 60);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(314, 48);
            this.tboxResult.TabIndex = 0;
            this.tboxResult.Text = "0";
            this.tboxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(30, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 57);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDivision.Location = new System.Drawing.Point(270, 132);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(74, 57);
            this.btnDivision.TabIndex = 1;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.OptButton_click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn7.Location = new System.Drawing.Point(30, 195);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 57);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumButton_click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn8.Location = new System.Drawing.Point(110, 195);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(74, 57);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumButton_click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn9.Location = new System.Drawing.Point(190, 195);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(74, 57);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumButton_click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMulti.Location = new System.Drawing.Point(270, 195);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(74, 57);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "×";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.OptButton_click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn4.Location = new System.Drawing.Point(30, 258);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(74, 57);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumButton_click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn5.Location = new System.Drawing.Point(110, 258);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(74, 57);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumButton_click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn6.Location = new System.Drawing.Point(190, 258);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(74, 57);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumButton_click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinus.Location = new System.Drawing.Point(270, 258);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(74, 57);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.OptButton_click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.Location = new System.Drawing.Point(30, 321);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 57);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumButton_click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.Location = new System.Drawing.Point(110, 321);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(74, 57);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumButton_click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.Location = new System.Drawing.Point(190, 321);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(74, 57);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumButton_click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlus.Location = new System.Drawing.Point(270, 321);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(74, 57);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.OptButton_click);
            // 
            // btnPM
            // 
            this.btnPM.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPM.Location = new System.Drawing.Point(30, 384);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(74, 57);
            this.btnPM.TabIndex = 1;
            this.btnPM.Text = "+/-";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn0.Location = new System.Drawing.Point(110, 384);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(74, 57);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumButton_click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPoint.Location = new System.Drawing.Point(190, 384);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(74, 57);
            this.btnPoint.TabIndex = 1;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnResult.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResult.Location = new System.Drawing.Point(270, 384);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(74, 57);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnRemainder
            // 
            this.btnRemainder.Font = new System.Drawing.Font("페이북 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemainder.Location = new System.Drawing.Point(190, 132);
            this.btnRemainder.Name = "btnRemainder";
            this.btnRemainder.Size = new System.Drawing.Size(74, 57);
            this.btnRemainder.TabIndex = 1;
            this.btnRemainder.Text = "%";
            this.btnRemainder.UseVisualStyleBackColor = true;
            this.btnRemainder.Click += new System.EventHandler(this.OptButton_click);
            // 
            // tboxTemp
            // 
            this.tboxTemp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tboxTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxTemp.Font = new System.Drawing.Font("페이북 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxTemp.Location = new System.Drawing.Point(30, 29);
            this.tboxTemp.Name = "tboxTemp";
            this.tboxTemp.Size = new System.Drawing.Size(314, 23);
            this.tboxTemp.TabIndex = 0;
            this.tboxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 478);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnRemainder);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tboxTemp);
            this.Controls.Add(this.tboxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnRemainder;
        private System.Windows.Forms.TextBox tboxTemp;
    }
}

