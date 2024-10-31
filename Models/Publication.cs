namespace LibrarySystem.Models
{
    public abstract class Publication
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsRented { get; private set; }

        public void Rent() => IsRented = true;
        public void Return() => IsRented = false;
    }
}
