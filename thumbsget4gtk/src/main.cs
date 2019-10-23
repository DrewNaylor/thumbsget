using Gtk;
using System;
//using Glade;

namespace thumbsget4gtk
{
	class aaformMainWindow
	{
		public aaformMainWindow()
		{

		Application.Init();
		//Glade.XML gxml = Glade.XML(null, "aaformMainWindow.glade", "thumbsget4gtk", null);
		Builder mainWindow = new Builder();
		mainWindow.AddFromFile("aaformMainWindow.glade");
		mainWindow.Autoconnect(this);
		Gtk.Application.Run();

		}

		public static void Main()
		{
			new aaformMainWindow();
		}

	}
}
