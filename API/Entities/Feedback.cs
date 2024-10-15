namespace API.Entities;

public class Feedback
{
    public int Id { get; set; }
    public required string SenderUsername { get; set; }
    public required string RecipientUsername { get; set; }
    public bool Acknowledged { get; set; }
    public required string Content { get; set; }
    public Comment? Comment { get; set; }
    public required DateTime Created { get; set; }
    public DateTime? TimeAcknowledged { get; set; } 

    public User Sender { get; set; } = null!;
    public int SenderId { get; set; }
    public User Recipient { get; set; } = null!;
    public int RecipientId { get; set; }
}
