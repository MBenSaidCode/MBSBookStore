using System.Collections.Generic;

namespace DomainLayer.Entities
{
    /// <summary>
    /// Represents a Category in the domain layer.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the unique identifier for the Category.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name of the Category.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the Category.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Navigation property for the books associated with the Category.
        /// </summary>
        public ICollection<Book> Books { get; set; }
    }
}
