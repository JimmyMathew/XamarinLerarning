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
    public partial class Advanced : ContentPage
    {
        public Advanced()
        {
            InitializeComponent();
            //Code behind for setting resources
            //this.Resources = new ResourceDictionary();
            //this.Resources["borderRadius"] = 20;

        }
    }
}