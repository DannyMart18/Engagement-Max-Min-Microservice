using Microsoft.AspNetCore.Mvc;
using StudenteEngagement___MaxMinAttendence.Models;

namespace StudenteEngagement___MaxMinAttendence.Controllers;

[ApiController]
[Route("MaxMin")]
public class MaxMinController: ControllerBase
{
    
    [HttpPost]
    public ActionResult GetMaxMinAttendance([FromBody] AttendanceData data){
        
        var attendanceNumbers =  new [] {data.Lecture, data.Lab, data.Support, data.Canvas};
        var max = attendanceNumbers.Max();
        var min = attendanceNumbers.Min();
        
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
            maxAttendance = max,
            minAttendance = min
        };

        return Ok(result);

    }
    
}

