using System;
using System.Collections.Generic;
using RockPlaylist.Models;

namespace RockPlaylist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RockBand> bands = new List<RockBand>();
            
            List<Song> songs = new List<Song>();
            //Song song = new Song("12-Bar Original", 1965);
            //songs.Add(song);
            songs.Add(new Song("12-Bar Original", 1965));
            songs.Add(new Song("Ask Me Why", 1962));
            songs.Add(new Song("Beautiful Dreamer", 1963));
            List<Album> albums = new List<Album>();
            //Album album = new Album("Please Please Me", 1962);
            //albums.Add(album);
            albums.Add(new Album("Please Please Me", 1962));
            albums.Add(new Album("The Beatles", 1968));
            albums.Add(new Album("Live at the BBC", 1963));
            albums.Add(new Album("Let It Be", 1969));
            List<MemberOfRockBand> members = new List<MemberOfRockBand>();
            //MemberOfRockBand member = new MemberOfRockBand("Джон Леннон", 40, "Вокалист");
            //members.Add(member);
            members.Add(new MemberOfRockBand("Джон Леннон", 40, "Вокалист"));
            members.Add(new MemberOfRockBand("Пол Маккартни", 78, "Бас-Гитарист"));
            members.Add(new MemberOfRockBand("Джордж Харрисон", 58, "Бас-Гитарист"));
            members.Add(new MemberOfRockBand("Ринго Старр", 80, "Барабанщик"));

            RockBand band = new RockBand("The Beatles", songs, members, albums);
            band.Info();
            bands.Add(band);

            songs.Clear();
            albums.Clear();
            members.Clear();

            songs.Add(new Song("Bohemian Rhapsody", 1975));
            songs.Add(new Song("Don’t Stop Me Now", 1979));
            songs.Add(new Song("We Will Rock You", 1977));

            albums.Add(new Album("Hot Space", 1982));
            albums.Add(new Album("The Miracle", 1989));
            albums.Add(new Album("A Night at the Opera", 1975));

            members.Add(new MemberOfRockBand("Брайан Мэй", 73, "Гитарист"));
            members.Add(new MemberOfRockBand("Фредди Меркьюри", 45, "Вокалист"));
            members.Add(new MemberOfRockBand("Роджер Тейлор", 71, "Барабанщик"));
            members.Add(new MemberOfRockBand("Джон Дикон", 69, "Бас-Гитарист"));

            bands.Add(new RockBand("Queen", songs, members, albums));

            songs.Clear();
            albums.Clear();
            members.Clear();

            Menu(bands);
        }

        static void Menu(List<RockBand> bands)
        {
            string choose;
            int option = -1;
            string name;
            while (option != 2)
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("1) Choose rock band");
                Console.WriteLine("2) Exit");
                choose = Console.ReadLine();
                option = int.Parse(choose);
                switch (option)
                {
                    case 1:
                    {
                        foreach (var band in bands)
                        {
                            Console.WriteLine(band.Name);
                        }
                        Console.WriteLine("Enter name of the rock band: ");
                        name = Console.ReadLine();
                        foreach (var band in bands)
                        {
                            if (name == band.Name)
                            {
                                band.Info();
                            }
                            else
                            {
                                Console.WriteLine("Sorry such group is not on the list");
                            }
                        }
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Bye");
                        Environment.Exit(0);
                        break;
                    }
                }
            }
        }
    }
}
