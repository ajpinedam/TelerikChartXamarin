using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.Chart;

namespace TelerikTest
{
    public partial class TelerikTestPage : ContentPage
    {

        public DataViewModel ViewModel = new DataViewModel ();

        public TelerikTestPage ()
        {
            BindingContext = ViewModel;
            InitializeComponent ();
        }

    }

    public class Data
    {
        public string Category { get; set; }

        public double Value { get; set; }

        public string LabelProperty { get; set; }
    }

}

