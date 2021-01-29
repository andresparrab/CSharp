using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoppesLib;

namespace JoppesAF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Ball myball = new Ball("blue");
            // JoppesLib.PetOwner Joppe = new  JoppesLib.PetOwner(39);
            // Joppe.joppesBall = myball;
            //System.Console.WriteLine("Joppes created age: {0} and his balls color: {1}", Joppe.age, Joppe.joppesBall.color);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
         
         
        }
    }
}
