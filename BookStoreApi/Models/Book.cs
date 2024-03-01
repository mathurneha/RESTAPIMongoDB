using System;
using MongoDB.Bson.Serialization.Attributes;

namespace BookStoreApi.Models
{
	public class Book
	{
		[BsonId] //Document's primary key
		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
		public string? Id { get; set; }

		//null! is used to assign null to non-nullable variables, which is a way of promising that the variable won't be null when it's actually used.
		[BsonElement("Name")]
		public string BookName { get; set; } = null!;

		public decimal Price { get; set; }

		public string Category { get; set; } = null!;

		public string Author { get; set; } = null!;
	}
}

