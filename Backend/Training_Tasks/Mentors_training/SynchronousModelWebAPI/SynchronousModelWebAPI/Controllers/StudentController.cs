using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASynchronousModelWebAPI.Data;
using ASynchronousModelWebAPI.Models;

namespace ASynchronousModelWebAPI.Controllers
{
    public class StudentController:ControllerBase
    {
        Context context;
        public StudentController(Context Context)
        {
            context = Context;
        }

        [HttpGet("/GetStudents")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await context.Students.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            if (context.Students == null)
            {
                return NotFound();
            }
            var student = await context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        [HttpPost("/createStudent")]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            context.Students.Add(student);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student); 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }
            context.Entry(student).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            if (context.Students == null)
            {
                return NotFound();
            }

            var student = await context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            context.Students.Remove(student);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentExists(long id)
        {
            return (context.Students?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
