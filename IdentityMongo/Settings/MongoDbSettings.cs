namespace IdentityMongo.Settings
{
    public class MongoDbSettings
    {
        public string Database { get; init; }
        public string Host { get; init; }
        public int Port { get; init; }
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}
