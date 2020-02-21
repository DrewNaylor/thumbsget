#!/usr/bin/env python

#File based on this StackOverflow answer:
#https://stackoverflow.com/a/57455040

#Also based on this Gnome demo:
#https://developer.gnome.org/gnome-devel-demos/stable/toolbar_builder.py.html.en



import gi
gi.require_version('Gtk', '3.0')
from gi.repository import Gtk
import sys


UI_FILE = "aaformMainWindow.glade"

class GUI(Gtk.ApplicationWindow):
    def __init__(self, app):
        Gtk.Window.__init__(self, title="thumbsget4py", application=app)
        self.set_default_size(525, 204)


        # A builder to connect the UI to the app.
        builder = Gtk.Builder()

        # Attempt to get the main window file if it exists.
        try:
            builder.add_from_file("aaformMainWindow.glade")
        except:
            print("Main window file not found.")
            sys.exit()

        # Now put it in the window.
        self.add(builder.get_object("boxMainWindow"))


        # Get buttons that will be used later.
        self.buttonViewThumbnailInBrowser = builder.get_object("buttonViewThumbnailInBrowser")
        self.buttonPreviewThumbnail = builder.get_object("buttonPreviewThumbnail")
        self.buttonSaveThumbnail = builder.get_object("buttonSaveThumbnail")
        self.buttonAbout = builder.get_object("buttonAbout")

        # Create actions that are used when clicking buttons
        # connect their signal to a callback method, and add
        # the action to the window.

        # View thumbnail in browser.
        self.buttonViewThumbnailInBrowser.connect("clicked", self.view_thumbnail_in_browser_callback)

        # Preview thumbnail.
        self.buttonPreviewThumbnail.connect("clicked", self.preview_thumbnail_callback)

        # Save thumbnail.
        self.buttonSaveThumbnail.connect("clicked", self.save_thumbnail_callback)


    def preview_thumbnail_callback(self, widget):
        print("Thumbnail previewed.")

    def save_thumbnail_callback(self, widget):
        print("Thumbnail saved.")

    def view_thumbnail_in_browser_callback(self, widget):
        print("Thumbnail opened in browser.")

class Application(Gtk.Application):
    def __init__(self):
        Gtk.Application.__init__(self)

    def do_activate(self):
        win = GUI(self)
        # Now we show the window with show()
        win.show()

    def do_startup(self):
        Gtk.Application.do_startup(self)

app = Application()
exit_status = app.run(sys.argv)
sys.exit(exit_status)