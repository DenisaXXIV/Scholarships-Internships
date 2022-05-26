namespace NotesApi.Settings
{
    public interface IMongoDBSettings
    {
        string NoteCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
