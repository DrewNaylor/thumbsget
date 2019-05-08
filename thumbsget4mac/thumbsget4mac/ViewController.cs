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

            }
        }

    }
}
