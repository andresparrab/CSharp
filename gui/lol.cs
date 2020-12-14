using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace gui
{
    class lol : Window
    {

        // Import the items ID names for 
        //[UI] private Label label1 = null;
        [UI] private Entry entry1 = null;
        [UI] private Entry entry2 = null;
        [UI] private Label label3 = null;


        public lol() : this(new Builder("lol.glade")) { }
        private lol(Builder builder) : base(builder.GetObject("nameW").Handle)
        {
             builder.Autoconnect(this);


        }
        

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void clickad(object sender, EventArgs a)
        {
            
            label3.Text = string.Format("Hej {0} {1}. You are the love of my life !!!!!", entry1.Text, entry2.Text);
         
        }
    }
}
