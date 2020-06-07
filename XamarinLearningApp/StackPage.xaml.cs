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
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();
            //Code Behind layout
            //var layout = new StackLayout
            //{
            //    BackgroundColor = Color.Blue,
            //    Orientation = StackOrientation.Horizontal,
            //    Padding = new Thickness(0, 20, 0, 0)
            //};
            //layout.Children.Add(new Label { Text = "CodeBehindLabel"});
            //Content = layout;
        }
    }
}