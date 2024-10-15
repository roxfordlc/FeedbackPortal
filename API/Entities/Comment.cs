using System;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.Entities;

public class Comment
{
    public int Id { get; set; }
    public required string Content { get; set; }
    public required DateTime Created { get; set;} = DateTime.UtcNow;
}
