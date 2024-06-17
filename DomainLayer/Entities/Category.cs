using System.Collections.Generic;

namespace DomainLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property
        public ICollection<Book> Books { get; set; }
    }
}