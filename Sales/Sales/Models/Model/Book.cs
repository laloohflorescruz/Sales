namespace Sales.Models.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Author { get; set; }
        public int YearOfPublication { get; set; }
        // ReSharper disable once InconsistentNaming
        //public long ISBN { get; set; }
        //public byte[] Photo { get; set; }
        //public double Price { get; set; }
        public int Count { get; set; }
    }
}