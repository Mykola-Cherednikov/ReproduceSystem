using MongoDB.Bson.Serialization.Attributes;

namespace ReproduceSystem.Domain.Entities.Body
{
    [BsonKnownTypes(typeof(RawBody), typeof(FormDataBody))]
    public abstract class BodyContent
    {
    }
}
