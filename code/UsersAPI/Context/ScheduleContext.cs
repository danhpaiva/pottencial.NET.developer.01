using Microsoft.EntityFrameworkCore;
using UsersAPI.Entities;

namespace UsersAPI.Context
{
  public class ScheduleContext : DbContext
  {
    public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options)
    {

    }

    public DbSet<Contact> Contacts { get; set; }
  }
}