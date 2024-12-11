using System.ComponentModel.DataAnnotations;
namespace MedicalAppointmentsApp.Models;

public class Appointment
{
    public int AppointmentId { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    [StringLength(255)]
    public string? Reason { get; set; }

    [Required]
    public int PatientId { get; set; }

    public Patient? Patient { get; set; }
}