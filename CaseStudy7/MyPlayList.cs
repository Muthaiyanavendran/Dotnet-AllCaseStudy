using System;
using System.Collections.Generic;
using System.Linq;

public class MyPlayList : IPlaylist
{
    public static List<Song> myPlayList = new List<Song>();
    private readonly int capacity;

    public MyPlayList()
    {
        capacity = 20;
    }

    public void Add(Song song)
    {
        List<string> allowedGenres = new List<string>
        { "Pop", "HipHop", "Soul Music", "Jazz", "Rock", "Disco", "Melody", "Classic" };

        if (myPlayList.Count >= capacity)
        {
            Console.WriteLine("Cannot add more than 20 songs to the playlist.");
            return;
        }

        if (!allowedGenres.Contains(song.SongGenre))
        {
            Console.WriteLine("Invalid genre. Allowed genres: Pop, HipHop, Soul Music, Jazz, Rock, Disco, Melody, Classic.");
            return;
        }

        if (myPlayList.Any(s => s.SongId == song.SongId))
        {
            Console.WriteLine("Song with this ID already exists.");
            return;
        }

        myPlayList.Add(song);
        Console.WriteLine("Song added successfully.");
    }

    public void Remove(int SongId)
    {
        var song = myPlayList.FirstOrDefault(s => s.SongId == SongId);
        if (song != null)
        {
            myPlayList.Remove(song);
            Console.WriteLine("Song removed successfully.");
        }
        else
        {
            Console.WriteLine("Song not found with given ID.");
        }
    }

    public Song GetSongById(int songId)
    {
        return myPlayList.FirstOrDefault(s => s.SongId == songId);
    }

    public Song GetSongByName(string songName)
    {
        return myPlayList.FirstOrDefault(s => s.SongName.Equals(songName, StringComparison.OrdinalIgnoreCase));
    }

    public List<Song> GetAllSongs()
    {
        return myPlayList;
    }
}
