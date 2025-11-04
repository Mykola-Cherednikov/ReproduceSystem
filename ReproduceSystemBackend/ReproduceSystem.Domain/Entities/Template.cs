using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ReproduceSystem.Domain.Entities
{
    public class Template
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("steps")]
        public List<Step> Steps { get; set; }
    }
}
