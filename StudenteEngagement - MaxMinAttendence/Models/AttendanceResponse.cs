namespace StudenteEngagement___MaxMinAttendence.Models;

public class AttendanceResponse
{
    public string SessionLabel { get; set; }
    public int AttendanceHours { get; set; }
    public bool IsWithinLimits { get; set; }
}