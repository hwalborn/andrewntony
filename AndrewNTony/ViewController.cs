using System;

using AppKit;
using Foundation;

namespace AndrewNTony
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CheckLabel.StringValue = "Hello Andrew!";

            // Do any additional setup after loading the view.
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

        partial void Checkbox(Foundation.NSObject sender) {
            if (CheckLabel.StringValue == "Hello Andrew!") {
                CheckLabel.StringValue = "Greetings Tony!";
            } else {
                CheckLabel.StringValue = "Hello Andrew!";
            }
            
        }
    }
}
