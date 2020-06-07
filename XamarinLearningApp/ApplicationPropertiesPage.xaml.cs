using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLearningApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplicationPropertiesPage : ContentPage
    {
        
        public ApplicationPropertiesPage()
        {
            InitializeComponent();

            //if (Application.Current.Properties.ContainsKey(TitleKey))
            //title.Text = Application.Current.Properties[TitleKey].ToString();
            //if (Application.Current.Properties.ContainsKey(NotificationKey))
            //    notificationsEnabled.On = (bool)Application.Current.Properties[NotificationKey];

            //OR
            //var app = Application.Current as App;
            //app.Title = title.Text;
            //app.NotificationEnabled = notificationsEnabled.On;
            BindingContext = Application.Current;
        }

        //private void OnChange(object sender, EventArgs e)
        //{
        //    //Application.Current.Properties[TitleKey] = title.Text;
        //    //Application.Current.Properties[NotificationKey] = notificationsEnabled.On;

        //    //OR
        //    //var app = Application.Current as App;
        //    //app.Title = title.Text;
        //    //app.NotificationEnabled = notificationsEnabled.On;

        //    //if the data has to be persisted use the below line
        //    //Application.Current.SavePropertiesAsync();
        //}

        //Overide the below method when the data has to be persisted when the page disappears
        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing(); 
        //}
    }
}