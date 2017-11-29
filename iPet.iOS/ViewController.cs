using System;
using System.Threading.Tasks;
using iPet.Logic.GenericExample;
using iPet.Logic.Services;
using UIKit;

namespace iPet.iOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            GenericList<Employee> gList = new GenericList<Employee>();
            gList.AddHead(new Employee("Julio", 1));
            gList.AddHead(new Employee("Yefry", 2));
            gList.AddHead(new Employee("Key", 3));
            gList.AddHead(new Employee("David", 4));
            gList.AddHead(new Employee("Luis", 5));

            foreach (Employee g in gList){
                Console.WriteLine(g.Name + ", " + g.ID);
            }

            Employee result = gList.FindFirstOccurrence("Key");
            Console.WriteLine("Search " + result.Name + ", " + result.ID);

            GenericResponse.changeEmployeeName("Holanda", result, new Employee("K",2));

            //this.NavigationController.NavigationBarHidden = true;

            //LoginButton.TouchUpInside += LoginButton_TouchUpInside;
        }

        public override bool ShouldPerformSegue(string segueIdentifier, Foundation.NSObject sender)
        {
			if ("goHome".Equals(segueIdentifier))
			{

				Task.Run(() =>
				{
                    return callLogin();
				})
			    .ContinueWith(responseData =>
    			{
    				
    			}, TaskScheduler.FromCurrentSynchronizationContext());


                return false;
			}

            return true;
        }

        async Task callLogin(){
			LoginServices loginServ = new LoginServices();
            await loginServ.Login();
        }

        void LoginButton_TouchUpInside(object sender, EventArgs e)
        {
            //UIStoryboard storyboard = UIStoryboard.FromName("", null);
            UIViewController controller = this.Storyboard.InstantiateViewController("HomeController");

            PresentViewController(controller, true, null);
        }
    }
}
