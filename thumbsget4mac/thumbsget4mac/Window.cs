using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace thumbsget4mac
{
    public partial class Window : AppKit.NSWindow
    {
        #region Constructors

        // Called when created from unmanaged code
        public Window(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public Window(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion
    }
}
