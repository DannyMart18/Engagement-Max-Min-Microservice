namespace Studente_Engagement___Sorting.Models;

public class AttendanceResponse
{
    public string SessionLabel { get; set; }
    public int AttendanceHours { get; set; }
    public bool IsWithinLimits { get; set; }
}