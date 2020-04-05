using Microsoft.EntityFrameworkCore;

namespace ScriptureJournal.Data
{
    public class ScriptureJournalContext : DbContext
    {
        public ScriptureJournalContext (
            DbContextOptions<ScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<ScriptureJournal.Models.Scripture> Scripture { get; set; }
    }
}