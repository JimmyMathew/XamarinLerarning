using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using Xamarin.Forms.Xaml;

namespace XamarinLearningApp
{
    public partial class App : Application
    {
        public const string TitleKey = "Name";
        public const string NotificationKey = "NotificationsEnabled";
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new TableViewPage())
            //{
            //    //BarBackgroundColor = Color.Green,
            //    //BarTextColor = Color.Black
            //};
            //MainPage = new NavigationPage(new ApiPage());
            MainPage = new Advanced();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
       

        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();
                return "";
            }
            set
            {
                Properties[TitleKey] = value;
            }
        }
        public bool NotificationEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationKey))
                    return (bool)Properties[NotificationKey];
                return false;
            }
            set
            {
                Properties[NotificationKey] = value;
            }
        }

    }
}
