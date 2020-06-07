using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLearningApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popups : ContentPage
    {
        public Popups()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            //Display Alert
            //var response =  await DisplayAlert("Warning","Are you sure","Yes","No");
            //if(response)
            //    await DisplayAlert("Done", "Your response will be saved", "OK");
            //Display ActionSheet
            var response = await DisplayActionSheet("Actions", "Cancel", "Delete", "Copy", "Message", "Email");
            if(response == "Copy")
                await DisplayAlert("Copying...", "Copied", "OK");
            else if(response == "Message")
                await DisplayAlert("Messaging...", "Message Sent", "OK");
            else if (response == "Email")
                await DisplayAlert("Sending...", "Email Sent", "OK");
            else if (response == "Delete")
                await DisplayAlert("Deleting...", "Deleted", "OK");
        }
    }
}