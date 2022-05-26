namespace NotesApi.Settings
{
    public class MongoDBSettings : IMongoDBSettings
    {
        public string NoteCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
