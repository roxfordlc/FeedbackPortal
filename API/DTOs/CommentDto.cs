using System;

namespace API.DTOs;

public class CommentDto
{
    public int Id { get; set; }
    public required string Content { get; set; }
    public required DateTime Created { get; set; }
}
