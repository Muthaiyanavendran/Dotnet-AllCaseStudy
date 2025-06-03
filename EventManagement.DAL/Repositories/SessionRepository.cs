using EventManagement.DAL.Models;

namespace EventManagement.DAL.Repositories;

public class SessionRepository : IRepository<EventDetails>
{
    private readonly EventContext _context = new();

    public void Add(EventDetails entity)
    {
        _context.Events.Add(entity);
        _context.SaveChanges();
    }

    public IEnumerable<EventDetails> GetAll() => _context.Events.ToList();

    public EventDetails Get(int id) => _context.Events.Find(id);

    public void Update(EventDetails entity)
    {
        _context.Events.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var ev = _context.Events.Find(id);
        if (ev != null)
        {
            _context.Events.Remove(ev);
            _context.SaveChanges();
        }
    }
}
