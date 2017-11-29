using Foundation;
using System;
using UIKit;

namespace iPet.iOS
{
    public partial class HomeController : UIViewController
    {
        public HomeController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationController.NavigationBar.TintColor = UIColor.Red;

            newPet.TouchUpInside += NewPet_TouchUpInside;

        }

        void NewPet_TouchUpInside(object sender, EventArgs e)
        {
			UIViewController controller = this.Storyboard.InstantiateViewController("SavePet");
			PresentViewController(controller, true, null);
        }
    }
}