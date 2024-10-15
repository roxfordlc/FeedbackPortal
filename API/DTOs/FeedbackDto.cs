using System;

namespace API.DTOs;

public class FeedbackDto
{
    public int Id { get; set; }
    public int SenderId { get; set; }
    public required string SenderUsername { get; set; } 
    public int RecipientId { get; set; }
    public required string RecipientUsername { get; set; }
    
}
