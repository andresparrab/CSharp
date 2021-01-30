using System.Drawing;
namespace JoppesAF
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
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPlayFeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonCat = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPrintToFile = new System.Windows.Forms.Button();
            this.scroller = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.radiobutton1 = new System.Windows.Forms.RadioButton();
            this.radiobutton2 = new System.Windows.Forms.RadioButton();
            this.radiobutton3 = new System.Windows.Forms.RadioButton();

            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            //  Is the panel to the left with the menu buttons
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonCat);
            this.panel1.Controls.Add(this.panel3);

            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 519);
            this.panel1.TabIndex = 0;
            // 
            // panel2 Is the right down panel
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));

            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(166, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 321);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // is the yellow box panel upp left
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 76);
            this.panel3.TabIndex = 0;

            // 
            // scroller
            // is the yellow box panel upp left
            // 
            this.scroller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.scroller.Location = new System.Drawing.Point(167, 114);
            this.scroller.Name = "scroller";
            this.scroller.Size = new System.Drawing.Size(7, 72);
            this.scroller.TabIndex = 5;
            //this.scroller.BringToFront();
            // 
            // label1
            //  Title of the righ side upper picturebox1
            // 
            this.label1.AutoSize = false;
            this.label1.Location = new System.Drawing.Point(192, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actions";
            //
            ///
            // labelPlayFeed
            //  Title of the righ side upper picturebox1
            // 
            this.labelPlayFeed.AutoSize = false;
            this.labelPlayFeed.Location = new System.Drawing.Point(280, 120);
            this.labelPlayFeed.Name = "labelPlayFeed";
            this.labelPlayFeed.Size = new System.Drawing.Size(270, 100);
            this.labelPlayFeed.TabIndex = 2;
            this.labelPlayFeed.Text = "Waiting...";
            // // 
            // // label2   Is the text square top left yellow color on top of the panel 3
            // // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 117);
            this.label2.TabIndex = 0;
            this.label2.Text = "Joppes Animal\n Family";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            //
            // buttonCat
            // 
            this.buttonCat.FlatAppearance.BorderSize = 0;
            this.buttonCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCat.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCat.ForeColor = System.Drawing.Color.White;
            this.buttonCat.Image = (Image)(new Bitmap(Image.FromFile("cat.png"), new Size(77, 75))); //specify size you want
            this.buttonCat.Location = new System.Drawing.Point(0, 100);
            this.buttonCat.Name = "buttonCat";
            this.buttonCat.Size = new System.Drawing.Size(163, 90);
            this.buttonCat.TabIndex = 1;
            this.buttonCat.Text = "Fuji";
            this.buttonCat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCat.UseVisualStyleBackColor = true;
            this.buttonCat.Click += new System.EventHandler(this.buttonCat_Click);  // This will call the method in the form1.cs  ----- button1_Click()
            // // 
            //
            //


            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = (Image)(new Bitmap(Image.FromFile("cat.png"), new Size(77, 75))); //specify size you want
            this.button1.Location = new System.Drawing.Point(0, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thor";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);  // This will call the method in the form1.cs  ----- button1_Click()
            // // 
            // // button2
            // // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = Image.FromFile("kitty.png");
            this.button2.Location = new System.Drawing.Point(2, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thunder";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // // 
            // // button3
            // // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = Image.FromFile("dog.png");
            this.button3.Location = new System.Drawing.Point(2, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 79);
            this.button3.TabIndex = 1;
            this.button3.Text = "Hunter";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // // 
            // // button4
            // // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = Image.FromFile("puppy.png");
            this.button4.Location = new System.Drawing.Point(0, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 79);
            this.button4.TabIndex = 1;
            this.button4.Text = "Rolf";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // // 
            // // pictureBox1
            // // Sits on the rigt side panel top
            this.pictureBox1.Image = Image.FromFile("ndog.jpg");
            this.pictureBox1.Location = new System.Drawing.Point(673, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // // 
            // // // label3
            // // // 
            this.label3.AutoSize = false;
            this.label3.Location = new System.Drawing.Point(340, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 200);
            this.label3.TabIndex = 2;
            this.label3.Text = "";
            // // // 
            // // // button5
            // // // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(885, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "List pets";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // // // 
            // // // button6
            // // // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(780, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 27);
            this.button6.TabIndex = 4;
            this.button6.Text = "Check Ball";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // // // 
            // // // button7
            // // // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(700, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 27);
            this.button7.TabIndex = 4;
            this.button7.Text = "Feed";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // // // 
            // // // button8
            // // // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(640, 37);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 27);
            this.button8.TabIndex = 4;
            this.button8.Text = "Play";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // // 
            //
            // // // buttonPrintToFile
            // // // 
            this.buttonPrintToFile.FlatAppearance.BorderSize = 0;
            this.buttonPrintToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintToFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintToFile.Location = new System.Drawing.Point(860, 580);
            this.buttonPrintToFile.Name = "buttonPrintToFile";
            this.buttonPrintToFile.Size = new System.Drawing.Size(110, 27);
            this.buttonPrintToFile.TabIndex = 4;
            this.buttonPrintToFile.Text = "Print to file";
            this.buttonPrintToFile.UseVisualStyleBackColor = true;
            this.buttonPrintToFile.Click += new System.EventHandler(this.buttonPrintToFile_Click);
            // // 
            //
            // Exit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(955, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);  // This will call the method in the form1.cs  ----- button1_Click()
            // // pictureBox2
            // // // 
            this.pictureBox2.Image = Image.FromFile("ncat.jpg");
            this.pictureBox2.Location = new System.Drawing.Point(20, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 208);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // // // 
            // // // checkBox1
            // // // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(280, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(215, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "fish";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.buttonExit_Click);
            // // // 

            // // // Rariobutton1
            // // // 
            this.radiobutton1.AutoSize = true;
            //this.radiobutton1.FlatAppearance.BorderSize = 0;
            //this.radiobutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radiobutton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobutton1.Location = new System.Drawing.Point(430, 64);
            this.radiobutton1.Name = "radiobutton1";
            this.radiobutton1.Size = new System.Drawing.Size(215, 21);
            this.radiobutton1.TabIndex = 4;
            this.radiobutton1.Text = "fish";
            this.radiobutton1.UseVisualStyleBackColor = true;
            this.radiobutton1.Click += new System.EventHandler(this.radio_Click);
            //
            //
            // // // Rariobutton2
            // // // 
            this.radiobutton2.AutoSize = true;
            this.radiobutton2.FlatAppearance.BorderSize = 0;
            this.radiobutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radiobutton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobutton2.Location = new System.Drawing.Point(340, 64);
            this.radiobutton2.Name = "radiobutton2";
            this.radiobutton2.Size = new System.Drawing.Size(225, 22);
            this.radiobutton2.TabIndex = 4;
            this.radiobutton2.Text = "chicken";
            this.radiobutton2.UseVisualStyleBackColor = true;
            this.radiobutton2.Click += new System.EventHandler(this.radio_Click);
            //
            // // // 
            //
            // // // Rariobutton3
            // // // 
            this.radiobutton3.AutoSize = true;
            this.radiobutton3.FlatAppearance.BorderSize = 0;
            this.radiobutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radiobutton3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobutton3.Location = new System.Drawing.Point(260, 64);
            this.radiobutton3.Name = "radiobutton3";
            this.radiobutton3.Size = new System.Drawing.Size(225, 22);
            this.radiobutton3.TabIndex = 4;
            this.radiobutton3.Text = "bones";
            this.radiobutton3.UseVisualStyleBackColor = true;
            this.radiobutton3.Click += new System.EventHandler(this.radio_Click);
            //
            // // // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(350, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(129, 21);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "chicken";
            this.checkBox2.UseVisualStyleBackColor = true;
            // // // 
            // // // checkBox3
            // // // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.FlatAppearance.BorderSize = 0;
            this.checkBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(440, 64);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(150, 21);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "bones";
            this.checkBox3.UseVisualStyleBackColor = true;
            // // // 
            // // // checkBox4
            // // // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(398, 145);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(128, 21);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "C# UI Academy";
            this.checkBox4.UseVisualStyleBackColor = true;
            // // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));

            this.ClientSize = new System.Drawing.Size(980, 619);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonExit);
            //this.Controls.Add(this.buttonPrintToFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlayFeed);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            // this.Controls.Add(this.checkBox1);
            // this.Controls.Add(this.checkBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joppes App";
            this.Controls.Add(this.scroller);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.scroller.ResumeLayout(false);
            this.scroller.BringToFront();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel scroller;
        private System.Windows.Forms.Label labelPlayFeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCat;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPrintToFile;

        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radiobutton1;
        private System.Windows.Forms.RadioButton radiobutton2;
        private System.Windows.Forms.RadioButton radiobutton3;

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

