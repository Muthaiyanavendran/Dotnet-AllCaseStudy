namespace EventManagement.DAL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SessionInfo
{
    [Key]
    public int SessionId { get; set; }

    [ForeignKey("EventDetails")]
    public int EventId { get; set; }

    [Required, StringLength(50)]
    public string SessionTitle { get; set; }

    [ForeignKey("SpeakersDetails")]
    public int? SpeakerId { get; set; }

    public string? Description { get; set; }

    [Required]
    public DateTime SessionStart { get; set; }

    [Required]
    public DateTime SessionEnd { get; set; }

    public string? SessionUrl { get; set; }
}
