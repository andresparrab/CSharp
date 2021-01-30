using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoppesLib;

namespace JoppesAF
{
    public partial class Form1 : Form
    {
        JoppesLib.PetOwner Joppe = new JoppesLib.PetOwner(39);
        Ball myball = new Ball("blue");

        string name;
        public Form1()

        {

            InitializeComponent();
            scroller.Height = button1.Height;
            scroller.Top = button1.Top;


        }

        private void buttonCat_Click(object sender, EventArgs e)
        {

            name = "fuji";
            scroller.Height = buttonCat.Height;
            scroller.Top = buttonCat.Top;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            name = "thor";
            scroller.Height = button1.Height;
            scroller.Top = button1.Top;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            name = "thunder";
            scroller.Top = button2.Top;
            scroller.Height = button2.Height;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            name = "hunter";
            scroller.Top = button3.Top;
            scroller.Height = button3.Height;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            name = "rolf";
            scroller.Top = button4.Top;
            scroller.Height = button4.Height;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.label3.Text = Joppe.List_animalsUI();
            this.Controls.Add(this.buttonPrintToFile);
            this.buttonPrintToFile.BringToFront();

            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


        }

        private void button6_Click(object sender, EventArgs e)
        {

            Joppe.joppesBall = myball;
            this.label3.Text = Joppe.Check_ballUI(Joppe.joppesBall);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


        }
        private void radio_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Text != "fish" | rb.Text != "chicken" | rb.Text != "bones")
            {
                this.labelPlayFeed.Text = Joppe.FeedUI(name, rb.Text);
            }
            //string radion_choice = "";
            //this.labelPlayFeed.Text = rb.Text;


        }
        private void button7_Click(object sender, EventArgs e)
        {

            if (name != null)
            {
                this.labelPlayFeed.Text = "";
                this.Controls.Add(this.radiobutton1);
                this.Controls.Add(this.radiobutton2);
                this.Controls.Add(this.radiobutton3);


                this.labelPlayFeed.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {

            Joppe.joppesBall = myball;


            if (name == "")
            {
                this.labelPlayFeed.Text = "";
            }
            else
            {
                this.labelPlayFeed.Text = Joppe.FetchUI(name);
                this.labelPlayFeed.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void buttonPrintToFile_Click(object sender, EventArgs e)
        {

            Joppe.printToFile();
            MessageBox.Show("The list has been printed to file pets.txt", "info", MessageBoxButtons.OK, MessageBoxIcon.None);


        }




        private void buttonExit_Click(object sender, EventArgs e)
        {

            Application.Exit();


        }
    }
}
