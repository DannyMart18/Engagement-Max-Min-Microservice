using Studente_Engagement___Sorting.Models;

namespace Student_Engagement___Sorting.Controllers;

using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("Sort")]
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
        
        //add validation for hours
        if(data.Lecture > 33){
            return BadRequest("Lecture hours cannot be greater than 33");
        }
        
        //add validation for hours
        if(data.Lab > 22){
            return BadRequest("Lab hours cannot be greater than 22");
        }
        
        //add validation for hours
        if(data.Support > 44){
            return BadRequest("Support hours cannot be greater than 44");
        }   
        
        //add validation for hours
        if(data.Canvas > 55){
            return BadRequest("Canvas hours cannot be greater than 55");
        }
        
        
        //sort attendanceList in descending order
        
        var sortedAttendanceList = attendanceList.OrderByDescending(a => a.Number).ToArray();

        var result = new
        {
            Sorted = sortedAttendanceList.Select(a => new { a.Name, a.Number })
        };

        return Ok(result);

    }
    
}

