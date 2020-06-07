using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLearningApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApiPage : ContentPage
    {
        public class Post { 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        }
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient client = new HttpClient();
        private ObservableCollection<Post> _posts;
        public ApiPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            var content = await client.GetStringAsync(Url);
            var posts =  JsonConvert.DeserializeObject<List<Post>>(content);
            _posts = new ObservableCollection<Post>(posts);
            postsList.ItemsSource = _posts;
        }
        async void onAdd(object sender, System.EventArgs e)
        {
            var post = new Post { Title = "Title" + DateTime.Now.Ticks };
            _posts.Insert(0, post);
            var content = JsonConvert.SerializeObject(post);
            await client.PostAsync(Url, new StringContent(content));
           
        }
        async void onUpdate(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            post.Title = "Updated";
            var content = JsonConvert.SerializeObject(post);
            await client.PutAsync(Url+"/"+post.Id, new StringContent(content));
        }
        async void onDelete(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            _posts.Remove(post);
            await client.DeleteAsync(Url + "/" + post.Id);
            
        }
    }
}