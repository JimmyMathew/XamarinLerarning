using SQLite;
namespace XamarinLearningApp.Persistance
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
