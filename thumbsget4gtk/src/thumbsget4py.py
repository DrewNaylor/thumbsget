#!/usr/bin/env python

#File based on this StackOverflow answer:
#https://stackoverflow.com/a/57455040

#Also based on this Gnome demo:
#https://developer.gnome.org/gnome-devel-demos/stable/toolbar_builder.py.html.en



import gi
gi.require_version('Gtk', '3.0')
from gi.repository import Gtk
from gi.repository import Gdk
import sys
import urllib.request


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
        # Get video URL textbox.
        self.textboxVideoUrl = builder.get_object("textboxVideoUrl")
        # Get image box.
        self.imageboxThumbnail = builder.get_object("imageboxThumbnail")

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
        print(thumbnailUrl.getThumbnailUrl(self, self.textboxVideoUrl.get_text()))
        # Loading image based on this StackOverflow answer:
        # https://stackoverflow.com/a/3962377
        # Currently broken as it seems like there isn't an easy way to update
        # the image from a URL.
        thumbnailTempDownload = urllib.request.Request(self, self.textboxVideoUrl.get_text())
        thumbnailPixbufLoader = Gtk.PixbufLoader()
        with urllib.request.urlopen(thumbnailTempDownload) as response:
            thumbnailPixbufLoader.write(response.read())
        thumbnailPixbufLoader.close()
        self.imageboxThumbnail.set_from_pixbuf(thumbnailPixbufLoader.get_pixbuf())
        #self.imageboxThumbnail.set_from_file("/home/drew/Pictures/Screenshot from 2019-04-30 02-13-49.png")

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

class thumbnailUrl:
    def getThumbnailUrl(self, thumbnailUrl):
            # First we need to define the image box so we can set
            # the preview in it.
            print("Video URL: " + thumbnailUrl)
            # Next, we need to make sure there's stuff in the textbox.
            if thumbnailUrl != "None":
            # Now we can do stuff and replace text.
            
                # Look at the URL, and replace "www.youtube.com/watch?v=" with "i.ytimg.com/vi/".
                # Actually, first replace "www." with "" (nothing).
                print("Start:")
                print("Current URL: " + thumbnailUrl)

                # Replace "www." with nothing.
                thumbnailUrl = thumbnailUrl.replace("www.", "")
                print("Replace www. Current URL: " + thumbnailUrl)

                # Replace "m." with nothing.
                thumbnailUrl = thumbnailUrl.replace("m.", "")
                print("Replace m. Current URL: " + thumbnailUrl)

                # Replace "?feature=youtu.be" with nothing.
                thumbnailUrl = thumbnailUrl.replace("?feature=youtu.be", "")
                print("Replace ?feature=youtu.be. Current URL: " + thumbnailUrl)

                # Replace "&feature=youtu.be" with nothing.
                thumbnailUrl = thumbnailUrl.replace("&feature=youtu.be", "")
                print("Replace &feature=youtu.be. Current URL: " + thumbnailUrl)

                # Replace "&feature=share" with nothing.
                thumbnailUrl = thumbnailUrl.replace("&feature=share", "")
                print("Replace &feature=share. Current URL: " + thumbnailUrl)

                # Now, if "youtube.com/watch?" is in the URL, replace it and "v=" with "i.ytimg.com/vi/".
                if ("youtube.com/watch?" in thumbnailUrl):
                    thumbnailUrl = thumbnailUrl.replace("youtube.com/watch?v=", "i.ytimg.com/vi/")
                    print("Replace youtube.com/watch?v=. Current URL: " + thumbnailUrl)
                elif ("youtu.be/" in thumbnailUrl):
                # If the URL contains "youtu.be/", replace that with "i.ytimg.com/vi/".
                    thumbnailUrl = thumbnailUrl.replace("youtu.be/", "i.ytimg.com/vi/")
                    print("Replace youtu.be. Current URL: " + thumbnailUrl)
                # Replace "watch" with nothing.
                thumbnailUrl = thumbnailUrl.replace("watch", "")
                print("Replace watch. Current URL: " + thumbnailUrl)
                # Replace "&v=" with nothing.
                thumbnailUrl = thumbnailUrl.replace("&v=", "")
                print("Replace &v=. Current URL: " + thumbnailUrl)
                # Once again, replace "youtube.com/" with "i.ytimg.com/vi/".
                thumbnailUrl = thumbnailUrl.replace("youtube.com/", "i.ytimg.com/vi/")
                print("Replace youtube.com/. Current URL: " + thumbnailUrl)
                 # Add "hqdefault.jpg" to end of URL if the
                # # checkbox to use hqdefault instead is checked.
                #     if(checkboxUseHQDefault.checked == 1):
                #         thumbnailUrl = thumbnailUrl + "/hqdefault.jpg"
                #         print("Append /hqdefault.jpg. Current URL: " + thumbnailUrl)
                #     else:
                    # Otherwise, if the checkbox is unchecked,
                    # use maxresdefault.
                thumbnailUrl = thumbnailUrl + "/maxresdefault.jpg"
                print("Append /maxresdefault.jpg. Current URL: " + thumbnailUrl)
                # Return the thumbnail URL if the textbox isn't empty and onlyReturnVideoID
                return thumbnailUrl
            else:
            # If the textbox for the video URL is empty, just return the thumbnail of
            # one of my Luigi's Mansion episodes.
                return "https://i.ytimg.com/vi/kK7TJIMab7g/maxresdefault.jpg"
                

app = Application()
exit_status = app.run(sys.argv)
sys.exit(exit_status)