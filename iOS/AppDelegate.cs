using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using Telerik.XamarinForms.Common.iOS;

[assembly: Xamarin.Forms.ExportRenderer (typeof (Telerik.XamarinForms.Chart.RadCartesianChart), typeof (Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer))]
[assembly: Xamarin.Forms.ExportRenderer (typeof (Telerik.XamarinForms.Chart.RadPieChart), typeof (Telerik.XamarinForms.ChartRenderer.iOS.PieChartRenderer))]

namespace TelerikTest.iOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init ();

            TelerikForms.Init ();

            new Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer ();

            LoadApplication (new App ());

            return base.FinishedLaunching (app, options);

        }
    }
}

