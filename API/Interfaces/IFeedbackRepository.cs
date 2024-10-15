using API.DTOs;
using API.Entities;
using API.Helpers;

namespace API.Interfaces;

public interface IFeedbackRepository
{
    Task<PagedList<FeedbackDto>> GetReceivedFeedbackForUser(FeedbackParams feedbackParams);
    Task<PagedList<FeedbackDto>> GetSentFeedbackForUser(FeedbackParams feedbackParams);
    Task<Feedback?> GetFeedback(int id);
    
    void AddFeedback(Feedback feedback);
    void AddComment(Feedback feedback, Comment comment);
    void DeleteFeedback(Feedback feedback);
    void DeleteComment(Feedback feedback);

}
