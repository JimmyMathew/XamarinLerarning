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
    public partial class MasterDetailsPage : MasterDetailPage
    {
        private ObservableCollection<Contact> _contacts;
        public MasterDetailsPage()
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
        }

        void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
          
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage( new ContactDetailPage(contact));
            IsPresented = false;//IsMasterPresented
          
        }
    }
}