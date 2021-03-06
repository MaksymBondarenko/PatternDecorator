﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Components;
using WindowsFormsApp1.Conditions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bevarage bevarage = new Espresso();
        Bevarage bevarage1 = new Americano();
        Bevarage bevarage2 = new Capuccino();
        Bevarage bevarage3 = new Latte();
        int buf = 0;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;

            if (comboBox1.SelectedIndex == 0)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                textBox1.Text = $"{bevarage.getDescription()}";
                textBox2.Text = $"{bevarage.cost()}";
                textBox7.Text = $"{bevarage.cost()}";

                buf = 1;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                textBox1.Text = $"{bevarage1.getDescription()}";
                textBox2.Text = $"{bevarage1.cost()}";
                textBox7.Text = $"{bevarage1.cost()}";
                buf = 2;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                textBox1.Text = $"{bevarage2.getDescription()}";
                textBox2.Text = $"{bevarage2.cost()}";
                textBox7.Text = $"{bevarage2.cost()}";
                buf = 3;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                textBox1.Text = $"{bevarage3.getDescription()}";
                textBox2.Text = $"{bevarage3.cost()}";
                textBox7.Text = $"{bevarage3.cost()}";
                buf = 4;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            comboBox2.Text = "1";
            textBox3.Text = "0,31";
            switch (buf)
            {
                case 1:
                    if (checkBox1.Checked)
                    {
                        bevarage = new Mocha(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                    else
                    {
                        comboBox2.Enabled = false;
                        bevarage = new Espresso();
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                        textBox3.Text = "0";
                    }
                    break;

                case 2:
                    if (checkBox1.Checked)
                    {
                        bevarage1 = new Mocha(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    else
                    {
                        comboBox2.Enabled = false;
                        bevarage1 = new Americano();
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                        textBox3.Text = "0";
                    }
                    break;

                case 3:
                    if (checkBox1.Checked)
                    {
                        bevarage2 = new Mocha(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    else
                    {
                        comboBox2.Enabled = false;
                        bevarage2 = new Capuccino();
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                        textBox3.Text = "0";
                    }
                    break;
                case 4:
                    if (checkBox1.Checked)
                    {
                        bevarage3 = new Mocha(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                    else
                    {
                        comboBox2.Enabled = false;
                        bevarage3 = new Latte();
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                        textBox3.Text = "0";
                    }
                    break;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            comboBox3.Text = "1";
            textBox4.Text = "0,35";
            switch (buf)
            {
                case 1:
                    if (checkBox2.Checked)
                    {
                        bevarage = new Soy(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                    else
                    {
                        comboBox3.Enabled = false;
                        bevarage = new Espresso();
                        bevarage = new Mocha(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                        textBox4.Text = "0";
                    }
                    break;

                case 2:
                    if (checkBox2.Checked)
                    {
                        bevarage1 = new Soy(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    else
                    {
                        comboBox3.Enabled = false;
                        bevarage1 = new Americano();
                        bevarage1 = new Mocha(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                        textBox4.Text = "0";
                    }
                    break;

                case 3:
                    if (checkBox2.Checked)
                    {
                        bevarage2 = new Soy(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    else
                    {
                        comboBox3.Enabled = false;
                        bevarage2 = new Capuccino();
                        bevarage2 = new Mocha(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                        textBox4.Text = "0";
                    }
                    break;

                case 4:
                    if (checkBox2.Checked)
                    {
                        bevarage3 = new Soy(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                    else
                    {
                        comboBox3.Enabled = false;
                        bevarage3 = new Latte();
                        bevarage3 = new Mocha(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                        textBox4.Text = "0";
                    }
                    break;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;
            comboBox4.Text = "1";
            textBox5.Text = "0,40";
            switch (buf)
            {
                case 1:
                    if (checkBox3.Checked)
                    {
                        bevarage = new Milk(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                    else
                    {
                        comboBox4.Enabled = false;
                        bevarage = new Espresso();
                        bevarage = new Mocha(bevarage);
                        bevarage = new Soy(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                        textBox5.Text = "0";
                    }
                    break;

                case 2:
                    if (checkBox3.Checked)
                    {
                        bevarage1 = new Milk(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    else
                    {
                        comboBox4.Enabled = false;
                        bevarage1 = new Americano();
                        bevarage1 = new Mocha(bevarage1);
                        bevarage1 = new Soy(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                        textBox5.Text = "0";
                    }
                    break;

                case 3:
                    if (checkBox3.Checked)
                    {
                        bevarage2 = new Milk(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    else
                    {
                        comboBox4.Enabled = false;
                        bevarage2 = new Capuccino();
                        bevarage2 = new Mocha(bevarage2);
                        bevarage2 = new Soy(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                        textBox5.Text = "0";
                    }
                    break;

                case 4:
                    if (checkBox3.Checked)
                    {
                        bevarage3 = new Milk(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                    else
                    {
                        comboBox4.Enabled = false;
                        bevarage3 = new Latte();
                        bevarage3 = new Mocha(bevarage3);
                        bevarage3 = new Soy(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                        textBox5.Text = "0";
                    }
                    break;

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Enabled = true;
            comboBox5.Text = "1";
            textBox6.Text = "0,55";
            switch (buf)
            {
                case 1:
                    if (checkBox4.Checked)
                    {
                        bevarage = new Whip(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                    else
                    {
                        comboBox5.Enabled = false;
                        bevarage = new Espresso();
                        bevarage = new Mocha(bevarage);
                        bevarage = new Soy(bevarage);
                        bevarage = new Milk(bevarage);
                        textBox1.Text = $"{bevarage.getDescription()}";
                        textBox2.Text = $"{bevarage.cost()}";
                        textBox6.Text = "0";
                    }
                    break;

                case 2:
                    if (checkBox3.Checked)
                    {
                        bevarage1 = new Whip(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    else
                    {
                        comboBox5.Enabled = false;
                        bevarage1 = new Americano();
                        bevarage1 = new Mocha(bevarage1);
                        bevarage1 = new Soy(bevarage1);
                        bevarage1 = new Milk(bevarage1);
                        textBox1.Text = $"{bevarage1.getDescription()}";
                        textBox2.Text = $"{bevarage1.cost()}";
                        textBox6.Text = "0";
                    }
                    break;

                case 3:
                    if (checkBox3.Checked)
                    {
                        bevarage2 = new Whip(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    else
                    {
                        comboBox5.Enabled = false;
                        bevarage2 = new Capuccino();
                        bevarage2 = new Mocha(bevarage2);
                        bevarage2 = new Soy(bevarage2);
                        bevarage2 = new Milk(bevarage2);
                        textBox1.Text = $"{bevarage2.getDescription()}";
                        textBox2.Text = $"{bevarage2.cost()}";
                        textBox6.Text = "0";
                    }
                    break;

                case 4:
                    if (checkBox3.Checked)
                    {
                        bevarage3 = new Whip(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                    else
                    {
                        comboBox5.Enabled = false;
                        bevarage3 = new Latte();
                        bevarage3 = new Mocha(bevarage3);
                        bevarage3 = new Soy(bevarage3);
                        bevarage3 = new Milk(bevarage3);
                        textBox1.Text = $"{bevarage3.getDescription()}";
                        textBox2.Text = $"{bevarage3.cost()}";
                        textBox6.Text = "0";
                    }
                    break;
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (buf)
            {
                case 1:
                    if (comboBox2.SelectedIndex == 0)
                    {
                      
                        textBox2.Text = $"{bevarage.cost() + .31}";
                    }
                    else
                    {
                        bevarage = new Mocha(bevarage);
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                  break;

                case 2:
                    if (comboBox2.SelectedIndex == 0)
                    {
                        
                        textBox2.Text = $"{bevarage1.cost() + .31}";
                    }
                    else
                    {
                       
                        bevarage1 = new Mocha(bevarage1);
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    break;
                case 3:
                    if (comboBox2.SelectedIndex == 0)
                    {
                        textBox2.Text = $"{bevarage2.cost() + .31}";
                    }
                    else
                    {
                        bevarage2 = new Mocha(bevarage2);
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    break;
                case 4:
                    if (comboBox2.SelectedIndex == 0)
                    {
                        textBox2.Text = $"{bevarage3.cost() + .31}";
                    }
                    else
                    {
                        bevarage3 = new Mocha(bevarage3);
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                  break;
            }              
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (buf)
            {
                case 1:
                    if (comboBox3.SelectedIndex == 0)
                    {
                       
                        textBox2.Text = $"{bevarage.cost() + .35}";
                    }
                    else
                    {
                        bevarage = new Soy(bevarage);
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                    break;

                case 2:
                    if (comboBox3.SelectedIndex == 0)
                    {
                       
                        textBox2.Text = $"{bevarage1.cost() + .35}";
                    }
                    else
                    {
                        bevarage1 = new Soy(bevarage1);
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    break;
                case 3:
                    if (comboBox3.SelectedIndex == 0)
                    {
                        textBox2.Text = $"{bevarage2.cost() + .35}";
                    }
                    else
                    {
                        bevarage2 = new Soy(bevarage2);
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    break;
                case 4:
                    if (comboBox3.SelectedIndex == 0)
                    {
                        textBox2.Text = $"{bevarage3.cost() + .35}";
                    }
                    else
                    {
                        bevarage3 = new Soy(bevarage3);
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (buf)
            {
                case 1:
                    if (comboBox4.SelectedIndex == 0)
                    {

                        textBox2.Text = $"{bevarage.cost() + .40}";
                    }
                    else
                    {
                        bevarage = new Milk(bevarage);
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                    break;

                case 2:
                    if (comboBox4.SelectedIndex == 0)
                    {

                        textBox2.Text = $"{bevarage1.cost() + .40}";
                    }
                    else
                    {
                        bevarage1 = new Milk(bevarage1);
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    break;
                case 3:
                    if (comboBox4.SelectedIndex == 0)
                    {
                        textBox2.Text = $"{bevarage2.cost() + .40}";
                    }
                    else
                    {
                        bevarage2 = new Milk(bevarage2);
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    break;
                case 4:
                    if (comboBox4.SelectedIndex == 0)
                    {
                        textBox2.Text = $"{bevarage3.cost() + .40}";
                    }
                    else
                    {
                        bevarage3 = new Milk(bevarage3);
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                    break;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (buf)
            {
                case 1:
                    if (comboBox5.SelectedIndex == 0)
                    {

                        textBox2.Text = $"{bevarage.cost() + .55}";
                    }
                    else
                    {
                        bevarage = new Whip(bevarage);
                        textBox2.Text = $"{bevarage.cost()}";
                    }
                    break;

                case 2:
                    if (comboBox5.SelectedIndex == 0)
                    {

                        textBox2.Text = $"{bevarage1.cost() + .55}";
                    }
                    else
                    {
                        bevarage1 = new Whip(bevarage1);
                        textBox2.Text = $"{bevarage1.cost()}";
                    }
                    break;
                case 3:
                    if (comboBox5.SelectedIndex == 0)
                    {
                        textBox2.Text = $"{bevarage2.cost() + .55}";
                    }
                    else
                    {
                        bevarage2 = new Whip(bevarage2);
                        textBox2.Text = $"{bevarage2.cost()}";
                    }
                    break;
                case 4:
                    if (comboBox5.SelectedIndex == 0)
                    {
                        textBox2.Text = $"{bevarage3.cost() + .55}";
                    }
                    else
                    {
                        bevarage3 = new Whip(bevarage3);
                        textBox2.Text = $"{bevarage3.cost()}";
                    }
                    break;
            }
        }
    }
}