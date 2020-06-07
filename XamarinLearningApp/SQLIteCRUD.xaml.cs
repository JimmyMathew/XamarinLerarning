using SQLite;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLearningApp.Persistance;

namespace XamarinLearningApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    //[Table("Recipes")] -  If you want a different name for your table
    public class Recipe :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        private string _name; //Backing field
        [MaxLength(255)]
        public string Name {
            get { return _name; }
            set {
                if (_name == value)
                    return;
                    _name = value;
                OnPropertyChanged(nameof(Name));
                    }

        }
        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public partial class SQLIteCRUD : ContentPage
    {

        private SQLiteAsyncConnection connection;
        private ObservableCollection<Recipe> recipesObservable;
        public SQLIteCRUD() 
        {
            InitializeComponent();
            connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }
        protected override async void OnAppearing()
        {
            await connection.CreateTableAsync<Recipe>();
            var recipes  = await connection.Table<Recipe>().ToListAsync();
            recipesObservable = new ObservableCollection<Recipe>(recipes);
            recipeListView.ItemsSource = recipesObservable;

        }
        async void onAdd(object sender,System.EventArgs e) {
            var recipe = new Recipe { Name = "Recipe " + DateTime.Now.Ticks };
            await connection.InsertAsync(recipe);
            recipesObservable.Add(recipe);
        }
        async void onUpdate(object sender, System.EventArgs e)
        {
            var firstRecipe = recipesObservable[0];
            firstRecipe.Name += "Updated";
            await connection.UpdateAsync(firstRecipe);
        } 
        async void onDelete(object sender, System.EventArgs e)
        {
            var firstRecipe = recipesObservable[0];
            await connection.DeleteAsync(firstRecipe);
            recipesObservable.Remove(firstRecipe);
        }
    }
}