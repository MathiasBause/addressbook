namespace apiAddressSecurity.Models
{
    using System.Data.Entity;
    using System.Linq;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public IQueryable<Book> Books { get; internal set; }
    }
}