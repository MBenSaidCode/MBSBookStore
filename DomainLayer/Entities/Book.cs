using System;

namespace DomainLayer.Entities
{
    /// <summary>
    /// Represents a book in the domain layer.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the unique identifier for the book.
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the category this book belongs to.
        /// This is a foreign key to the Category entity.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the ISBN (International Standard Book Number) of the book.
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Gets or sets the description of the book.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date the book was published.
        /// Nullable to accommodate books that may not have a specified published date.
        /// </summary>
        public DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the URL of the cover image for the book.
        /// </summary>
        public string CoverImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the book entity was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the category associated with this book.
        /// This is a navigation property used for ORM (Object-Relational Mapping) to link the book to its category.
        /// </summary>
        public Category Category { get; set; }
    }
}
