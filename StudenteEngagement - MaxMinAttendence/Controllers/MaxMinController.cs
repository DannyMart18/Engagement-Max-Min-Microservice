using Microsoft.AspNetCore.Mvc;
using StudenteEngagement___MaxMinAttendence.Models;

namespace StudenteEngagement___MaxMinAttendence.Controllers;

[ApiController]
[Route("MaxMin")]
public class MaxMinController: ControllerBase
{
    
    [HttpPost]
    public ActionResult GetMaxMinAttendance([FromBody] AttendanceData data){
        
        var attendanceList = new[]
        {
            new { Name = "Lecture", Number = data.Lecture },
            new { Name = "Lab", Number = data.Lab },
            new { Name = "Support", Number = data.Support },
            new { Name = "Canvas", Number = data.Canvas }
        };

        var max = attendanceList.OrderByDescending(a => a.Number).First();
        var min = attendanceList.OrderBy(a => a.Number).First();

        
        if(data.Lecture > 33){
            return BadRequest("Lecture hours cannot be greater than 33");
        }
        
        if(data.Lab > 22){
            return BadRequest("Lab hours cannot be greater than 33");
        }
        
        if(data.Support > 44){
            return BadRequest("Support hours cannot be greater than 33");
        }
        
        if(data.Canvas > 55){
            return BadRequest("Canvas hours cannot be greater than 33");
        }


        var result = new
        {
            MaxAttendance = $"{max.Name} - {max.Number}",
            MinAttendance = $"{min.Name} - {min.Number}"
        };

        return Ok(result);

    }
    
}

