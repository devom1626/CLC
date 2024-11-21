﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLC
{
    public partial class Form1 : Form
    {
        double num1 =0,  num2 =0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void agregar_num(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (RESU.Text == "0")
                RESU.Text = "";

            RESU.Text += boton.Text;
        }

        private void IGUAL_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(RESU.Text);

            if (operador == '+')
            { 

                RESU.Text = (num1 + num2).ToString();
            num1 = Convert.ToDouble(RESU.Text);
        }
        else if (operador == '-')
            {
                RESU.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(RESU.Text);
            }

            else if (operador == '*')
            {
                RESU.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(RESU.Text);
            }

            else if (operador == '/')
            {
                RESU.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(RESU.Text);
            }

        }

        private void CLKOPERADOR(object sender, EventArgs e)
        {
            var boton = ((Button) sender);
            num1 = Convert.ToDouble(RESU.Text);

            if (operador == '²')
            {
                RESU.Text = (num1 * num1).ToString();
                num1 = Math.Pow(num1, 2);

            }
            operador = Convert.ToChar(boton.Tag);
            RESU.Text = "0";
        }
       
    }
      
   }


    

