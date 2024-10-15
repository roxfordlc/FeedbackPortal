using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers;

public class AutoMapperProfiles: Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Feedback, FeedbackDto>();
        CreateMap<FeedbackDto, Feedback>();
        CreateMap<Comment, CommentDto>();
        CreateMap<User, UserDto>();
    }
}
