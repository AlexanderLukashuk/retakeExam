namespace RockPlaylist.Models
{
    public class MemberOfRockBand : Entity
    {
        public int Age { get; set; }
        public string Role { get; set; }
        public MemberOfRockBand(string name, int age, string role) : base(name)
        {
            Age = age;
            Role = role;
        }
    }
}