namespace RockPlaylist.Models
{
    public class Song : Entity
    {
        public int YearOfCreation { get; set; }

        public Song(string name, int year) : base(name)
        {
            YearOfCreation = year;
        }
    }
}