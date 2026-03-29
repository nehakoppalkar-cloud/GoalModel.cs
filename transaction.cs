public class Transaction
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string? Type { get; set; }
    public string? Description { get; set; }
    public double Amount { get; set; }
    public DateTime DateTime { get; set; }
    public string? GoalId { get; set; }
    public List<string>? TagIds { get; set; }
    public string? UserId { get; set; }
}
