
namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnEqu = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 3);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(776, 38);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            this.txtDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDisplay_KeyDown);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Info;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(93, 48);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 36);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Info;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(174, 49);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 35);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Info;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(255, 49);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 35);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Info;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 89);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 35);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Info;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(93, 90);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 35);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Info;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(174, 90);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 35);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Info;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(255, 90);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 35);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Info;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(12, 130);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 35);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.Info;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(93, 131);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 35);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.Info;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn0.Location = new System.Drawing.Point(12, 48);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 35);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(174, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(255, 131);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 35);
            this.btnSub.TabIndex = 12;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(12, 171);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 35);
            this.btnMul.TabIndex = 13;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(93, 172);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 35);
            this.btnDiv.TabIndex = 14;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnEqu
            // 
            this.btnEqu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqu.Location = new System.Drawing.Point(255, 213);
            this.btnEqu.Name = "btnEqu";
            this.btnEqu.Size = new System.Drawing.Size(75, 35);
            this.btnEqu.TabIndex = 15;
            this.btnEqu.Text = "=";
            this.btnEqu.UseVisualStyleBackColor = false;
            this.btnEqu.Click += new System.EventHandler(this.btnEqu_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(174, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDec
            // 
            this.btnDec.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.Location = new System.Drawing.Point(255, 172);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(75, 35);
            this.btnDec.TabIndex = 17;
            this.btnDec.Text = ".";
            this.btnDec.UseVisualStyleBackColor = false;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.Location = new System.Drawing.Point(12, 212);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(75, 35);
            this.btnBackSpace.TabIndex = 18;
            this.btnBackSpace.Text = "BS";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEqu);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnEqu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnBackSpace;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

