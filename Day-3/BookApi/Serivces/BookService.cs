using BookApi.Model;
namespace BookApi.Serives
{
    public class BookService
    {
        private List<Book> _books;

        public BookService() {
            _books = new List<Book> { };
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public List<Book> GetAll()
        {
            return _books;
        }
        public Book? GetBookbyId(int id)
        {
            return _books.Find(x => x.Id == id);
        }

        public void DeleteBook(Book book)
        {
            _books.Remove(book);

        }

        public void UpdateBook(Book book)
        {
            var existingBook = GetBookbyId(book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Genre = book.Genre;
                existingBook.PublishedDate = book.PublishedDate;
                existingBook.Price = book.Price;
            }
        }

     }
}
