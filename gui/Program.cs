using System;
using Gtk;

namespace gui
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.gui.gui", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new MainWindow();
            var win2 = new calc();
            var win3 = new lol();
            app.AddWindow(win);
            app.AddWindow(win2);
            app.AddWindow(win3);

            win.Show();
            win2.Show();
            win3.Show();
            Application.Run();
        }
    }
}
