using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void on_click(object sender, EventArgs e)
    {
        bool ishoejdeNumber = double.TryParse(entry_hoejde.Text, out double hoejde);
        bool isvaegtNumber = double.TryParse(entry_vaegt.Text, out double vaegt);
        Console.WriteLine();
    }
}
