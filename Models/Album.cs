namespace RockPlaylist.Models
{
    public class Album : Entity
    {
        public int YearOfCreation { get; set; }
        public Album(string name, int year) : base(name)
        {
            YearOfCreation = year;
        }
    }
}