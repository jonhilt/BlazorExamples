using System.Collections.Generic;
using System.Linq;

namespace BlazorExamples.Pages.Examples.StateViaUrl;

public record Movie(int Id, string Title, string Year, string Plot);

public class MovieDatabase
{
    private readonly IEnumerable<Movie> _movies = new List<Movie>
    {
        new Movie(1, "Star Trek II The Wrath of Khan", "1982",
            "With the assistance of the Enterprise crew, Admiral Kirk must stop an old nemesis, Khan Noonien Singh, from using the life-generating Genesis Device as the ultimate weapon"),
        new Movie(2, "The Matrix", "1999",
            "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth -- the life he knows is the elaborate deception of an evil cyber-intelligence"),
        new Movie(3, "Paddington", "2014", "A young Peruvian bear travels to London in search of a home"),
        new Movie(4, "Trolls", "2016",
            "After the Bergens invade Troll Village, Poppy, the happiest Troll ever born, and the curmudgeonly Branch set off on a journey to rescue her friends.")
    };

    public IEnumerable<Movie> GetMovies()
    {
        return _movies;
    }

    public IEnumerable<Movie> GetMovies(IEnumerable<int> ids)
    {
        return _movies.Where(x => ids.Contains(x.Id));
    }
}