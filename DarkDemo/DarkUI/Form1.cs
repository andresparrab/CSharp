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
         JoppesLib.PetOwner Joppe = new  JoppesLib.PetOwner(39);
         Ball myball = new Ball("blue");

        string name;
        public Form1()
        
        {
       
            InitializeComponent();
            scroller.Height = button1.Height;
            scroller.Top = button1.Top;           
            System.Console.WriteLine(Joppe.age);
              
        }

         private void buttonCat_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("clicked1");
          //Joppe.Menu();
            name= "fuji";
            scroller.Height = buttonCat.Height;
            scroller.Top = buttonCat.Top; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("clicked1");
          //Joppe.Menu();
            name= "thor";
            scroller.Height = button1.Height;
            scroller.Top = button1.Top; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            name= "thunder";
            scroller.Top = button2.Top;
            scroller.Height = button2.Height;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            name= "hunter";
            scroller.Top = button3.Top;
            scroller.Height = button3.Height;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            name= "rolf";
            scroller.Top = button4.Top;
            scroller.Height = button4.Height;
        }

           private void button5_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("clicked");
             this.label3.Text =  Joppe.List_animalsUI();
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("clicked Fetch nad name {0}", this.name);
             Joppe.joppesBall = myball;
             System.Console.WriteLine("Before Joppe.Check_ballUI {0}", Joppe.joppesBall);
            this.label3.Text = Joppe.Check_ballUI(Joppe.joppesBall);
            System.Console.WriteLine("After Joppe.Check_ballUI {0}", Joppe.joppesBall);
   
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        

        }
        private void radio_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb.Text!="fish" | rb.Text!="chicken" | rb.Text!="bones")
            {
                this.labelPlayFeed.Text = Joppe.FeedUI(name,rb.Text);
            }
            //string radion_choice = "";
            //this.labelPlayFeed.Text = rb.Text;
            
           
        }
        private void button7_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("clicked Fetch nad name {0}", this.name);

            System.Console.WriteLine("joppeball {0}", this.name);
            
            if(name != null)
            {
                this.labelPlayFeed.Text = "";
                this.Controls.Add(this.radiobutton1);
                this.Controls.Add(this.radiobutton2);
                this.Controls.Add(this.radiobutton3);

                System.Console.WriteLine("After feddui {0}", this.name);
                this.labelPlayFeed.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }   
        }
          private void button8_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("clicked Fetch nad name {0}", this.name);
             Joppe.joppesBall = myball;
             System.Console.WriteLine("joppeball {0}", Joppe.joppesBall.color);

           if(name=="")
           {
                this.labelPlayFeed.Text = "";
           }
           else
           {
            this.labelPlayFeed.Text = Joppe.FetchUI(name);
            this.labelPlayFeed.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           }

    
            
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("clicked");
            Application.Exit();
         
            
        }
    }
}
