using System;

namespace API.Helpers;

public class FeedbackParams: PaginationParams
{
    public int SenderId { get; set; }
    public int RecipientId { get; set; }
}
