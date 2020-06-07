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
    public class ContactMethod { 
         public string ID { get; set; }
        public string Name { get; set; }
    }
    public partial class FormsPage : ContentPage
    {
        public FormsPage()
        {
            InitializeComponent();
            //hiddenlabel.IsVisible = false;
            foreach (var item in GetContactMethods())
            {
                picker.Items.Add(item.Name);
            }
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            completelabel.Text = "Completed";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            completelabel.Text = e.NewTextValue;
        }
        private IList<ContactMethod> GetContactMethods() {
            return new List<ContactMethod>
            {
                new ContactMethod{ ID ="1" , Name = "SMS"},
                new ContactMethod{ ID ="2" , Name = "Email"},

            };
        }
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name  = picker.Items[picker.SelectedIndex];
            var contactMethod = GetContactMethods().Single(cm => cm.Name == name);
            DisplayAlert("SelectedOption", contactMethod.ID, "OK");
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            //e.NewDate;
            //e.OldDate;
        }

        //private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    e.OldValue;
        //    e.NewValue;
        //}

        //private void Switch_Toggled(object sender, ToggledEventArgs e)
        //{
        //    hiddenlabel.IsVisible = e.Value;
        //}
    }
}