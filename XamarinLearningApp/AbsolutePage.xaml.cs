
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLearningApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();
            //Absolute layout from code behind 
            //var layout = new AbsoluteLayout { 
            //Padding = new Thickness(0, 20, 0, 0)
            //};
            //Content = layout;
            //var aquaBox = new BoxView { 
            //Color = Color.Aqua
            //};
            //layout.Children.Add(aquaBox, new Rectangle(0, 0, 1,1), AbsoluteLayoutFlags.All);
            //AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));
            //AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.HeightProportional);
        }
    }
}