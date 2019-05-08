// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace test
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField textboxVideoUrl { get; set; }

        [Action ("buttonViewThumbnailInBrowser:")]
        partial void buttonViewThumbnailInBrowser (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (textboxVideoUrl != null) {
                textboxVideoUrl.Dispose ();
                textboxVideoUrl = null;
            }
        }
    }
}
