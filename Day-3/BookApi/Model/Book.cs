namespace BookApi.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime PublishedDate { get; set; }
        public decimal Price { get; set; }
        // Additional properties can be added as needed
    }
}
