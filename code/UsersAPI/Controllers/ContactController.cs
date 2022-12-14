using Microsoft.AspNetCore.Mvc;
using UsersAPI.Context;
using UsersAPI.Entities;

namespace UsersAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ScheduleContext _context;
        public ContactController(ScheduleContext context)
        {
            _context = context;
        }

        [HttpPost("Create")]
        public IActionResult Create(Contact contact)
        {
            if (string.IsNullOrEmpty(contact.Name))
                return BadRequest("Todos os campos devem vir preenchidos.");
            else
            {
                _context.Add(contact);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetById), new { id = contact.Id }, contact);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null) return NotFound();
            return Ok(contact);
        }

        [HttpGet("GetByName")]
        public IActionResult GetByName(string name)
        {
            var contacts = _context.Contacts.Where(x => x.Name.Contains(name));

            if (contacts.Count() == 0) return NotFound("Sem contatos com esse nome");
            return Ok(contacts);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact contact)
        {
            var contactDatabase = _context.Contacts.Find(id);

            if (contactDatabase == null) return NotFound();

            contactDatabase.Name = contact.Name;
            contactDatabase.Phone = contact.Phone;
            contactDatabase.Active = contact.Active;

            _context.Contacts.Update(contactDatabase);
            _context.SaveChanges();

            return Ok(contactDatabase);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contactDatabase = _context.Contacts.Find(id);

            if (contactDatabase == null) return NotFound();

            _context.Contacts.Remove(contactDatabase);
            _context.SaveChanges();
            return NoContent();
        }
    }
}