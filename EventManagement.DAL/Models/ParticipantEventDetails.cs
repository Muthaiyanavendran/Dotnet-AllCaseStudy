namespace EventManagement.DAL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ParticipantEventDetails
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("UserInfo")]
    public string ParticipantEmailId { get; set; }

    [Required]
    [ForeignKey("EventDetails")]
    public int EventId { get; set; }

    [Required]
    [RegularExpression("Yes|No")]
    public string IsAttended { get; set; }
}
