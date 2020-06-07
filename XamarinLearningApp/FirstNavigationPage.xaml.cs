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
    public partial class FirstNavigationPage : ContentPage
    {
        public FirstNavigationPage()
        {
            InitializeComponent();
        }

        async void Next_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SecondNavigationPage());
        }
        //To override the physical back button in android
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}