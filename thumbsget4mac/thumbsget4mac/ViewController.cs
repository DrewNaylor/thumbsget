using System;
using System.Diagnostics;
using AppKit;
using Foundation;
using ImageIO;

namespace thumbsget4mac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        partial void buttonViewThumbnailInBrowser(NSObject sender)
        {
            // Open the thumbnail in the user's default browser.

            // Make sure the textbox starts with http:// 
            // or https://.
            // The double bars (||) make it so that if the thing on the left is false,
            // the comparison will continue on the right. If the one on the left is
            // true, this should be faster than using a single bar (|).
            if (textboxVideoUrl.StringValue.StartsWith("https://", StringComparison.CurrentCulture)
                || (textboxVideoUrl.StringValue.StartsWith("http://", StringComparison.CurrentCulture)))
            // Get the thumbnail URL open in the browser.
            Process.Start(getThumbnailUrl());
        }

        partial void buttonPreviewThumbnail(NSObject sender)
        {
            // Loads the video in the video URL bar's thumbnail
            // into the preview image box on the right side.

            NSUrl thumbnailUrl = new NSUrl(getThumbnailUrl());
            NSImage thumbnailPreview = new NSImage(thumbnailUrl);
            pictureboxPreview.Image = thumbnailPreview;
        }

        partial void buttonSaveThumbnail(NSObject sender)
        {
            // Saves the thumbnail to the folder the user chooses.
            // This uses a regular dialog rather than a sheet since
            // sheets don't really make sense and get in the way.

            // First, create a new save dialog.
            // Code to create the save dialog was based on this:
            // https://docs.microsoft.com/en-us/xamarin/mac/user-interface/dialog#the-save-dialog
            NSSavePanel savefiledialogSaveThumbnail = new NSSavePanel();
            savefiledialogSaveThumbnail.Title = "Save thumbnail";
            savefiledialogSaveThumbnail.AllowedFileTypes = new string[] { "jpg", "jpeg", "png", "null" };


            //  Now open the save dialog.
            if (savefiledialogSaveThumbnail.RunModal () == 1)
            {
                // Get the file.
                System.Net.WebClient thumbnailDownloader = new System.Net.WebClient();
                thumbnailDownloader.DownloadFile(getThumbnailUrl(), savefiledialogSaveThumbnail.Filename);
            }
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        private string getThumbnailUrl()
        {
            // Now we can start trying to get the thumbnail's URL.
            if (textboxVideoUrl.StringValue.Length > 0)
            {
                // Look at the URL, and replace "www.youtube.com/watch?v=" with "i.ytimg.com/vi/".
                //Actually, first replace "www." with "" (nothing).
                string thumbnailUrl = textboxVideoUrl.StringValue;
                Debug.WriteLine("Start:");
                Debug.WriteLine("Current URL: " + thumbnailUrl);

                // Replace "www." with nothing.
                thumbnailUrl = thumbnailUrl.Replace("www.", "");
                Debug.WriteLine("Replace www. Current URL: " + thumbnailUrl);

                // Replace "m." with nothing.
                thumbnailUrl = thumbnailUrl.Replace("m.", "");
                Debug.WriteLine("Replace m. Current URL: " + thumbnailUrl);

                // Replace "?feature=youtu.be" with nothing.
                thumbnailUrl = thumbnailUrl.Replace("?feature=youtu.be", "");
                Debug.WriteLine("Replace ?feature=youtu.be. Current URL: " + thumbnailUrl);

                // Replace "&feature=youtu.be" with nothing.
                thumbnailUrl = thumbnailUrl.Replace("&feature=youtu.be", "");
                Debug.WriteLine("Replace &feature=youtu.be. Current URL: " + thumbnailUrl);

                // Replace "&feature=share" with nothing.
                thumbnailUrl = thumbnailUrl.Replace("&feature=share", "");
                Debug.WriteLine("Replace &feature=share. Current URL: " + thumbnailUrl);

                // Now, if "youtube.com/watch?" is in the URL, replace it and "v=" with "i.ytimg.com/vi/".
                if (thumbnailUrl.Contains("youtube.com/watch?"))
                {
                    thumbnailUrl = thumbnailUrl.Replace("youtube.com/watch?v=", "i.ytimg.com/vi/");
                    Debug.WriteLine("Replace youtube.com/watch?v=. Current URL: " + thumbnailUrl);
                }
                else if (thumbnailUrl.Contains("youtu.be/"))
                {
                    // If the URL contains "youtu.be/", replace that with "i.ytimg.com/vi/".
                    thumbnailUrl = thumbnailUrl.Replace("youtu.be/", "i.ytimg.com/vi/");
                    Debug.WriteLine("Replace youtu.be. Current URL: " + thumbnailUrl);
                }


                // Replace "watch" with nothing.
                thumbnailUrl = thumbnailUrl.Replace("watch", "");
                Debug.WriteLine("Replace watch. Current URL: " + thumbnailUrl);

                // Replace "&v=" with nothing.
                thumbnailUrl = thumbnailUrl.Replace("&v=", "");
                Debug.WriteLine("Replace &v=. Current URL: " + thumbnailUrl);

                // Once again, replace "youtube.com/" with "i.ytimg.com/vi/".
                thumbnailUrl = thumbnailUrl.Replace("youtube.com/", "i.ytimg.com/vi/");
                Debug.WriteLine("Replace youtube.com/. Current URL: " + thumbnailUrl);

                // Add "maxresdefault.jpg" to end of URL.
                thumbnailUrl = thumbnailUrl + "/maxresdefault.jpg";
                Debug.WriteLine("Append /maxresdefault.jpg. Current URL: " + thumbnailUrl);

                // Return the thumbnail URL if the textbox isn't empty.
                return thumbnailUrl;
            }
            else
            {
                // If the textbox for the video URL is empty, just return the thumbnail of
                // one of my Luigi's Mansion episodes.
                return "https://i.ytimg.com/vi/kK7TJIMab7g/maxresdefault.jpg";
            }
        }
    }

}
