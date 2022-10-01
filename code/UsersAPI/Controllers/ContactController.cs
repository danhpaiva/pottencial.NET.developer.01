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
                return Ok(contact);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null) return NotFound();
            return Ok(contact);
        }
    }
}