using API.Interfaces;

namespace API.Data;

public class UnitOfWork(DataContext context, IUserRepository userRepository): IUnitOfWork
{
    public IUserRepository UserRepository => userRepository;
    public IFeedbackRepository FeedbackRepository => FeedbackRepository;
    public async Task<bool> Complete()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public bool HasChanges()
    {
        return context.ChangeTracker.HasChanges();
    }
}
