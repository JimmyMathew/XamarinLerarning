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
    public partial class TableViewPage : ContentPage
    {
        public TableViewPage()
        {
            InitializeComponent();
        }

        private void EntryCell_Completed(object sender, EventArgs e)
        {

        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {

        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new ContactsMethodPage();
            page.ContactMethods.ItemSelected += (source, args) => {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }
    }
}