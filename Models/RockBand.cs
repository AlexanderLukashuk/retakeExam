using System;
using System.Collections.Generic;

namespace RockPlaylist.Models
{
    public class RockBand : Entity
    {
        public List<Song> Songs { get; set; }
        public List<MemberOfRockBand> Members { get; set; }
        public List<Album> Albums { get; set; }

        public RockBand(string name, List<Song> songs, List<MemberOfRockBand> members, List<Album> albums) : base(name)
        {
            foreach (var song in songs)
            {
                Songs.Add(song);
            }

            foreach (var member in members)
            {
                Members.Add(member);
            }

            foreach (var album in albums)
            {
                Albums.Add(album);
            }
        }

        public void Info()
        {
            Console.WriteLine($"Name of rock band: {Name}");
            Console.WriteLine("Songs:");
            Console.WriteLine("Members of rock band:");
            foreach (var member in Members)
            {
                Console.WriteLine($"Name: {member.Name} Age: {member.Age} Role in rock band: {member.Role}");
            }

            Console.WriteLine("Groups album:");
            foreach (var album in Albums)
            {
                Console.WriteLine($"Name: {album.Name} Year of creation: {album.YearOfCreation}");
            }

            Console.WriteLine("Songs:");
            foreach (var song in Songs)
            {
                Console.WriteLine($"Name: {song.Name} Year of creation: {song.YearOfCreation}");
            }
        }

        public void AddSong(string name, int year)
        {
            Song song = new Song(name, year);
            Songs.Add(song);
        }

        public void AddMember(string name, int age, string role)
        {
            MemberOfRockBand member = new MemberOfRockBand(name, age, role);
            Members.Add(member);
        }

        public void AddAlbum(string name, int year)
        {
            Album album = new Album(name, year);
            Albums.Add(album);
        }
    }
}