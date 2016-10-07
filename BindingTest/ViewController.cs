using System;

using UIKit;
using JWPlayer;
namespace BindingTest
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
			// Perform any additional setup after loading the view, typically from a nib.

			var config = new JWConfig();
			config.File = "http://content.jwplatform.com/videos/f3FPINhF.mp4";
			config.Size = new CoreGraphics.CGSize(100, 100);

			var player = new JWPlayerController(config);

			this.View.Add(player.View);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
