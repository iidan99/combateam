using MongoDB.Driver;
using UnityEngine;

public class Mongo
{
    private const string Mongo_URI = "";
    private const string DATABASE_NAME = "";

    private MongoClient client;
    private MongoServer server;
    private MongoDatabase db;


    public void Init()
    {
        client = new MongoClient(Mongo_URI);
        server = client.GetServer();
        db = server.GetDatabase(DATABASE_NAME);

        Debug.Log("Database hes been initiliazed");
    }

    public void Shutdown()
    {
        client = null;
        server.Shutdown();
        db = null;
    }
}
