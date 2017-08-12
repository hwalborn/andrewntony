// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AndrewNTony
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField CheckLabel { get; set; }

        [Action ("Checkbox:")]
        partial void Checkbox (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (CheckLabel != null) {
                CheckLabel.Dispose ();
                CheckLabel = null;
            }
        }
    }
}
