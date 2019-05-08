using System;

using AppKit;
using Foundation;

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

        partial void buttonViewThumbnailInBrowser (NSObject sender)
        {
            // Get the thumbnail URL open in the browser.
            if (textboxVideoUrl.StringValue.Length > 0)
            {}
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

        internal string getThumbnailUrl()
        {
            // Now we can start trying to get the thumbnail's URL.
            if (textboxVideoUrl.StringValue.Length > 0)
            {
            // Look at the URL, and replace "www.youtube.com/watch?v=" with "i.ytimg.com/vi/".
            //Actually, first replace "www." with "" (nothing).
            Dim thumbnailUrl As String = textboxVideoUrl.Text
            Debug.WriteLine("Start:")
            Debug.WriteLine("Current URL: " & thumbnailUrl)

            // Replace "www." with nothing.
            thumbnailUrl = thumbnailUrl.Replace("www.", "")
            Debug.WriteLine("Replace www. Current URL: " & thumbnailUrl)

            // Replace "m." with nothing.
            thumbnailUrl = thumbnailUrl.Replace("m.", "")
            Debug.WriteLine("Replace m. Current URL: " & thumbnailUrl)

            // Replace "?feature=youtu.be" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("?feature=youtu.be", "")
            Debug.WriteLine("Replace ?feature=youtu.be. Current URL: " & thumbnailUrl)

            // Replace "&feature=youtu.be" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("&feature=youtu.be", "")
            Debug.WriteLine("Replace &feature=youtu.be. Current URL: " & thumbnailUrl)

            // Replace "&feature=share" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("&feature=share", "")
            Debug.WriteLine("Replace &feature=share. Current URL: " & thumbnailUrl)

            // Now, if "youtube.com/watch?" is in the URL, replace it and "v=" with "i.ytimg.com/vi/".
            If thumbnailUrl.Contains("youtube.com/watch?") Then
                thumbnailUrl = thumbnailUrl.Replace("youtube.com/watch?v=", "i.ytimg.com/vi/")
                Debug.WriteLine("Replace youtube.com/watch?v=. Current URL: " & thumbnailUrl)
            ElseIf thumbnailUrl.Contains("youtu.be/") Then
                // If the URL contains "youtu.be/", replace that with "i.ytimg.com/vi/".
                thumbnailUrl = thumbnailUrl.Replace("youtu.be/", "i.ytimg.com/vi/")
                Debug.WriteLine("Replace youtu.be. Current URL: " & thumbnailUrl)
            End If

            // Replace "watch" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("watch", "")
            Debug.WriteLine("Replace watch. Current URL: " & thumbnailUrl)

            // Replace "&v=" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("&v=", "")
            Debug.WriteLine("Replace &v=. Current URL: " & thumbnailUrl)

            // Once again, replace "youtube.com/" with "i.ytimg.com/vi/".
            thumbnailUrl = thumbnailUrl.Replace("youtube.com/", "i.ytimg.com/vi/")
            Debug.WriteLine("Replace youtube.com/. Current URL: " & thumbnailUrl)

            // Add "maxresdefault.jpg" to end of URL.
            thumbnailUrl = thumbnailUrl & "/maxresdefault.jpg"
            Debug.WriteLine("Append /maxresdefault.jpg. Current URL: " & thumbnailUrl)

            // Return the thumbnail URL if the textbox isn't empty.
            Return thumbnailUrl
        Else

            // If the textbox for the video URL is empty, just return the thumbnail of
            // one of my Luigi's Mansion episodes.
            Return "https://i.ytimg.com/vi/kK7TJIMab7g/maxresdefault.jpg"
        End If
            }
        }

    }
}
