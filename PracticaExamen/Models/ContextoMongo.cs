using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaExamen.Models
{
    public class ContextoMongo 
    {
        public IMongoDatabase database;
        public ContextoMongo()
        {
            var connectionString = Properties.Settings.Default.mongoConnection;
            var client = new MongoClient(connectionString);
            database = client.GetDatabase(Properties.Settings.Default.databaseName);
        }

        public IMongoCollection<Cliente> Clientes
        {
            get
            {
                return (database.GetCollection<Cliente>("cliente"));
            }
            set
            {
            }
        }

    }

}