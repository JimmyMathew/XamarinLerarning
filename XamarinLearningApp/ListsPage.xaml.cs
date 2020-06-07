using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLearningApp.Models;

namespace XamarinLearningApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListsPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;
        public ListsPage()
        {
            InitializeComponent();
            var names = new List<String> { 
            "Jimmy", "Mathew","Joji"
            };
            //Basic list

           _contacts = new ObservableCollection<Contact> {
                new Contact { Name = "Jimmy", ImageUrl = "https://i.picsum.photos/id/237/200/300.jpg" },
                new Contact { Name = "Joji", ImageUrl = "https://i.picsum.photos/id/237/200/300.jpg", Status = "Hey,Let's talk" }
            };
            listview.ItemsSource = _contacts;
            //List with groups
            //listview.ItemsSource = new List<ContactGroup> {
            //    new ContactGroup("M","M"){
            //      new Contact { Name = "Mathew", ImageUrl = "https://i.picsum.photos/id/237/200/300.jpg" },
            //    },
            //    new ContactGroup("J","J"){
            //    new Contact { Name = "Joji", ImageUrl = "https://i.picsum.photos/id/237/200/300.jpg", Status = "Hey,Let's talk" }
            //    }

            //};
        }
        private void listview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        async void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //To disable a selected event
            //listview.ItemSelected = null;
            if (e.SelectedItem == null)
                return;
            var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");
           await  Navigation.PushAsync(new ContactDetailPage(contact));
            listview.SelectedItem = null;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact  = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }
        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);

        }

        private void listview_Refreshing(object sender, EventArgs e)
        {
            listview.ItemsSource = GetContacts();
            //To disable the activity indicator we can either use the first on or the method
            //listview.IsRefreshing = false;
            listview.EndRefresh();
        }
        List<Contact> GetContacts(string searchText = null) {
            var contacts =  new List<Contact> {
                new Contact { Name = "Jimmy", ImageUrl = "https://i.picsum.photos/id/237/200/300.jpg" },
                new Contact { Name = "Joji", ImageUrl = "https://i.picsum.photos/id/237/200/300.jpg", Status = "Hey,Let's talk" }
            };
            if (string.IsNullOrWhiteSpace(searchText))
                return contacts;
            return contacts.Where(c => c.Name.StartsWith(searchText)).ToList();
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}