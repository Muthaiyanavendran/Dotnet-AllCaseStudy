using System;

class Program
{
    static void Main(string[] args)
    {
        MyPlayList playlist = new MyPlayList();
        while (true)
        {
            Console.WriteLine("\nEnter:\n1: To Add Song\n2: To Remove Song by Id\n3: Get Song By Id\n4: Get Song by Name\n5: Get All Songs from Playlist\n6: Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Song newSong = new Song();
                    Console.Write("Enter Song ID: ");
                    newSong.SongId = int.Parse(Console.ReadLine());

                    Console.Write("Enter Song Name: ");
                    newSong.SongName = Console.ReadLine();

                    Console.Write("Enter Song Genre: ");
                    newSong.SongGenre = Console.ReadLine();

                    playlist.Add(newSong);
                    break;

                case "2":
                    Console.Write("Enter Song ID to remove: ");
                    int removeId = int.Parse(Console.ReadLine());
                    playlist.Remove(removeId);
                    break;

                case "3":
                    Console.Write("Enter Song ID to search: ");
                    int searchId = int.Parse(Console.ReadLine());
                    Song songById = playlist.GetSongById(searchId);
                    Console.WriteLine(songById != null ? songById.ToString() : "Song not found.");
                    break;

                case "4":
                    Console.Write("Enter Song Name to search: ");
                    string searchName = Console.ReadLine();
                    Song songByName = playlist.GetSongByName(searchName);
                    Console.WriteLine(songByName != null ? songByName.ToString() : "Song not found.");
                    break;

                case "5":
                    var allSongs = playlist.GetAllSongs();
                    if (allSongs.Count == 0)
                    {
                        Console.WriteLine("Playlist is empty.");
                    }
                    else
                    {
                        Console.WriteLine("Songs in Playlist:");
                        allSongs.ForEach(song => Console.WriteLine(song));
                    }
                    break;

                case "6":
                    Console.WriteLine("Exiting application...");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
