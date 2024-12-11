using System.ComponentModel.DataAnnotations;
namespace MedicalAppointmentsApp.Models;

public class Patient
{
    public int PatientId { get; set; }

    [Required]
    [StringLength(50)]
    public string? FirstName { get; set; }

    [Required]
    [StringLength(50)]
    public string? LastName { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    public string? Description { get; set; }

    public ICollection<Appointment>? Appointments { get; set; }
}