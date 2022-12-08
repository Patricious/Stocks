using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookStoreApi.Models;

public class Stock
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Stock")]

    public string currency_code { get; set; }

    public decimal industry { get; set; }

    public string stock { get; set; }

    public string value { get; set; }

    public string date { get; set; }
 
    public string currencycode { get; set; } 
}

