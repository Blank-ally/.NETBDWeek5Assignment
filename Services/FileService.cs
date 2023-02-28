using System;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ApplicationTemplate.Services;

/// <summary>
///     This concrete service and method only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public class FileService : IFileService
{
    private readonly ILogger<IFileService> _logger;
   MovieList list = new MovieList();
    Movie movie;

    public FileService(ILogger<IFileService> logger)
    {
        _logger = logger;
    }
    public void Read()
    {
        _logger.Log(LogLevel.Information, "Reading");

        list.getMovies();
        Console.WriteLine("*** I am reading");
    }

    public void Write( Int64 id, string title, string[] genres)
    {
        _logger.Log(LogLevel.Information, "Writing");
        movie = new Movie(id,title,genres);

        string json = JsonConvert.SerializeObject(movie);
        list.AddMovie(movie,json);
        
        Console.WriteLine("*** I am writing");
    }
}
