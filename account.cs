public class Account
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public long Number { get; set; }
    public string? Name { get; set; }
    public double Balance { get; set; }
    public string? AccountType { get; set; }
    public List<string>? TransactionIds { get; set; }
}
