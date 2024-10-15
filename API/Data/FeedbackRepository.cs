using System;
using API.DTOs;
using API.Entities;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class FeedbackRepository(DataContext context, Mapper mapper) : IFeedbackRepository
{
    public void AddComment(Feedback feedback, Comment comment)
    {
        if(feedback.Content == null) return;
        feedback.Comment = comment;
        context.Feedback.Update(feedback);

    }

    public void AddFeedback(Feedback feedback)
    {
        context.Feedback.Add(feedback);
    }

    public void DeleteComment(Feedback feedback)
    {
        feedback.Comment = null;
        context.Feedback.Update(feedback);
    }

    public void DeleteFeedback(Feedback feedback)
    {
        context.Feedback.Remove(feedback);
    }

    public async Task<Feedback?> GetFeedback(int id)
    {
        return await context.Feedback.FindAsync(id);
    }

    public async Task<PagedList<FeedbackDto>> GetReceivedFeedbackForUser(FeedbackParams feedbackParams)
    {
        var query = context.Feedback.OrderBy(x => x.Created).Where(x => x.RecipientId == feedbackParams.RecipientId).AsQueryable();

        var feedback = query.ProjectTo<FeedbackDto>(mapper.ConfigurationProvider);

        return await PagedList<FeedbackDto>.CreateAsync(feedback,feedbackParams.PageNumber, feedbackParams.PageSize);

    }
    public async Task<PagedList<FeedbackDto>> GetSentFeedbackForUser(FeedbackParams feedbackParams)
    {
        var query = context.Feedback.OrderBy(x => x.Created).Where(x => x.SenderId == feedbackParams.SenderId).AsQueryable();

        var feedback = query.ProjectTo<FeedbackDto>(mapper.ConfigurationProvider);

        return await PagedList<FeedbackDto>.CreateAsync(feedback,feedbackParams.PageNumber, feedbackParams.PageSize);
    }

}
