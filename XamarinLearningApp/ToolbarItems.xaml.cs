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
    public partial class ToolbarItems : ContentPage
    {
        public ToolbarItems()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sample", "Sample", "OK");
        }
    }
}