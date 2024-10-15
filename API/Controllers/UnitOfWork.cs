using API.Data;
using API.Interfaces;

namespace API.Controllers;

public class UnitOfWork(DataContext context, IUserRepository userRepository, IFeedbackRepository feedbackRepository) : IUnitOfWork
{
    public IUserRepository UserRepository => userRepository;
    public IFeedbackRepository FeedbackRepository => feedbackRepository;

    public async Task<bool> Complete()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public bool HasChanges()
    {
        return context.ChangeTracker.HasChanges();
    }
}
