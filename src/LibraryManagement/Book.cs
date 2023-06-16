namespace LibraryManagement
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public Guid? ReaderId { get; set; }

        public Book(string name, string description, string author)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Author = author;
        }

        public override string ToString()
        {
            return $"Kitob" +
                $"\n id : {Id}, " +
                $"\n nomi : {Name}, " +
                $"\n muallifi : {Author}" +
                $"\n kim o'qiyapti : {ReaderId}\n";
        }
    }
}
