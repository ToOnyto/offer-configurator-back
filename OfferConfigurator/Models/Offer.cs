﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OfferConfigurator.Models
{
    public class Offer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public Product Product { get; set; }
        public DateTime CreatedAt { get; set; }
        public Nullable<DateTime> StartAt { get; set; }
        public Nullable<DateTime> EndAt { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string SubmittedBy { get; set; }
        public string Price { get; set; }
    }

    public class OfferBody
    {
        public string ProductId { get; set; }
        public string Price { get; set; }
        public string SubmittedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<DateTime> StartAt { get; set; }
        public Nullable<DateTime> EndAt { get; set; }
    }
}
