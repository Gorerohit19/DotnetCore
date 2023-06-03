using System;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbTest;
public class Student
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId  Id{get; set;}
    public string studentFirstName {get; set;}
    public string studentLastName {get; set;}
    public string email {get; set;}
    public string contactNumber {get; set;}
    public string location {get; set;}
}