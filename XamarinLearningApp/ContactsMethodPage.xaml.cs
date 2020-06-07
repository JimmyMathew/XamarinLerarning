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
    public partial class ContactsMethodPage : ContentPage
    {
        public ContactsMethodPage()
        {
            InitializeComponent();
            listview.ItemsSource = new List<string> { 
            "None",
            "Email",
            "SMS"
            };
        }

       public ListView ContactMethods { get { return listview; }  }
    }
}