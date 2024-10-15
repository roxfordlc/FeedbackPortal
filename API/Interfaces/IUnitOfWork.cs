using System;

namespace API.Interfaces;

public interface IUnitOfWork
{
    IUserRepository UserRepository {get;}
    IFeedbackRepository FeedbackRepository {get;}
    Task<bool> Complete();
    bool HasChanges();
}
