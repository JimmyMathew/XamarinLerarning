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
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            var imageSource = new UriImageSource { Uri =  new Uri("https://picsum.photos/seed/picsum/200/300") };
            imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);
            //We can also give the source as string like 
            //image.Source = "http://..."
            //Image 
            //image.Source = ImageSource.FromResource("XamarinLearningApp.Images.background.jpg");
        }
    }
}