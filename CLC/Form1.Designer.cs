﻿namespace CLC
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
            this.RESU = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nega = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.divi = new System.Windows.Forms.Button();
            this.DELETEALL = new System.Windows.Forms.Button();
            this.DELETEPARTIAL = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.elpi = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.IGUAL = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RESU
            // 
            this.RESU.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESU.Location = new System.Drawing.Point(12, 12);
            this.RESU.MaxLength = 20;
            this.RESU.Multiline = true;
            this.RESU.Name = "RESU";
            this.RESU.ReadOnly = true;
            this.RESU.Size = new System.Drawing.Size(276, 50);
            this.RESU.TabIndex = 0;
            this.RESU.Text = "0";
            this.RESU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 82);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(41, 32);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.agregar_num);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 120);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(41, 32);
            this.four.TabIndex = 2;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.agregar_num);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 158);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(41, 32);
            this.one.TabIndex = 3;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.agregar_num);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(12, 196);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(41, 32);
            this.zero.TabIndex = 4;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.agregar_num);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(59, 196);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(41, 32);
            this.dot.TabIndex = 8;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.agregar_num);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(59, 158);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(41, 32);
            this.two.TabIndex = 7;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.agregar_num);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(59, 120);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(41, 32);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.agregar_num);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(59, 82);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(41, 32);
            this.eight.TabIndex = 5;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.agregar_num);
            // 
            // nega
            // 
            this.nega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nega.Location = new System.Drawing.Point(106, 196);
            this.nega.Name = "nega";
            this.nega.Size = new System.Drawing.Size(41, 32);
            this.nega.TabIndex = 12;
            this.nega.Text = "(-)";
            this.nega.UseVisualStyleBackColor = true;
            this.nega.Click += new System.EventHandler(this.agregar_num);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(106, 158);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(41, 32);
            this.three.TabIndex = 11;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.agregar_num);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(106, 120);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(41, 32);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.agregar_num);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(106, 82);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(41, 32);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.agregar_num);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(153, 196);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(41, 32);
            this.add.TabIndex = 16;
            this.add.Tag = "+";
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.CLKOPERADOR);
            // 
            // sus
            // 
            this.sus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sus.Location = new System.Drawing.Point(153, 158);
            this.sus.Name = "sus";
            this.sus.Size = new System.Drawing.Size(41, 32);
            this.sus.TabIndex = 15;
            this.sus.Tag = "-";
            this.sus.Text = "-";
            this.sus.UseVisualStyleBackColor = true;
            this.sus.Click += new System.EventHandler(this.CLKOPERADOR);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(153, 120);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(41, 32);
            this.mult.TabIndex = 14;
            this.mult.Tag = "*";
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.CLKOPERADOR);
            // 
            // divi
            // 
            this.divi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divi.Location = new System.Drawing.Point(153, 82);
            this.divi.Name = "divi";
            this.divi.Size = new System.Drawing.Size(41, 32);
            this.divi.TabIndex = 13;
            this.divi.Tag = "/";
            this.divi.Text = "/";
            this.divi.UseVisualStyleBackColor = true;
            this.divi.Click += new System.EventHandler(this.CLKOPERADOR);
            // 
            // DELETEALL
            // 
            this.DELETEALL.Location = new System.Drawing.Point(200, 196);
            this.DELETEALL.Name = "DELETEALL";
            this.DELETEALL.Size = new System.Drawing.Size(41, 32);
            this.DELETEALL.TabIndex = 20;
            this.DELETEALL.Text = "C";
            this.DELETEALL.UseVisualStyleBackColor = true;
            // 
            // DELETEPARTIAL
            // 
            this.DELETEPARTIAL.Location = new System.Drawing.Point(200, 158);
            this.DELETEPARTIAL.Name = "DELETEPARTIAL";
            this.DELETEPARTIAL.Size = new System.Drawing.Size(41, 32);
            this.DELETEPARTIAL.TabIndex = 19;
            this.DELETEPARTIAL.Text = "CE";
            this.DELETEPARTIAL.UseVisualStyleBackColor = true;
            // 
            // raiz
            // 
            this.raiz.Location = new System.Drawing.Point(200, 120);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(41, 32);
            this.raiz.TabIndex = 18;
            this.raiz.Tag = "√";
            this.raiz.Text = "√";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.CLKOPERADOR);
            // 
            // elpi
            // 
            this.elpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elpi.Location = new System.Drawing.Point(200, 82);
            this.elpi.Name = "elpi";
            this.elpi.Size = new System.Drawing.Size(41, 32);
            this.elpi.TabIndex = 17;
            this.elpi.Tag = "²";
            this.elpi.Text = "X²";
            this.elpi.UseVisualStyleBackColor = true;
            this.elpi.Click += new System.EventHandler(this.CLKOPERADOR);
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(247, 196);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(41, 32);
            this.BACK.TabIndex = 24;
            this.BACK.Text = "<<";
            this.BACK.UseVisualStyleBackColor = true;
            // 
            // IGUAL
            // 
            this.IGUAL.Location = new System.Drawing.Point(247, 158);
            this.IGUAL.Name = "IGUAL";
            this.IGUAL.Size = new System.Drawing.Size(41, 32);
            this.IGUAL.TabIndex = 23;
            this.IGUAL.Text = "=";
            this.IGUAL.UseVisualStyleBackColor = true;
            this.IGUAL.Click += new System.EventHandler(this.IGUAL_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(247, 120);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(41, 32);
            this.button23.TabIndex = 22;
            this.button23.Text = "button23";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(247, 82);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(41, 32);
            this.button24.TabIndex = 21;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(296, 271);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.IGUAL);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.DELETEALL);
            this.Controls.Add(this.DELETEPARTIAL);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.elpi);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sus);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.divi);
            this.Controls.Add(this.nega);
            this.Controls.Add(this.three);
            this.Controls.Add(this.six);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.two);
            this.Controls.Add(this.five);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.RESU);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RES;
        private System.Windows.Forms.Button FRACCION;
        private System.Windows.Forms.Button BORRATOTAL;
        private System.Windows.Forms.Button BORRAPARCIAL;
        private System.Windows.Forms.Button OCHO;
        private System.Windows.Forms.Button NUEVE;
        private System.Windows.Forms.Button SIETE;
        private System.Windows.Forms.Button CINCO;
        private System.Windows.Forms.Button SEIS;
        private System.Windows.Forms.Button CUATRO;
        private System.Windows.Forms.Button DOS;
        private System.Windows.Forms.Button TRES;
        private System.Windows.Forms.Button UNO;
        private System.Windows.Forms.Button PUN;
        private System.Windows.Forms.Button NEG;
        private System.Windows.Forms.Button CERO;
        private System.Windows.Forms.Button RST;
        private System.Windows.Forms.Button SUM;
        private System.Windows.Forms.Button DIV;
        private System.Windows.Forms.Button MUL;
        private System.Windows.Forms.Button BORRAUNO;
        private System.Windows.Forms.Button IGUFRA;
        private System.Windows.Forms.Button IGUDEC;
        private System.Windows.Forms.Button PI;
        private System.Windows.Forms.Button RAI;
        private System.Windows.Forms.Button SIG;
        private System.Windows.Forms.TextBox RESU;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nega;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button divi;
        private System.Windows.Forms.Button DELETEALL;
        private System.Windows.Forms.Button DELETEPARTIAL;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button elpi;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Button IGUAL;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}

