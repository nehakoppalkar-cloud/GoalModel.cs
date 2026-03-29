public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public List<string>? ApplicationIds { get; set; }
    public List<string>? AccountIds { get; set; }
    public List<string>? GoalIds { get; set; }
    public List<string>? TransactionIds { get; set; }
}
