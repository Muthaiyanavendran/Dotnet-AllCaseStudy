namespace EventManagement.DAL.Models;
using System.ComponentModel.DataAnnotations;

public class SpeakersDetails
{
    [Key]
    public int SpeakerId { get; set; }

    [Required, StringLength(50, MinimumLength = 1)]
    public string SpeakerName { get; set; }
}
