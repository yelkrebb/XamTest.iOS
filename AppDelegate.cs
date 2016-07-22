using System;
using System.Collections.Generic;
using System.Linq;

using XamTest;

using Foundation;
using UIKit;

namespace XamTest.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			App.SetAdapter (Motion.Mobile.Core.BLE.Adapter.Current);

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

