using Microsoft.AspNetCore.Mvc;
using DTOExample.Data;
using DTOExample.DTO;
using DTOExample.Model;
using Microsoft.EntityFrameworkCore;

namespace DTOExample.Controllers
{
    [ApiController]
    [Route("api/Students")]
    public class StudentController:ControllerBase
    {
        public readonly Context context;
        public StudentController(Context context)
        {
            this.context = context;
        }

        [HttpGet("/AllStudents")]
        public async Task<ActionResult<IEnumerable<WriteDTO>>> GetAllStudents()
        {
            var students = await context.Students.ToListAsync();
            var writeDTOs = new List<WriteDTO>(); 

            foreach (var student in students)
            {
                var writeDTO = new WriteDTO
                {
                    Id = student.Id,
                    FullName = student.FirstName + " " + student.LastName,
                    Email = student.Email
                };
                writeDTOs.Add(writeDTO);
            }

            return writeDTOs; 
        }
        [HttpGet("/student/id")]
        public async Task<ActionResult<WriteDTO>> GetStudent(int id)
        {
            var student = await context.Students.FindAsync(id);
            if (student != null)
            {
                var writeDTO = new WriteDTO
                {
                    Id = student.Id,
                    FullName = student.FirstName + " " + student.LastName,
                    Email = student.Email
                };
                return writeDTO;
            }
            return NotFound();
        }
        [HttpPost("/CreateStudent")]
        public async Task<ActionResult<Student>> CreateStudent(ReadDTO readDTO)
        {
            var student = new Student
            {
                FirstName = readDTO.FirstName,
                LastName = readDTO.LastName,
                Email = readDTO.Email
            };

            
            context.Students.Add(student);
            await context.SaveChangesAsync();

            return student;
        }
        [HttpPut("/UpdateStudent")]
        public async Task<ActionResult<ReadDTO>> UpdateStudent(int id,ReadDTO updateDTO)
        {
            var student =await context.Students.FindAsync(id);
            if (student != null)
            {
                student.FirstName = updateDTO.FirstName;
                student.LastName = updateDTO.LastName;
                student.Email = updateDTO.Email;

                await context.SaveChangesAsync();
                return updateDTO;
            }
            return NotFound();
        }
        [HttpDelete("/DeleteStudent")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var student =await context.Students.FindAsync(id);
            if(student != null)
            {
                context.Students.Remove(student);
                await context.SaveChangesAsync();
                return student;
            }
            return NotFound();
        }
    }
}
