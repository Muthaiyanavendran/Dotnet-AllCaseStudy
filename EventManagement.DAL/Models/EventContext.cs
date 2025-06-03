using Microsoft.EntityFrameworkCore;
using EventManagement.DAL.Models;

namespace EventManagement.DAL;

public class EventContext : DbContext
{
    public DbSet<UserInfo> Users { get; set; }
    public DbSet<EventDetails> Events { get; set; }
    public DbSet<SpeakersDetails> Speakers { get; set; }
    public DbSet<SessionInfo> Sessions { get; set; }
    public DbSet<ParticipantEventDetails> Participants { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=NLPULTP2803311;Database=eventdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
    }
}
