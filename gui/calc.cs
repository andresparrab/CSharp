using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace gui
{
    class calc : Window
    {

        // Import the items ID names for 
        //[UI] private Label label1 = null;
        [UI] private Entry entry1 = null;
        [UI] private Entry entry2 = null;
        [UI] private Entry entry3 = null;
        
        
        public calc() : this(new Builder("calc.glade")) { }

        private calc(Builder builder) : base(builder.GetObject("calc").Handle)
        {
            builder.Autoconnect(this);


        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void click(object sender, EventArgs a)
        {
            decimal add = Convert.ToDecimal(entry2.Text) + Convert.ToDecimal(entry1.Text);
            entry3.Text = (add.ToString());
        }
    }
}
