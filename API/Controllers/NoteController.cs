using API.ApplicationDbContext;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly BlazorDbContext _db;

        public NoteController(BlazorDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Note>>> GetAllNote()
        {
            return await _db.notes
             .Include(n => n.Contact)
             .OrderByDescending(n => n.DateCreated) // giảm dần
             .ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<List<Note>>> CreateNote(Note note)
        {
            _db.notes.Add(note);
            await _db.SaveChangesAsync();

            return await _db.notes
                .Where(n => n.ContactId == note.ContactId)
                .OrderByDescending(n => n.DateCreated)
                .ToListAsync();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Note>>> DeleteNote(int id)
        {
            var dbNote = await _db.notes.FindAsync(id);
            if (dbNote is null)
            {
                return NotFound("Note not found.");
            }

            _db.notes.Remove(dbNote);
            await _db.SaveChangesAsync();

            return await _db.notes
                .Where(n => n.ContactId == dbNote.ContactId)
                .OrderByDescending(n => n.DateCreated)
                .ToListAsync();
        }

        [HttpGet("{contactId}")]
        public async Task<ActionResult<List<Note>>> GetNotesFromContact(int contactId)
        {
            return await _db.notes
                .Where(n => n.ContactId == contactId)
                .OrderByDescending(n => n.DateCreated)
                .ToListAsync();
        }

    }
}
